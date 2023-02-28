using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaGiris
{
    public partial class FormKisiler : Form
    {
        public FormKisiler()
        {
            InitializeComponent();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {

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
                lstKisiler.Items.Add(yeniKisi);
                FormuTemizle();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Bir Hata Oluştu ! {ex.Message}");
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
            }
            dtpDogumTarihi.Value = DateTime.Now; 
        }
    }
}
