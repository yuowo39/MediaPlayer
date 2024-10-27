using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            // File types supported by Windows Media Player
            // https://support.microsoft.com/en-us/topic/file-types-supported-by-windows-media-player-32d9998e-dc8f-af54-7ba1-e996f74375d9
            ofd.Filter = "All Supported Files|*.mp3;*.wav;*.wma;*.m4a;*.flac;*.mp4;*.avi;*.wmv;*.mov|" +
                         "Audio Files|*.mp3;*.wav;*.wma;*.m4a;*.flac|" +
                         "Video Files|*.mp4;*.avi;*.wmv;*.mov";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                wmp.URL = ofd.FileName;
                wmp.Ctlcontrols.play();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void soundPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var openedForm in Application.OpenForms)
            {
                if (openedForm is SoundPlayerForm soundPlayerForm)
                {
                    soundPlayerForm.BringToFront();
                    return;
                }
            }
            
            SoundPlayerForm newSoundPlayerForm = new SoundPlayerForm();
            newSoundPlayerForm.Show();
        }

        private void nAudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var openedForm in Application.OpenForms)
            {
                if (openedForm is NAudioForm nAudioForm)
                {
                    nAudioForm.BringToFront();
                    return;
                }
            }
            
            NAudioForm newNAudioForm = new NAudioForm();
            newNAudioForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var openedForm in Application.OpenForms)
            {
                if (openedForm is About about)
                {
                    about.BringToFront();
                    return;
                }
            }
            
            About newAbout = new About();
            newAbout.ShowDialog();
        }
    }
}
