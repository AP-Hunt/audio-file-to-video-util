using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xabe.FFmpeg;
using Xabe.FFmpeg.Downloader;

namespace AudioToVideo
{
    enum State
    {
        Ready,
        Converting,
    }

    public partial class Form1 : Form
    {
        private CancellationTokenSource _cts;
        private State _state;

        public Form1()
        {
            InitializeComponent();
            _cts = new CancellationTokenSource();
            _state = State.Ready;

            lblAudoFile.Text = Language.AudioFile;
            lblCoverArt.Text = Language.CovertArt;
            btnCreate.Text = Language.Convert;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAudioFile.Text = "";
            txtCoverArt.Text = "";

            dialogSaveOutput.Filter = "AVI Video file|*.avi";

            this.FormClosing += Form1_Closing;
            Application.ApplicationExit += Application_ApplicationExit; ;
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            CancelAnyTokens();
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            CancelAnyTokens();
        }

        private void CancelAnyTokens()
        {
            if (!_cts.IsCancellationRequested)
            {
                _cts.Cancel();
            }
        }

        private void btnOpenAudioFile_Click(object sender, EventArgs e)
        {
            DialogResult result = dialogOpenAudioFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = dialogOpenAudioFile.FileName;
                txtAudioFile.Text = fileName;
            }
        }

        private void btnOpenCoverArt_Click(object sender, EventArgs e)
        {
            DialogResult result = dialogOpenCoverArt.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = dialogOpenCoverArt.FileName;
                txtCoverArt.Text = fileName;
            }
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (_state == State.Ready)
            {
                await Convert();
            }
            else
            {
                CancelConversion();
            }

        }

        private async Task Convert()
        {
            DialogResult result = dialogSaveOutput.ShowDialog();
            string outputPath = "";
            if (result == DialogResult.OK)
            {
                outputPath = dialogSaveOutput.FileName;
            }
            else
            {
                return;
            }

            txtOutput.Text = "";
            prgProgressBar.Value = 0;

            string audio = dialogOpenAudioFile.FileName;
            string image = dialogOpenCoverArt.FileName;

            await FFmpegDownloader.GetLatestVersion(FFmpegVersion.Official);

            // FFMpeg arguments based on this answer
            // https://superuser.com/a/1041818
            IConversion conversion = FFmpeg.Conversions.New();
            conversion
                .SetOutput(outputPath)
                .SetOverwriteOutput(true)
                .AddParameter("-loop 1")
                .AddParameter("-y")
                .AddParameter($"-i {image}")
                .AddParameter($"-i {audio}")
                .AddParameter("-shortest")
                .AddParameter("-framerate 2")
                .AddParameter("-acodec copy")
                .AddParameter("-vcodec mjpeg")
                .AddParameter("-preset ultrafast");

            string ffmpegParams = conversion.Build();
            txtOutput.AppendText($"ffmpeg {ffmpegParams}{Environment.NewLine}");

            conversion.OnDataReceived += Conversion_OnDataReceived;
            conversion.OnProgress += Conversion_OnProgress;

            try
            {
                _state = State.Converting;
                btnCreate.Text = Language.Stop;
                IConversionResult conversionResult = await conversion.Start(_cts.Token);
            }
            catch (OperationCanceledException) { }
            catch (Exception ex)
            {
                _state = State.Ready;
                btnCreate.Text = Language.Convert;
                txtOutput.AppendText(Environment.NewLine + Environment.NewLine + ex.Message);
            }
        }

        private void CancelConversion()
        {
            _state = State.Ready;
            btnCreate.Text = Language.Convert;
            prgProgressBar.Value = 0;
            txtOutput.AppendText(Environment.NewLine + Environment.NewLine + "CANCELLED");

            CancelAnyTokens();
        }

        private void Conversion_OnProgress(object sender, Xabe.FFmpeg.Events.ConversionProgressEventArgs args)
        {
            this.Invoke(new Action(() =>
            {
                this.prgProgressBar.Value = args.Percent;
            }));
        }

        private void Conversion_OnDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            if (this.IsDisposed)
            {
                return;
            }

            this.Invoke(new Action(() =>
            {
                string[] lines = e
                    .Data
                    .Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                foreach (string l in lines)
                {
                    txtOutput.AppendText(l + Environment.NewLine);
                }
            }));
        }
    }
}
