namespace AudioToVideo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAudoFile = new System.Windows.Forms.Label();
            this.btnOpenAudioFile = new System.Windows.Forms.Button();
            this.txtAudioFile = new System.Windows.Forms.TextBox();
            this.dialogOpenAudioFile = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCoverArt = new System.Windows.Forms.Label();
            this.btnOpenCoverArt = new System.Windows.Forms.Button();
            this.txtCoverArt = new System.Windows.Forms.TextBox();
            this.dialogOpenCoverArt = new System.Windows.Forms.OpenFileDialog();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.dialogSaveOutput = new System.Windows.Forms.SaveFileDialog();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblAudoFile);
            this.flowLayoutPanel2.Controls.Add(this.btnOpenAudioFile);
            this.flowLayoutPanel2.Controls.Add(this.txtAudioFile);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(720, 30);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // lblAudoFile
            // 
            this.lblAudoFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAudoFile.AutoSize = true;
            this.lblAudoFile.Location = new System.Drawing.Point(3, 8);
            this.lblAudoFile.Name = "lblAudoFile";
            this.lblAudoFile.Size = new System.Drawing.Size(48, 13);
            this.lblAudoFile.TabIndex = 0;
            this.lblAudoFile.Text = "Audo file";
            // 
            // btnOpenAudioFile
            // 
            this.btnOpenAudioFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOpenAudioFile.Location = new System.Drawing.Point(57, 3);
            this.btnOpenAudioFile.Name = "btnOpenAudioFile";
            this.btnOpenAudioFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenAudioFile.TabIndex = 2;
            this.btnOpenAudioFile.Text = "Choose";
            this.btnOpenAudioFile.UseVisualStyleBackColor = true;
            this.btnOpenAudioFile.Click += new System.EventHandler(this.btnOpenAudioFile_Click);
            // 
            // txtAudioFile
            // 
            this.txtAudioFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtAudioFile.Enabled = false;
            this.txtAudioFile.Location = new System.Drawing.Point(138, 4);
            this.txtAudioFile.Name = "txtAudioFile";
            this.txtAudioFile.Size = new System.Drawing.Size(571, 20);
            this.txtAudioFile.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblCoverArt);
            this.flowLayoutPanel1.Controls.Add(this.btnOpenCoverArt);
            this.flowLayoutPanel1.Controls.Add(this.txtCoverArt);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(720, 30);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // lblCoverArt
            // 
            this.lblCoverArt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCoverArt.AutoSize = true;
            this.lblCoverArt.Location = new System.Drawing.Point(3, 8);
            this.lblCoverArt.Name = "lblCoverArt";
            this.lblCoverArt.Size = new System.Drawing.Size(50, 13);
            this.lblCoverArt.TabIndex = 0;
            this.lblCoverArt.Text = "Cover art";
            // 
            // btnOpenCoverArt
            // 
            this.btnOpenCoverArt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOpenCoverArt.Location = new System.Drawing.Point(59, 3);
            this.btnOpenCoverArt.Name = "btnOpenCoverArt";
            this.btnOpenCoverArt.Size = new System.Drawing.Size(75, 23);
            this.btnOpenCoverArt.TabIndex = 1;
            this.btnOpenCoverArt.Text = "Choose";
            this.btnOpenCoverArt.UseVisualStyleBackColor = true;
            this.btnOpenCoverArt.Click += new System.EventHandler(this.btnOpenCoverArt_Click);
            // 
            // txtCoverArt
            // 
            this.txtCoverArt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCoverArt.Enabled = false;
            this.txtCoverArt.Location = new System.Drawing.Point(140, 4);
            this.txtCoverArt.Name = "txtCoverArt";
            this.txtCoverArt.Size = new System.Drawing.Size(569, 20);
            this.txtCoverArt.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 86);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(720, 60);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Heckin\' Convert";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 153);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(720, 174);
            this.txtOutput.TabIndex = 5;
            // 
            // dialogSaveOutput
            // 
            this.dialogSaveOutput.DefaultExt = "mp4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 338);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Convert audio to video";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblAudoFile;
        private System.Windows.Forms.Button btnOpenAudioFile;
        private System.Windows.Forms.TextBox txtAudioFile;
        private System.Windows.Forms.OpenFileDialog dialogOpenAudioFile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblCoverArt;
        private System.Windows.Forms.Button btnOpenCoverArt;
        private System.Windows.Forms.TextBox txtCoverArt;
        private System.Windows.Forms.OpenFileDialog dialogOpenCoverArt;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.SaveFileDialog dialogSaveOutput;
    }
}

