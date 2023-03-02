using KalitimLib;

namespace Kalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kare yeniKare = new Kare();
            yeniKare.X = 5;
            this.Text = $"Karenin alaný : {yeniKare.AlanHesapla()}";
        }
    }
}