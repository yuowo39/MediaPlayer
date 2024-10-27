using System.ComponentModel;

namespace MediaPlayer
{
    partial class NAudioForm
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
            this.btnPlayTwoFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlayTwoFiles
            // 
            this.btnPlayTwoFiles.Location = new System.Drawing.Point(12, 12);
            this.btnPlayTwoFiles.Name = "btnPlayTwoFiles";
            this.btnPlayTwoFiles.Size = new System.Drawing.Size(238, 52);
            this.btnPlayTwoFiles.TabIndex = 0;
            this.btnPlayTwoFiles.Text = "Play Two Files Simultaneously";
            this.btnPlayTwoFiles.UseVisualStyleBackColor = true;
            this.btnPlayTwoFiles.Click += new System.EventHandler(this.btnPlayTwoFiles_Click);
            // 
            // NAudioForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(262, 76);
            this.Controls.Add(this.btnPlayTwoFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NAudioForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NAudio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NAudioForm_FormClosing);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnPlayTwoFiles;

        #endregion
    }
}