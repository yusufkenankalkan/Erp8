namespace BinarySerialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Kisi> _kisiler = new List<Kisi>();
        private Kisi? _seciliKisi;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_seciliKisi == null)

                try
                {
                    //var kisi = new Kisi();
                    //kisi.Ad = txtAd.Text;
                    //kisi.Soyad = txtSoyad.Text;
                    //kisi.Tckn = txtTckn.Text;
                    //kisi.DogumTarihi = dtpDogumTarihi.Value;
                    //kisi.Telefon = txtTelefon.Text;
                    //kisi.Email = txtEmail.Text;

                    Kisi yeniKisi = new Kisi() //Object Initializer
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        Tckn = txtTckn.Text,
                        Email = txtEmail.Text,
                        Telefon = txtTelefon.Text,
                        DogumTarihi = dtpDogumTarihi.Value

                    };
                    //lstKisiler.DisplayMember = "Ad";
                    //lstKisiler.Items.Add(yeniKisi);
                    _kisiler.Add(yeniKisi);
                    lstKisiler.DataSource = _kisiler;
                    FormuTemizle();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Bir Hata Oluþtu ! {ex.Message}");
                }
            else // Güncelleme Ýþlemi
            {
                try
                {

                    _seciliKisi.Ad = txtAd.Text;
                    _seciliKisi.Soyad = txtSoyad.Text;
                    _seciliKisi.Tckn = txtTckn.Text;
                    _seciliKisi.Telefon = txtTelefon.Text;
                    _seciliKisi.Email = txtEmail.Text;
                    _seciliKisi.DogumTarihi = dtpDogumTarihi.Value;
                    FormuTemizle();
                    btnKaydet.Text = "Kaydet";
                    _seciliKisi = null;
                    lstKisiler.DataSource = null;
                    lstKisiler.DataSource = _kisiler;
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Bir Hata Oluþtu ! {ex.Message}");
                }
            }
        }
        public void FormuTemizle()
        {
            foreach (Control item in this.Controls)
            {
                // TODO: Formdaki textbox ve datetimepickerlarý ilk açýldýðý hale getirin
                //item.Text = String.Empty;
                if (item is TextBox)
                    item.Text = String.Empty;
                else if (item is DateTimePicker dPicker)
                {
                    //(item as DateTimePicker).Value = DateTime.Now;
                    //((DateTimePicker)item).Value = DateTime.Now;
                    dPicker.Value = DateTime.Now;
                }
                else if (item is CheckBox cBox)
                    cBox.Checked = false;
                else if (item is ComboBox combo)
                    combo.SelectedIndex = -1;
                else if (item is ListBox listbox)
                    listbox.SelectedIndex = -1;
            }

        }

        



        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            string arama = txtAra.Text.ToLower();
            //if (arama.Length < 3) return;

            List<Kisi> sonuc = new List<Kisi>();

            foreach (Kisi item in _kisiler)
            {
                if (item.Ad.ToLower().Contains(arama) || item.Soyad.ToLower().Contains(arama) || item.Tckn.ToLower().StartsWith(arama))
                    sonuc.Add(item);
            }
            lstKisiler.DataSource = null;
            lstKisiler.DataSource = sonuc;

            //2. yöntem
            sonuc = new();
            _kisiler.ForEach(item =>
            {
                if (item.Ad.ToLower().Contains(arama) || item.Soyad.ToLower().Contains(arama) || item.Tckn.ToLower().StartsWith(arama))
                    sonuc.Add(item);
            });
            lstKisiler.DataSource = null;
            lstKisiler.DataSource = sonuc;

            //3. yöntem (Linq)
            sonuc = _kisiler
                .Where(item => item.Ad.ToLower().Contains(arama) || item.Soyad.ToLower().Contains(arama) || item.Tckn.ToLower().StartsWith(arama))
                .ToList();

            lstKisiler.DataSource = null;
            lstKisiler.DataSource = sonuc;

        }

        private void lstKisiler_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            {
                if (lstKisiler.SelectedItem == null)
                {
                    _seciliKisi = null;
                    return;
                }
                _seciliKisi = lstKisiler.SelectedItem as Kisi;
                txtAd.Text = _seciliKisi.Ad;
                txtSoyad.Text = _seciliKisi.Soyad;
                txtTckn.Text = _seciliKisi.Tckn;
                txtTelefon.Text = _seciliKisi.Telefon;
                txtEmail.Text = _seciliKisi.Email;
                dtpDogumTarihi.Value = _seciliKisi.DogumTarihi;

                btnKaydet.Text = "Güncelle";
            }
        }

        private void silToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;
            var seciliKisi = lstKisiler.SelectedItem as Kisi;
            DialogResult result = MessageBox.Show($"{seciliKisi.Ad} {seciliKisi.Soyad} kiþisini silmek istiyor musunuz ? ", "Silme Onayý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //lstKisiler.Items.Remove(seciliKisi);
                _kisiler.Remove(seciliKisi);
                lstKisiler.DataSource = null;
                lstKisiler.DataSource = _kisiler;
                FormuTemizle();
                btnKaydet.Text = "Kaydet";
            }
        }


    }
}