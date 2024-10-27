using System;
using System.Data;
using System.Windows.Forms;
using NAudio.Wave;

namespace MediaPlayer
{
    public partial class NAudioForm : Form
    {
        private WaveOut output;
        private WaveOut output2;
        
        public NAudioForm()
        {
            InitializeComponent();
            output = new WaveOut();
            output2 = new WaveOut();
        }

        private void btnPlayTwoFiles_Click(object sender, EventArgs e)
        {
            // Sample Sound Files from
            // https://www2.cs.uic.edu/~i101/SoundFiles/

            WaveStream audioStream = new AudioFileReader(@"Resources/CantinaBand60.wav");
            WaveStream audioStream2 = new AudioFileReader(@"Resources/Fanfare60.wav");
            
            output.Init(audioStream);
            output2.Init(audioStream2);

            audioStream.CurrentTime = new TimeSpan(0L);
            audioStream2.CurrentTime = new TimeSpan(0L);
            
            output.Play();
            output2.Play();
        }

        private void NAudioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            output.Dispose();
            output2.Dispose();
        }
    }
}