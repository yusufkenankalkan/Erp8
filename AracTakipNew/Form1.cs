using AracTakipNew.Data;
using AracTakipNew.Forms;
using AracTakipNew.Helpers;
using AracTakipNew.Models;

namespace AracTakipNew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private EnvanterContext _dataContext;
        private MarkaForm _markaForm; //null tan�mlad�k
        private ModelForm _modelForm;

        private void Form1_Load(object sender, EventArgs e)
        {
            var data = DataHelper.Load();
            _dataContext = data ?? new();

        }

        private void markaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_markaForm == null || _markaForm.IsDisposed)
            {
                _markaForm = new MarkaForm();
                _markaForm.MdiParent = this;
                _markaForm.Text = "Marka Formu";
                _markaForm.DataContext = _dataContext;
                _markaForm.Show();
            }
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_modelForm == null || _modelForm.IsDisposed)
            {
                _modelForm = new ModelForm();
                _modelForm.MdiParent = this;
                _modelForm.Text = "Model Formu";
                _modelForm.DataContext = _dataContext;
                _modelForm.Show();
            }
        }


    }
}