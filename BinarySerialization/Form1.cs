using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;

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
                    if (_memoryStream.Length > 0)
                    {
                        yeniKisi.Fotograf = _memoryStream.ToArray();
                    }
                    _memoryStream = new MemoryStream();
                    //lstKisiler.DisplayMember = "Ad";
                    //lstKisiler.Items.Add(yeniKisi);
                    _kisiler.Add(yeniKisi);
                    lstKisiler.DataSource = _kisiler;
                    FormuTemizle();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Bir Hata Oluştu ! {ex.Message}");
                }
            else // Güncelleme İşlemi
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

                    MessageBox.Show($"Bir Hata Oluştu ! {ex.Message}");
                }
            }
        }
        public void FormuTemizle()
        {
            foreach (Control item in this.Controls)
            {
                // TODO: Formdaki textbox ve datetimepickerları ilk açıldığı hale getirin
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
                pbAvatar.Image = _seciliKisi.Fotograf != null ? Image.FromStream(new MemoryStream(_seciliKisi.Fotograf)) : null;

                btnKaydet.Text = "Güncelle";
            }
        }

        private void silToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;
            var seciliKisi = lstKisiler.SelectedItem as Kisi;
            DialogResult result = MessageBox.Show($"{seciliKisi.Ad} {seciliKisi.Soyad} kişisini silmek istiyor musunuz ? ", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
        private MemoryStream _memoryStream = new MemoryStream();
        private int _bufferSize = 64;
        private byte[] _photoBytes = new byte[64];
        private object xmlserializer;

        private void pbAvatar_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir fotoğraf dosyası seçiniz";
            dosyaAc.Filter = "JPG Dosyaları(*.jpg) | *.jpg";
            dosyaAc.FileName = string.Empty;
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                _memoryStream = new MemoryStream();
                //FileStream fileStream = new FileStream(dosyaAc.FileName, FileMode.Open);
                FileStream fileStream = File.Open(dosyaAc.FileName, FileMode.Open);
                while (fileStream.Read(_photoBytes, 0, _bufferSize) != 0)
                {
                    _memoryStream.Write(_photoBytes, 0, _bufferSize);
                }
                fileStream.Close();
                fileStream.Dispose();

                pbAvatar.Image = Image.FromStream(_memoryStream);
                //pbAvatar.Image = new Bitmap(_memoryStream);

                //pbAvatar.ImageLocation = dosyaAc.FileName;
            }
        }

        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //XML
            dosyaKaydet.Title = "Kişileri XLM olarak kaydet";
            dosyaKaydet.Filter = "XML Dosyaları (*.xml) | *.xml";
            dosyaKaydet.FileName = "Kişiler.xml";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Kisi>));
                TextWriter textWriter = new StreamWriter(dosyaKaydet.FileName);
                serializer.Serialize(textWriter, _kisiler);
                textWriter.Close();
                textWriter.Dispose();
                MessageBox.Show($"XML dışarı aktarma işlemi başarılı : {dosyaKaydet.FileName} ");
            }
        }

        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Kişileri XLM olarak kaydet";
            dosyaAc.Filter = "XML Dosyaları (*.xml) | *.xml";
            dosyaAc.FileName = "Kişiler.xml";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Kisi>));
                XmlReader xmlReader = new XmlTextReader(dosyaAc.FileName);
                if (serializer.CanDeserialize(xmlReader))
                {
                    _kisiler = serializer.Deserialize(xmlReader) as List<Kisi>;
                    MessageBox.Show($"{_kisiler.Count} kişi sisteme başarıyla eklendi");
                    lstKisiler.DataSource = null;
                    lstKisiler.DataSource = _kisiler;
                }
                else
                {
                    MessageBox.Show("Lütfen doğru xml dosyasını seçin!");
                }

            }

        }

        private void dışarıAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Title = "Bir JSON dosyasý seçiniz";
            dosyaKaydet.Filter = "(JSON Dosyasý) | *.json";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaKaydet.FileName = "Kisiler.json";
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                FileStream file = File.Open(dosyaKaydet.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(JsonConvert.SerializeObject(_kisiler));
                writer.Close();
                writer.Dispose();
            }
        }

        private void içeriAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir JSON dosyasý seçiniz";
            dosyaAc.Filter = "(JSON Dosyasý) | *.json";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "Kisiler.json";
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.OpenRead(dosyaAc.FileName);
                StreamReader reader = new StreamReader(dosya);
                string dosyaIcerigi = reader.ReadToEnd();
                //_kisiler = JsonConvert.DeserializeObject(dosyaIcerigi) as List<Kisi>;
                _kisiler = JsonConvert.DeserializeObject<List<Kisi>>(dosyaIcerigi);

                lstKisiler.DataSource = null;
                lstKisiler.DataSource = _kisiler;
            }
        }
    }
}