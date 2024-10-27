using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            lbCopyright.Text = "\u00a9 2024 Yu\n\nThanks\nPedro Ferreira";
        }
    }
}