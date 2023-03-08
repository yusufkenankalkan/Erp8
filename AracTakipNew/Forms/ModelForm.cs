using AracTakipNew.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracTakipNew.Forms
{
    public partial class ModelForm : Form
    {
        public ModelForm()
        {
            InitializeComponent();
        }
        public List<Marka> Markalar { get; set; } = new();
        public List<Model> Liste { get; set; } = new();
        private void ModelForm_Load(object sender, EventArgs e)
        {
            cmbKasaTipi.DataSource = Enum.GetNames(typeof(KasaTipleri));
            cmbMarka.DataSource = Markalar;
        }
    }
}
