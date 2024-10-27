namespace MediaPlayer
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.othersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nAudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // wmp
            // 
            this.wmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(0, 28);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(702, 445);
            this.wmp.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem, this.othersToolStripMenuItem, this.helpToolStripMenuItem });
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(702, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.openToolStripMenuItem, this.exitToolStripMenuItem });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // othersToolStripMenuItem
            // 
            this.othersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.soundPlayerToolStripMenuItem, this.nAudioToolStripMenuItem });
            this.othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            this.othersToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.othersToolStripMenuItem.Text = "Others";
            // 
            // soundPlayerToolStripMenuItem
            // 
            this.soundPlayerToolStripMenuItem.Name = "soundPlayerToolStripMenuItem";
            this.soundPlayerToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.soundPlayerToolStripMenuItem.Text = "Sound Player";
            this.soundPlayerToolStripMenuItem.Click += new System.EventHandler(this.soundPlayerToolStripMenuItem_Click);
            // 
            // nAudioToolStripMenuItem
            // 
            this.nAudioToolStripMenuItem.Name = "nAudioToolStripMenuItem";
            this.nAudioToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.nAudioToolStripMenuItem.Text = "NAudio";
            this.nAudioToolStripMenuItem.Click += new System.EventHandler(this.nAudioToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.aboutToolStripMenuItem });
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // App
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(702, 473);
            this.Controls.Add(this.wmp);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(320, 320);
            this.Name = "App";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player";
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem nAudioToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem soundPlayerToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem othersToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menu;

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmp;
    }
}

