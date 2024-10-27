using System.ComponentModel;

namespace MediaPlayer
{
    partial class SoundPlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lbFileLocation = new System.Windows.Forms.Label();
            this.lbFilepath = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFileLocation
            // 
            this.lbFileLocation.Location = new System.Drawing.Point(12, 75);
            this.lbFileLocation.Name = "lbFileLocation";
            this.lbFileLocation.Size = new System.Drawing.Size(100, 23);
            this.lbFileLocation.TabIndex = 0;
            this.lbFileLocation.Text = "File Location";
            // 
            // lbFilepath
            // 
            this.lbFilepath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbFilepath.Location = new System.Drawing.Point(12, 98);
            this.lbFilepath.Name = "lbFilepath";
            this.lbFilepath.Size = new System.Drawing.Size(249, 195);
            this.lbFilepath.TabIndex = 1;
            this.lbFilepath.Text = "No file read";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(12, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(106, 39);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(155, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(106, 39);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // SoundPlayerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(273, 302);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lbFilepath);
            this.Controls.Add(this.lbFileLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SoundPlayerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sound Player";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnPlay;

        private System.Windows.Forms.Label lbFileLocation;
        private System.Windows.Forms.Label lbFilepath;
        private System.Windows.Forms.Button btnOpenFile;

        #endregion
    }
}