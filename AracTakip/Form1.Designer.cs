namespace AracTakip
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
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.lstAraclar = new System.Windows.Forms.ListBox();
            this.cmsSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbYakit = new System.Windows.Forms.GroupBox();
            this.rbtnElektrik = new System.Windows.Forms.RadioButton();
            this.rbtnLpg = new System.Windows.Forms.RadioButton();
            this.rbtnDizel = new System.Windows.Forms.RadioButton();
            this.rbtnBenzin = new System.Windows.Forms.RadioButton();
            this.gbVites = new System.Windows.Forms.GroupBox();
            this.rbtnYariOtomatik = new System.Windows.Forms.RadioButton();
            this.rbtnManuel = new System.Windows.Forms.RadioButton();
            this.rbtnOtomatik = new System.Windows.Forms.RadioButton();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtModelYili = new System.Windows.Forms.TextBox();
            this.txtSase = new System.Windows.Forms.TextBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMotorHacmi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.cmsSil.SuspendLayout();
            this.gbYakit.SuspendLayout();
            this.gbVites.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(12, 289);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(264, 214);
            this.pbAvatar.TabIndex = 0;
            this.pbAvatar.TabStop = false;
            // 
            // lstAraclar
            // 
            this.lstAraclar.ContextMenuStrip = this.cmsSil;
            this.lstAraclar.FormattingEnabled = true;
            this.lstAraclar.ItemHeight = 15;
            this.lstAraclar.Location = new System.Drawing.Point(303, 289);
            this.lstAraclar.Name = "lstAraclar";
            this.lstAraclar.Size = new System.Drawing.Size(264, 214);
            this.lstAraclar.TabIndex = 1;
            this.lstAraclar.SelectedIndexChanged += new System.EventHandler(this.lstAraclar_SelectedIndexChanged);
            // 
            // cmsSil
            // 
            this.cmsSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.cmsSil.Name = "cmsSil";
            this.cmsSil.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marka :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model Yılı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Şase No :";
            // 
            // gbYakit
            // 
            this.gbYakit.Controls.Add(this.rbtnElektrik);
            this.gbYakit.Controls.Add(this.rbtnLpg);
            this.gbYakit.Controls.Add(this.rbtnDizel);
            this.gbYakit.Controls.Add(this.rbtnBenzin);
            this.gbYakit.Location = new System.Drawing.Point(318, 6);
            this.gbYakit.Name = "gbYakit";
            this.gbYakit.Size = new System.Drawing.Size(249, 77);
            this.gbYakit.TabIndex = 6;
            this.gbYakit.TabStop = false;
            this.gbYakit.Text = "Yakıt Türü";
            // 
            // rbtnElektrik
            // 
            this.rbtnElektrik.AutoSize = true;
            this.rbtnElektrik.Location = new System.Drawing.Point(138, 52);
            this.rbtnElektrik.Name = "rbtnElektrik";
            this.rbtnElektrik.Size = new System.Drawing.Size(63, 19);
            this.rbtnElektrik.TabIndex = 3;
            this.rbtnElektrik.TabStop = true;
            this.rbtnElektrik.Text = "Elektirk";
            this.rbtnElektrik.UseVisualStyleBackColor = true;
            // 
            // rbtnLpg
            // 
            this.rbtnLpg.AutoSize = true;
            this.rbtnLpg.Location = new System.Drawing.Point(6, 52);
            this.rbtnLpg.Name = "rbtnLpg";
            this.rbtnLpg.Size = new System.Drawing.Size(46, 19);
            this.rbtnLpg.TabIndex = 2;
            this.rbtnLpg.TabStop = true;
            this.rbtnLpg.Text = "LPG";
            this.rbtnLpg.UseVisualStyleBackColor = true;
            // 
            // rbtnDizel
            // 
            this.rbtnDizel.AutoSize = true;
            this.rbtnDizel.Location = new System.Drawing.Point(138, 22);
            this.rbtnDizel.Name = "rbtnDizel";
            this.rbtnDizel.Size = new System.Drawing.Size(50, 19);
            this.rbtnDizel.TabIndex = 1;
            this.rbtnDizel.TabStop = true;
            this.rbtnDizel.Text = "Dizel";
            this.rbtnDizel.UseVisualStyleBackColor = true;
            // 
            // rbtnBenzin
            // 
            this.rbtnBenzin.AutoSize = true;
            this.rbtnBenzin.Location = new System.Drawing.Point(6, 22);
            this.rbtnBenzin.Name = "rbtnBenzin";
            this.rbtnBenzin.Size = new System.Drawing.Size(60, 19);
            this.rbtnBenzin.TabIndex = 0;
            this.rbtnBenzin.TabStop = true;
            this.rbtnBenzin.Text = "Benzin";
            this.rbtnBenzin.UseVisualStyleBackColor = true;
            // 
            // gbVites
            // 
            this.gbVites.Controls.Add(this.rbtnYariOtomatik);
            this.gbVites.Controls.Add(this.rbtnManuel);
            this.gbVites.Controls.Add(this.rbtnOtomatik);
            this.gbVites.Location = new System.Drawing.Point(318, 114);
            this.gbVites.Name = "gbVites";
            this.gbVites.Size = new System.Drawing.Size(232, 77);
            this.gbVites.TabIndex = 7;
            this.gbVites.TabStop = false;
            this.gbVites.Text = "Vites Tipi";
            // 
            // rbtnYariOtomatik
            // 
            this.rbtnYariOtomatik.AutoSize = true;
            this.rbtnYariOtomatik.Location = new System.Drawing.Point(6, 52);
            this.rbtnYariOtomatik.Name = "rbtnYariOtomatik";
            this.rbtnYariOtomatik.Size = new System.Drawing.Size(97, 19);
            this.rbtnYariOtomatik.TabIndex = 3;
            this.rbtnYariOtomatik.TabStop = true;
            this.rbtnYariOtomatik.Text = "Yarı Otomatik";
            this.rbtnYariOtomatik.UseVisualStyleBackColor = true;
            // 
            // rbtnManuel
            // 
            this.rbtnManuel.AutoSize = true;
            this.rbtnManuel.Location = new System.Drawing.Point(138, 22);
            this.rbtnManuel.Name = "rbtnManuel";
            this.rbtnManuel.Size = new System.Drawing.Size(65, 19);
            this.rbtnManuel.TabIndex = 2;
            this.rbtnManuel.TabStop = true;
            this.rbtnManuel.Text = "Manuel";
            this.rbtnManuel.UseVisualStyleBackColor = true;
            // 
            // rbtnOtomatik
            // 
            this.rbtnOtomatik.AutoSize = true;
            this.rbtnOtomatik.Location = new System.Drawing.Point(6, 22);
            this.rbtnOtomatik.Name = "rbtnOtomatik";
            this.rbtnOtomatik.Size = new System.Drawing.Size(75, 19);
            this.rbtnOtomatik.TabIndex = 1;
            this.rbtnOtomatik.TabStop = true;
            this.rbtnOtomatik.Text = "Otomatik";
            this.rbtnOtomatik.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 219);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(110, 49);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(166, 219);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(110, 49);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(105, 6);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(142, 23);
            this.txtMarka.TabIndex = 10;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(105, 46);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(142, 23);
            this.txtModel.TabIndex = 11;
            // 
            // txtModelYili
            // 
            this.txtModelYili.Location = new System.Drawing.Point(105, 86);
            this.txtModelYili.Name = "txtModelYili";
            this.txtModelYili.Size = new System.Drawing.Size(142, 23);
            this.txtModelYili.TabIndex = 12;
            // 
            // txtSase
            // 
            this.txtSase.Location = new System.Drawing.Point(105, 126);
            this.txtSase.Name = "txtSase";
            this.txtSase.Size = new System.Drawing.Size(142, 23);
            this.txtSase.TabIndex = 13;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(303, 245);
            this.txtAra.Name = "txtAra";
            this.txtAra.PlaceholderText = "Ara";
            this.txtAra.Size = new System.Drawing.Size(264, 23);
            this.txtAra.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Motor Hacmi :";
            // 
            // txtMotorHacmi
            // 
            this.txtMotorHacmi.Location = new System.Drawing.Point(105, 166);
            this.txtMotorHacmi.Name = "txtMotorHacmi";
            this.txtMotorHacmi.Size = new System.Drawing.Size(142, 23);
            this.txtMotorHacmi.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 512);
            this.Controls.Add(this.txtMotorHacmi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.txtSase);
            this.Controls.Add(this.txtModelYili);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.gbVites);
            this.Controls.Add(this.gbYakit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAraclar);
            this.Controls.Add(this.pbAvatar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.cmsSil.ResumeLayout(false);
            this.gbYakit.ResumeLayout(false);
            this.gbYakit.PerformLayout();
            this.gbVites.ResumeLayout(false);
            this.gbVites.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbAvatar;
        private ListBox lstAraclar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox gbYakit;
        private RadioButton rbtnElektrik;
        private RadioButton rbtnLpg;
        private RadioButton rbtnDizel;
        private RadioButton rbtnBenzin;
        private GroupBox gbVites;
        private RadioButton rbtnYariOtomatik;
        private RadioButton rbtnManuel;
        private RadioButton rbtnOtomatik;
        private Button btnKaydet;
        private Button btnGuncelle;
        private TextBox txtMarka;
        private TextBox txtModel;
        private TextBox txtModelYili;
        private TextBox txtSase;
        private TextBox txtAra;
        private ContextMenuStrip cmsSil;
        private ToolStripMenuItem silToolStripMenuItem;
        private Label label5;
        private TextBox txtMotorHacmi;
    }
}