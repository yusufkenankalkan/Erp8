namespace AracTakip
{
    public partial class Form1 : Form
    {
        private List<Arac> _araclar = new List<Arac>();
        private Arac? _seciliArac;

        ////Foto
        private MemoryStream _memoryStream = new MemoryStream();
        private int _buffersize = 64;
        private byte[] _photoBytes = new byte[64];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //if (_seciliArac == null)
            try
            {
                Arac yeniArac = new Arac()
                {
                    Marka = txtMarka.Text,
                    Model = txtModel.Text,
                    ModelYili = txtModelYili.Text,
                    Sase = txtSase.Text,
                    MotorHacmi = txtMotorHacmi.Text,
                };
                foreach (Control item in gbYakit.Controls)
                {
                    if ((item as RadioButton).Checked)
                    {
                        yeniArac.YakitTürü = item.Text;
                    }
                }
                foreach (Control item in gbVites.Controls)
                {
                    if ((item as RadioButton).Checked)
                    {
                        yeniArac.VitesTipi = item.Text;
                    }
                }
                _araclar.Add(yeniArac);
                lstAraclar.DataSource = null;
                lstAraclar.DataSource = _araclar;
                FormuTemizle(this.Controls);


            }
            catch (Exception ex)
            {

                MessageBox.Show($"Bir Hata Oluþtu ! {ex.Message}");
            }


        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _seciliArac.Marka = txtMarka.Text;
                _seciliArac.Model = txtModel.Text;
                _seciliArac.ModelYili = txtModelYili.Text;
                _seciliArac.Sase = txtSase.Text;
                _seciliArac.MotorHacmi = txtMotorHacmi.Text;
                FormuTemizle(this.Controls);
                _seciliArac = null;
                lstAraclar.DataSource = null;
                lstAraclar.DataSource = _araclar;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Bir Hata Oluþtu ! {ex.Message}");
            }
        }

        public void FormuTemizle(Control.ControlCollection controls)
        {
            foreach (Control item in controls)
            {
                if (item is TextBox) item.Text = string.Empty;
                else if (item is CheckBox cBox) cBox.Checked = false;
                else if (item is ComboBox combo) combo.SelectedIndex = -1;
                else if (item is ListBox listBox) listBox.SelectedIndex = -1;
                else if (item is RadioButton radioButton) radioButton.Checked = false;
                else if (item is GroupBox groupBox) FormuTemizle(groupBox.Controls);
            }
        }

        private void lstAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAraclar.SelectedItem == null)
            {
                _seciliArac = null;
                return;
            }
            _seciliArac = lstAraclar.SelectedItem as Arac;
            txtMarka.Text = _seciliArac.Marka;
            txtModel.Text = _seciliArac.Model;
            txtModelYili.Text = _seciliArac.ModelYili;
            txtSase.Text = _seciliArac.Sase;
            txtMotorHacmi.Text = _seciliArac.MotorHacmi;

        }


    }
}