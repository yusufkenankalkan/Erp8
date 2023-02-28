namespace WfaGiris
{
    partial class FormKisiler
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTckn = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.lstKisiler = new System.Windows.Forms.ListBox();
            this.cmsSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.cmsSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "TCKN :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Doğum Tarihi :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(123, 26);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(134, 23);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(123, 63);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(134, 23);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtTckn
            // 
            this.txtTckn.Location = new System.Drawing.Point(123, 100);
            this.txtTckn.Name = "txtTckn";
            this.txtTckn.Size = new System.Drawing.Size(134, 23);
            this.txtTckn.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(123, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(134, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(123, 174);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(134, 23);
            this.txtTelefon.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(123, 268);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(134, 34);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(123, 213);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(134, 23);
            this.dtpDogumTarihi.TabIndex = 5;
            // 
            // lstKisiler
            // 
            this.lstKisiler.ContextMenuStrip = this.cmsSil;
            this.lstKisiler.FormattingEnabled = true;
            this.lstKisiler.ItemHeight = 15;
            this.lstKisiler.Location = new System.Drawing.Point(284, 63);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(170, 169);
            this.lstKisiler.TabIndex = 7;
            this.lstKisiler.SelectedIndexChanged += new System.EventHandler(this.lstKisiler_SelectedIndexChanged);
            // 
            // cmsSil
            // 
            this.cmsSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem});
            this.cmsSil.Name = "cmsSil";
            this.cmsSil.Size = new System.Drawing.Size(117, 26);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(284, 26);
            this.txtAra.Name = "txtAra";
            this.txtAra.PlaceholderText = "Ara";
            this.txtAra.Size = new System.Drawing.Size(170, 23);
            this.txtAra.TabIndex = 8;
            this.txtAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyUp);
            // 
            // FormKisiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstKisiler);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTckn);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKisiler";
            this.Text = "FormKisiler";
            this.cmsSil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTckn;
        private TextBox txtEmail;
        private TextBox txtTelefon;
        private Button btnKaydet;
        private DateTimePicker dtpDogumTarihi;
        private ListBox lstKisiler;
        private ContextMenuStrip cmsSil;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        private TextBox txtAra;
    }
}