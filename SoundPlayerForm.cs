using System;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class SoundPlayerForm : Form
    {
        private string filepath;
        private System.Media.SoundPlayer player;
        
        public SoundPlayerForm()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Audio Files|*.wav";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
                lbFilepath.Text = filepath;
                // Moved the play function to the play button
                // player = new System.Media.SoundPlayerForm(ofd.FileName);
                // player.Play();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(filepath))
            {
                return;
            }

            player = new System.Media.SoundPlayer(filepath);
            player.Play();
        }
    }
}