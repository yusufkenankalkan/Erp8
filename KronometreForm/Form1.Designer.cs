namespace KronometreForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblEkran = new System.Windows.Forms.Label();
            this.btnBaslatDurdur = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.pbKalanSure = new System.Windows.Forms.ProgressBar();
            this.cbGeriSayim = new System.Windows.Forms.CheckBox();
            this.gbKontrol = new System.Windows.Forms.GroupBox();
            this.cmbSaniye = new System.Windows.Forms.ComboBox();
            this.cmbDakika = new System.Windows.Forms.ComboBox();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.gbKontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEkran
            // 
            this.lblEkran.AutoSize = true;
            this.lblEkran.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEkran.Location = new System.Drawing.Point(12, 138);
            this.lblEkran.Name = "lblEkran";
            this.lblEkran.Size = new System.Drawing.Size(126, 32);
            this.lblEkran.TabIndex = 0;
            this.lblEkran.Text = "00:00:000";
            this.lblEkran.Click += new System.EventHandler(this.lblEkran_Click);
            // 
            // btnBaslatDurdur
            // 
            this.btnBaslatDurdur.Location = new System.Drawing.Point(187, 118);
            this.btnBaslatDurdur.Name = "btnBaslatDurdur";
            this.btnBaslatDurdur.Size = new System.Drawing.Size(85, 82);
            this.btnBaslatDurdur.TabIndex = 1;
            this.btnBaslatDurdur.Text = "Başlat";
            this.btnBaslatDurdur.UseVisualStyleBackColor = true;
            this.btnBaslatDurdur.Click += new System.EventHandler(this.btnBaslatDurdur_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.Location = new System.Drawing.Point(320, 118);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(85, 82);
            this.btnSifirla.TabIndex = 2;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // tmr1
            // 
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // pbKalanSure
            // 
            this.pbKalanSure.Location = new System.Drawing.Point(34, 223);
            this.pbKalanSure.Name = "pbKalanSure";
            this.pbKalanSure.Size = new System.Drawing.Size(371, 29);
            this.pbKalanSure.TabIndex = 3;
            // 
            // cbGeriSayim
            // 
            this.cbGeriSayim.AutoSize = true;
            this.cbGeriSayim.Location = new System.Drawing.Point(34, 34);
            this.cbGeriSayim.Name = "cbGeriSayim";
            this.cbGeriSayim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbGeriSayim.Size = new System.Drawing.Size(117, 19);
            this.cbGeriSayim.TabIndex = 4;
            this.cbGeriSayim.Text = "Geri Sayım Modu";
            this.cbGeriSayim.UseVisualStyleBackColor = true;
            this.cbGeriSayim.CheckedChanged += new System.EventHandler(this.cbGeriSayim_CheckedChanged);
            // 
            // gbKontrol
            // 
            this.gbKontrol.Controls.Add(this.cmbSaniye);
            this.gbKontrol.Controls.Add(this.cmbDakika);
            this.gbKontrol.Controls.Add(this.cmbSaat);
            this.gbKontrol.Location = new System.Drawing.Point(187, 12);
            this.gbKontrol.Name = "gbKontrol";
            this.gbKontrol.Size = new System.Drawing.Size(218, 100);
            this.gbKontrol.TabIndex = 5;
            this.gbKontrol.TabStop = false;
            this.gbKontrol.Text = "Geri Sayım Kontrolleri";
            this.gbKontrol.Visible = false;
            // 
            // cmbSaniye
            // 
            this.cmbSaniye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaniye.FormattingEnabled = true;
            this.cmbSaniye.Location = new System.Drawing.Point(148, 22);
            this.cmbSaniye.Name = "cmbSaniye";
            this.cmbSaniye.Size = new System.Drawing.Size(63, 23);
            this.cmbSaniye.TabIndex = 2;
            // 
            // cmbDakika
            // 
            this.cmbDakika.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDakika.FormattingEnabled = true;
            this.cmbDakika.Location = new System.Drawing.Point(79, 22);
            this.cmbDakika.Name = "cmbDakika";
            this.cmbDakika.Size = new System.Drawing.Size(63, 23);
            this.cmbDakika.TabIndex = 1;
            // 
            // cmbSaat
            // 
            this.cmbSaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaat.FormattingEnabled = true;
            this.cmbSaat.Location = new System.Drawing.Point(5, 22);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(63, 23);
            this.cmbSaat.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 278);
            this.Controls.Add(this.gbKontrol);
            this.Controls.Add(this.cbGeriSayim);
            this.Controls.Add(this.pbKalanSure);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnBaslatDurdur);
            this.Controls.Add(this.lblEkran);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbKontrol.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEkran;
        private Button btnBaslatDurdur;
        private Button btnSifirla;
        private System.Windows.Forms.Timer tmr1;
        private ProgressBar pbKalanSure;
        private CheckBox cbGeriSayim;
        private GroupBox gbKontrol;
        private ComboBox cmbSaniye;
        private ComboBox cmbDakika;
        private ComboBox cmbSaat;
    }
}