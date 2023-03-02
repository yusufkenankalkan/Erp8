using KalitimLib;

namespace Kalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Sekil> sekiller = new List<Sekil>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Sekil yeniSekil = new Sekil();
            //yeniSekil.X = 4;

            Sekil yeniKare = new Kare();
            yeniKare.X = 5;
            this.Text = $"Karenin alaný : {yeniKare.AlanHesapla()}";

            Sekil yeniDikdortgen = new Dikdortgen()
            {
                X = 5,
                Y = 12
            };

            this.Text = $"Dikdörtgen alaný : {yeniDikdortgen.AlanHesapla()}";

            DikUcgen ucgen = new DikUcgen(6, 8);

            sekiller.Add(yeniKare);
            sekiller.Add(yeniDikdortgen);
            sekiller.Add(ucgen);
            //sekiller.Add(yeniSekil);
            foreach (Sekil item in sekiller)
            {
                Console.WriteLine(item.CevreHesapla());
            } 
        }
    }
}