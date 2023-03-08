namespace AracTakipNew.Forms
{
    partial class ModelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbKasaTipi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(166, 310);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(69, 47);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(90, 310);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(69, 47);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 15;
            this.lstListe.Location = new System.Drawing.Point(260, 23);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(176, 334);
            this.lstListe.TabIndex = 9;
            this.lstListe.SelectedIndexChanged += new System.EventHandler(this.lstListe_SelectedIndexChanged);
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(90, 159);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(145, 131);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 8;
            this.pbResim.TabStop = false;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(90, 69);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(145, 23);
            this.txtAd.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Model Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kasa Tipi";
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(90, 23);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(145, 23);
            this.cmbMarka.TabIndex = 14;
            // 
            // cmbKasaTipi
            // 
            this.cmbKasaTipi.FormattingEnabled = true;
            this.cmbKasaTipi.Location = new System.Drawing.Point(90, 116);
            this.cmbKasaTipi.Name = "cmbKasaTipi";
            this.cmbKasaTipi.Size = new System.Drawing.Size(145, 23);
            this.cmbKasaTipi.TabIndex = 15;
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 472);
            this.Controls.Add(this.cmbKasaTipi);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lstListe);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Name = "ModelForm";
            this.Text = "ModelForm";
            this.Load += new System.EventHandler(this.ModelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGuncelle;
        private Button btnKaydet;
        private ListBox lstListe;
        private PictureBox pbResim;
        private TextBox txtAd;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbMarka;
        private ComboBox cmbKasaTipi;
    }
}