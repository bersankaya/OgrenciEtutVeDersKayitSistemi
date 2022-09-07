
namespace OgrenciEtutVeDersKayıtSistemi
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnEtutOlustur = new System.Windows.Forms.Button();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.CmbOgretmen = new System.Windows.Forms.ComboBox();
            this.CmbDers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEtutId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtOgrenci = new System.Windows.Forms.TextBox();
            this.BtnEtutDetay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnDersEkle = new System.Windows.Forms.Button();
            this.TxtDersAd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.BtnOgrenciEkle = new System.Windows.Forms.Button();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtSinif = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BtnOgretmenEkle = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtOgrtSoyad = new System.Windows.Forms.TextBox();
            this.TxtOgrtAd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.txtbrans = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEtutOlustur);
            this.groupBox1.Controls.Add(this.MskSaat);
            this.groupBox1.Controls.Add(this.MskTarih);
            this.groupBox1.Controls.Add(this.CmbOgretmen);
            this.groupBox1.Controls.Add(this.CmbDers);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnEtutOlustur
            // 
            this.BtnEtutOlustur.ForeColor = System.Drawing.Color.Black;
            this.BtnEtutOlustur.Location = new System.Drawing.Point(136, 246);
            this.BtnEtutOlustur.Name = "BtnEtutOlustur";
            this.BtnEtutOlustur.Size = new System.Drawing.Size(213, 39);
            this.BtnEtutOlustur.TabIndex = 8;
            this.BtnEtutOlustur.Text = "Etüt Oluştur";
            this.BtnEtutOlustur.UseVisualStyleBackColor = true;
            this.BtnEtutOlustur.Click += new System.EventHandler(this.BtnEtutOlustur_Click);
            // 
            // MskSaat
            // 
            this.MskSaat.Location = new System.Drawing.Point(136, 206);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(213, 34);
            this.MskSaat.TabIndex = 7;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(136, 164);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(213, 34);
            this.MskTarih.TabIndex = 6;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // CmbOgretmen
            // 
            this.CmbOgretmen.FormattingEnabled = true;
            this.CmbOgretmen.Location = new System.Drawing.Point(136, 90);
            this.CmbOgretmen.Name = "CmbOgretmen";
            this.CmbOgretmen.Size = new System.Drawing.Size(214, 35);
            this.CmbOgretmen.TabIndex = 5;
            // 
            // CmbDers
            // 
            this.CmbDers.FormattingEnabled = true;
            this.CmbDers.Location = new System.Drawing.Point(136, 49);
            this.CmbDers.Name = "CmbDers";
            this.CmbDers.Size = new System.Drawing.Size(214, 35);
            this.CmbDers.TabIndex = 4;
            this.CmbDers.SelectedIndexChanged += new System.EventHandler(this.CmbDers_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğretmen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEtutId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtOgrenci);
            this.groupBox2.Controls.Add(this.BtnEtutDetay);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(464, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtEtutId
            // 
            this.txtEtutId.Enabled = false;
            this.txtEtutId.Location = new System.Drawing.Point(150, 33);
            this.txtEtutId.Name = "txtEtutId";
            this.txtEtutId.Size = new System.Drawing.Size(169, 34);
            this.txtEtutId.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(64, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Etüt Id:";
            // 
            // TxtOgrenci
            // 
            this.TxtOgrenci.Location = new System.Drawing.Point(150, 77);
            this.TxtOgrenci.Name = "TxtOgrenci";
            this.TxtOgrenci.Size = new System.Drawing.Size(169, 34);
            this.TxtOgrenci.TabIndex = 10;
            // 
            // BtnEtutDetay
            // 
            this.BtnEtutDetay.BackColor = System.Drawing.Color.Black;
            this.BtnEtutDetay.ForeColor = System.Drawing.Color.White;
            this.BtnEtutDetay.Location = new System.Drawing.Point(150, 117);
            this.BtnEtutDetay.Name = "BtnEtutDetay";
            this.BtnEtutDetay.Size = new System.Drawing.Size(169, 39);
            this.BtnEtutDetay.TabIndex = 9;
            this.BtnEtutDetay.Text = "Etüt Ver";
            this.BtnEtutDetay.UseVisualStyleBackColor = false;
            this.BtnEtutDetay.Click += new System.EventHandler(this.BtnEtutDetay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(51, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "Öğrenci:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1222, 344);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1216, 311);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnDersEkle);
            this.groupBox4.Controls.Add(this.TxtDersAd);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(467, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(429, 128);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // BtnDersEkle
            // 
            this.BtnDersEkle.BackColor = System.Drawing.Color.Black;
            this.BtnDersEkle.ForeColor = System.Drawing.Color.White;
            this.BtnDersEkle.Location = new System.Drawing.Point(298, 58);
            this.BtnDersEkle.Name = "BtnDersEkle";
            this.BtnDersEkle.Size = new System.Drawing.Size(125, 39);
            this.BtnDersEkle.TabIndex = 13;
            this.BtnDersEkle.Text = "Ders Ekle";
            this.BtnDersEkle.UseVisualStyleBackColor = false;
            this.BtnDersEkle.Click += new System.EventHandler(this.BtnDersEkle_Click);
            // 
            // TxtDersAd
            // 
            this.TxtDersAd.Location = new System.Drawing.Point(114, 63);
            this.TxtDersAd.Name = "TxtDersAd";
            this.TxtDersAd.Size = new System.Drawing.Size(178, 34);
            this.TxtDersAd.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(13, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 27);
            this.label12.TabIndex = 23;
            this.label12.Text = "Ders Adı:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.MskTelefon);
            this.groupBox5.Controls.Add(this.BtnOgrenciEkle);
            this.groupBox5.Controls.Add(this.TxtMail);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.TxtSinif);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.TxtSoyad);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.TxtAd);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(902, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(332, 292);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(102, 165);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(178, 34);
            this.MskTelefon.TabIndex = 9;
            // 
            // BtnOgrenciEkle
            // 
            this.BtnOgrenciEkle.BackColor = System.Drawing.Color.Black;
            this.BtnOgrenciEkle.ForeColor = System.Drawing.Color.White;
            this.BtnOgrenciEkle.Location = new System.Drawing.Point(102, 253);
            this.BtnOgrenciEkle.Name = "BtnOgrenciEkle";
            this.BtnOgrenciEkle.Size = new System.Drawing.Size(178, 39);
            this.BtnOgrenciEkle.TabIndex = 13;
            this.BtnOgrenciEkle.Text = "Öğrenci Ekle";
            this.BtnOgrenciEkle.UseVisualStyleBackColor = false;
            this.BtnOgrenciEkle.Click += new System.EventHandler(this.BtnOgrenciEkle_Click);
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(102, 213);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(178, 34);
            this.TxtMail.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(38, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 27);
            this.label11.TabIndex = 21;
            this.label11.Text = "Mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(9, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 27);
            this.label10.TabIndex = 19;
            this.label10.Text = "Telefon:";
            // 
            // TxtSinif
            // 
            this.TxtSinif.Location = new System.Drawing.Point(102, 122);
            this.TxtSinif.Name = "TxtSinif";
            this.TxtSinif.Size = new System.Drawing.Size(178, 34);
            this.TxtSinif.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(38, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 27);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sınıf:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(102, 77);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(178, 34);
            this.TxtSoyad.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "Soyad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(102, 33);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(178, 34);
            this.TxtAd.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(52, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ad:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Location = new System.Drawing.Point(1240, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(332, 292);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(82, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 39);
            this.button1.TabIndex = 22;
            this.button1.Text = "Fotoğraf Yükle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtbrans);
            this.groupBox7.Controls.Add(this.BtnOgretmenEkle);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.TxtOgrtSoyad);
            this.groupBox7.Controls.Add(this.TxtOgrtAd);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(1237, 356);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(332, 332);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            // 
            // BtnOgretmenEkle
            // 
            this.BtnOgretmenEkle.BackColor = System.Drawing.Color.Black;
            this.BtnOgretmenEkle.ForeColor = System.Drawing.Color.White;
            this.BtnOgretmenEkle.Location = new System.Drawing.Point(106, 233);
            this.BtnOgretmenEkle.Name = "BtnOgretmenEkle";
            this.BtnOgretmenEkle.Size = new System.Drawing.Size(178, 39);
            this.BtnOgretmenEkle.TabIndex = 22;
            this.BtnOgretmenEkle.Text = "Öğretmen Ekle";
            this.BtnOgretmenEkle.UseVisualStyleBackColor = false;
            this.BtnOgretmenEkle.Click += new System.EventHandler(this.BtnOgretmenEkle_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(40, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 27);
            this.label15.TabIndex = 26;
            this.label15.Text = "Ders:";
            // 
            // TxtOgrtSoyad
            // 
            this.TxtOgrtSoyad.Location = new System.Drawing.Point(106, 127);
            this.TxtOgrtSoyad.Name = "TxtOgrtSoyad";
            this.TxtOgrtSoyad.Size = new System.Drawing.Size(178, 34);
            this.TxtOgrtSoyad.TabIndex = 24;
            // 
            // TxtOgrtAd
            // 
            this.TxtOgrtAd.Location = new System.Drawing.Point(106, 83);
            this.TxtOgrtAd.Name = "TxtOgrtAd";
            this.TxtOgrtAd.Size = new System.Drawing.Size(178, 34);
            this.TxtOgrtAd.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(23, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 27);
            this.label13.TabIndex = 25;
            this.label13.Text = "Soyad:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(56, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 27);
            this.label14.TabIndex = 23;
            this.label14.Text = "Ad:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(12, 310);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(142, 31);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Etüt Durum";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(467, 310);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(155, 31);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Öğrenci Bilgi";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(902, 310);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(138, 31);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ders Listesi";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // txtbrans
            // 
            this.txtbrans.Location = new System.Drawing.Point(106, 172);
            this.txtbrans.Name = "txtbrans";
            this.txtbrans.Size = new System.Drawing.Size(178, 34);
            this.txtbrans.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1593, 703);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "BK SOFT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnEtutOlustur;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.ComboBox CmbOgretmen;
        private System.Windows.Forms.ComboBox CmbDers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnEtutDetay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEtutId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtOgrenci;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button BtnDersEkle;
        private System.Windows.Forms.TextBox TxtDersAd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Button BtnOgrenciEkle;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtSinif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnOgretmenEkle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtOgrtSoyad;
        private System.Windows.Forms.TextBox TxtOgrtAd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox txtbrans;
    }
}

