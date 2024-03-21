using System.Resources;

namespace Aimlab
{
    public partial class Form1 : Form
    {
        public Button btn = new Button();
        public Form1()
        {
            InitializeComponent();
            karpuz.Image = Resource1.karpuz;
        }

        private void YerDegistir()
        {
            karpuz.Location = new Point((new Random().Next(0, 400) + 200), (new Random().Next(0, 400) + 100));
            this.BackColor = Color.FromArgb(new Random().Next(255), new Random().Next(255), new Random().Next(255));
            karpuz.BackColor = this.BackColor;
        }

        private void karpuz_Click(object sender, EventArgs e)
        {
            YerDegistir();
        }
    }
}
