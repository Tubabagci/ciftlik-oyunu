namespace proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblKumes = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTavukCanlilik = new System.Windows.Forms.Label();
            this.btnOrdekYemVer = new System.Windows.Forms.Button();
            this.btnTavukYemVer = new System.Windows.Forms.Button();
            this.pbOrdek = new System.Windows.Forms.ProgressBar();
            this.pbTavuk = new System.Windows.Forms.ProgressBar();
            this.lblOrdekCanlilik = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblKeciSutKg = new System.Windows.Forms.Label();
            this.lblInekSutKg = new System.Windows.Forms.Label();
            this.lblTavukYumurtaSayi = new System.Windows.Forms.Label();
            this.lblOrdekYumurtaSayi = new System.Windows.Forms.Label();
            this.lblInekSut = new System.Windows.Forms.Label();
            this.lblOrdekYumurta = new System.Windows.Forms.Label();
            this.lblKeciSutu = new System.Windows.Forms.Label();
            this.lblTavukYumurta = new System.Windows.Forms.Label();
            this.lblUrunDeposu = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblKasaMiktar = new System.Windows.Forms.Label();
            this.lblKasa = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSureMiktar = new System.Windows.Forms.Label();
            this.lblGecenSure = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKeciSutSat = new System.Windows.Forms.Button();
            this.btnİnekSutSat = new System.Windows.Forms.Button();
            this.btnOrdekYumurtaSat = new System.Windows.Forms.Button();
            this.btnTavukYumurtaSat = new System.Windows.Forms.Button();
            this.lblGidaFabrikasi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnKeciYemVer = new System.Windows.Forms.Button();
            this.btnInekYemVer = new System.Windows.Forms.Button();
            this.pbInek = new System.Windows.Forms.ProgressBar();
            this.pbKeci = new System.Windows.Forms.ProgressBar();
            this.lblKeciCanlilik = new System.Windows.Forms.Label();
            this.lblInekCanlilik = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAhir = new System.Windows.Forms.Label();
            this.sure = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::proje.Properties.Resources.inek;
            this.pictureBox2.Location = new System.Drawing.Point(21, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblKumes
            // 
            this.lblKumes.BackColor = System.Drawing.Color.Orange;
            this.lblKumes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKumes.ForeColor = System.Drawing.Color.White;
            this.lblKumes.Location = new System.Drawing.Point(17, 8);
            this.lblKumes.Name = "lblKumes";
            this.lblKumes.Size = new System.Drawing.Size(396, 20);
            this.lblKumes.TabIndex = 4;
            this.lblKumes.Text = "KÜMES";
            this.lblKumes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.lblTavukCanlilik);
            this.panel4.Controls.Add(this.btnOrdekYemVer);
            this.panel4.Controls.Add(this.btnTavukYemVer);
            this.panel4.Controls.Add(this.pbOrdek);
            this.panel4.Controls.Add(this.pbTavuk);
            this.panel4.Controls.Add(this.lblOrdekCanlilik);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.lblKumes);
            this.panel4.Location = new System.Drawing.Point(7, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(428, 284);
            this.panel4.TabIndex = 26;
            // 
            // lblTavukCanlilik
            // 
            this.lblTavukCanlilik.BackColor = System.Drawing.Color.Silver;
            this.lblTavukCanlilik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTavukCanlilik.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTavukCanlilik.Location = new System.Drawing.Point(162, 42);
            this.lblTavukCanlilik.Name = "lblTavukCanlilik";
            this.lblTavukCanlilik.Size = new System.Drawing.Size(246, 22);
            this.lblTavukCanlilik.TabIndex = 25;
            this.lblTavukCanlilik.Text = "CANLI";
            this.lblTavukCanlilik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOrdekYemVer
            // 
            this.btnOrdekYemVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOrdekYemVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrdekYemVer.ForeColor = System.Drawing.Color.Red;
            this.btnOrdekYemVer.Location = new System.Drawing.Point(159, 223);
            this.btnOrdekYemVer.Name = "btnOrdekYemVer";
            this.btnOrdekYemVer.Size = new System.Drawing.Size(249, 33);
            this.btnOrdekYemVer.TabIndex = 24;
            this.btnOrdekYemVer.Text = "YEM VER";
            this.btnOrdekYemVer.UseVisualStyleBackColor = false;
            this.btnOrdekYemVer.Click += new System.EventHandler(this.BtnOrdekYemVer_Click);
            // 
            // btnTavukYemVer
            // 
            this.btnTavukYemVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTavukYemVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTavukYemVer.ForeColor = System.Drawing.Color.Red;
            this.btnTavukYemVer.Location = new System.Drawing.Point(157, 106);
            this.btnTavukYemVer.Name = "btnTavukYemVer";
            this.btnTavukYemVer.Size = new System.Drawing.Size(249, 33);
            this.btnTavukYemVer.TabIndex = 21;
            this.btnTavukYemVer.Text = "YEM VER";
            this.btnTavukYemVer.UseVisualStyleBackColor = false;
            this.btnTavukYemVer.Click += new System.EventHandler(this.BtnTavukYemVer_Click);
            // 
            // pbOrdek
            // 
            this.pbOrdek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbOrdek.Location = new System.Drawing.Point(160, 184);
            this.pbOrdek.Name = "pbOrdek";
            this.pbOrdek.Size = new System.Drawing.Size(246, 33);
            this.pbOrdek.TabIndex = 20;
            this.pbOrdek.Value = 100;
            // 
            // pbTavuk
            // 
            this.pbTavuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbTavuk.Location = new System.Drawing.Point(160, 69);
            this.pbTavuk.Name = "pbTavuk";
            this.pbTavuk.Size = new System.Drawing.Size(246, 33);
            this.pbTavuk.TabIndex = 18;
            this.pbTavuk.Value = 100;
            // 
            // lblOrdekCanlilik
            // 
            this.lblOrdekCanlilik.BackColor = System.Drawing.Color.Silver;
            this.lblOrdekCanlilik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrdekCanlilik.ForeColor = System.Drawing.Color.DarkRed;
            this.lblOrdekCanlilik.Location = new System.Drawing.Point(160, 157);
            this.lblOrdekCanlilik.Name = "lblOrdekCanlilik";
            this.lblOrdekCanlilik.Size = new System.Drawing.Size(246, 22);
            this.lblOrdekCanlilik.TabIndex = 17;
            this.lblOrdekCanlilik.Text = "CANLI";
            this.lblOrdekCanlilik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::proje.Properties.Resources.ordek;
            this.pictureBox3.Location = new System.Drawing.Point(21, 157);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(118, 109);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::proje.Properties.Resources.tavuk;
            this.pictureBox4.Location = new System.Drawing.Point(21, 42);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(118, 109);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Teal;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(885, 258);
            this.panel7.TabIndex = 26;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel8.Controls.Add(this.lblKeciSutKg);
            this.panel8.Controls.Add(this.lblInekSutKg);
            this.panel8.Controls.Add(this.lblTavukYumurtaSayi);
            this.panel8.Controls.Add(this.lblOrdekYumurtaSayi);
            this.panel8.Controls.Add(this.lblInekSut);
            this.panel8.Controls.Add(this.lblOrdekYumurta);
            this.panel8.Controls.Add(this.lblKeciSutu);
            this.panel8.Controls.Add(this.lblTavukYumurta);
            this.panel8.Controls.Add(this.lblUrunDeposu);
            this.panel8.Location = new System.Drawing.Point(7, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(408, 243);
            this.panel8.TabIndex = 30;
            // 
            // lblKeciSutKg
            // 
            this.lblKeciSutKg.BackColor = System.Drawing.Color.LightBlue;
            this.lblKeciSutKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKeciSutKg.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblKeciSutKg.Location = new System.Drawing.Point(206, 168);
            this.lblKeciSutKg.Name = "lblKeciSutKg";
            this.lblKeciSutKg.Size = new System.Drawing.Size(176, 56);
            this.lblKeciSutKg.TabIndex = 15;
            this.lblKeciSutKg.Text = "0 KG";
            this.lblKeciSutKg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInekSutKg
            // 
            this.lblInekSutKg.BackColor = System.Drawing.Color.LightBlue;
            this.lblInekSutKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInekSutKg.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblInekSutKg.Location = new System.Drawing.Point(206, 68);
            this.lblInekSutKg.Name = "lblInekSutKg";
            this.lblInekSutKg.Size = new System.Drawing.Size(176, 56);
            this.lblInekSutKg.TabIndex = 14;
            this.lblInekSutKg.Text = "0 KG";
            this.lblInekSutKg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTavukYumurtaSayi
            // 
            this.lblTavukYumurtaSayi.BackColor = System.Drawing.Color.LightBlue;
            this.lblTavukYumurtaSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTavukYumurtaSayi.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTavukYumurtaSayi.Location = new System.Drawing.Point(19, 68);
            this.lblTavukYumurtaSayi.Name = "lblTavukYumurtaSayi";
            this.lblTavukYumurtaSayi.Size = new System.Drawing.Size(176, 56);
            this.lblTavukYumurtaSayi.TabIndex = 13;
            this.lblTavukYumurtaSayi.Text = "0 ADET";
            this.lblTavukYumurtaSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrdekYumurtaSayi
            // 
            this.lblOrdekYumurtaSayi.BackColor = System.Drawing.Color.LightBlue;
            this.lblOrdekYumurtaSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrdekYumurtaSayi.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblOrdekYumurtaSayi.Location = new System.Drawing.Point(17, 168);
            this.lblOrdekYumurtaSayi.Name = "lblOrdekYumurtaSayi";
            this.lblOrdekYumurtaSayi.Size = new System.Drawing.Size(176, 56);
            this.lblOrdekYumurtaSayi.TabIndex = 12;
            this.lblOrdekYumurtaSayi.Text = "0 ADET";
            this.lblOrdekYumurtaSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInekSut
            // 
            this.lblInekSut.BackColor = System.Drawing.Color.Silver;
            this.lblInekSut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInekSut.ForeColor = System.Drawing.Color.Black;
            this.lblInekSut.Location = new System.Drawing.Point(206, 41);
            this.lblInekSut.Name = "lblInekSut";
            this.lblInekSut.Size = new System.Drawing.Size(176, 20);
            this.lblInekSut.TabIndex = 11;
            this.lblInekSut.Text = "İNEK SÜTÜ";
            this.lblInekSut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrdekYumurta
            // 
            this.lblOrdekYumurta.BackColor = System.Drawing.Color.Silver;
            this.lblOrdekYumurta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrdekYumurta.ForeColor = System.Drawing.Color.Black;
            this.lblOrdekYumurta.Location = new System.Drawing.Point(11, 140);
            this.lblOrdekYumurta.Name = "lblOrdekYumurta";
            this.lblOrdekYumurta.Size = new System.Drawing.Size(187, 20);
            this.lblOrdekYumurta.TabIndex = 10;
            this.lblOrdekYumurta.Text = "ÖRDEK YUMURTASI";
            this.lblOrdekYumurta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKeciSutu
            // 
            this.lblKeciSutu.BackColor = System.Drawing.Color.Silver;
            this.lblKeciSutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKeciSutu.ForeColor = System.Drawing.Color.Black;
            this.lblKeciSutu.Location = new System.Drawing.Point(206, 140);
            this.lblKeciSutu.Name = "lblKeciSutu";
            this.lblKeciSutu.Size = new System.Drawing.Size(176, 20);
            this.lblKeciSutu.TabIndex = 9;
            this.lblKeciSutu.Text = "KEÇİ SÜTÜ";
            this.lblKeciSutu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTavukYumurta
            // 
            this.lblTavukYumurta.BackColor = System.Drawing.Color.Silver;
            this.lblTavukYumurta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTavukYumurta.ForeColor = System.Drawing.Color.Black;
            this.lblTavukYumurta.Location = new System.Drawing.Point(11, 41);
            this.lblTavukYumurta.Name = "lblTavukYumurta";
            this.lblTavukYumurta.Size = new System.Drawing.Size(187, 20);
            this.lblTavukYumurta.TabIndex = 8;
            this.lblTavukYumurta.Text = "TAVUK YUMURTASI";
            this.lblTavukYumurta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUrunDeposu
            // 
            this.lblUrunDeposu.BackColor = System.Drawing.Color.Orange;
            this.lblUrunDeposu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunDeposu.ForeColor = System.Drawing.Color.White;
            this.lblUrunDeposu.Location = new System.Drawing.Point(13, 7);
            this.lblUrunDeposu.Name = "lblUrunDeposu";
            this.lblUrunDeposu.Size = new System.Drawing.Size(378, 20);
            this.lblUrunDeposu.TabIndex = 5;
            this.lblUrunDeposu.Text = "ÜRÜN DEPOSU";
            this.lblUrunDeposu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.lblKasaMiktar);
            this.panel5.Controls.Add(this.lblKasa);
            this.panel5.Location = new System.Drawing.Point(692, 131);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 118);
            this.panel5.TabIndex = 29;
            // 
            // lblKasaMiktar
            // 
            this.lblKasaMiktar.BackColor = System.Drawing.Color.LightBlue;
            this.lblKasaMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasaMiktar.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblKasaMiktar.Location = new System.Drawing.Point(8, 41);
            this.lblKasaMiktar.Name = "lblKasaMiktar";
            this.lblKasaMiktar.Size = new System.Drawing.Size(164, 61);
            this.lblKasaMiktar.TabIndex = 13;
            this.lblKasaMiktar.Text = "0 TL";
            this.lblKasaMiktar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKasa
            // 
            this.lblKasa.BackColor = System.Drawing.Color.Orange;
            this.lblKasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasa.ForeColor = System.Drawing.Color.White;
            this.lblKasa.Location = new System.Drawing.Point(10, 12);
            this.lblKasa.Name = "lblKasa";
            this.lblKasa.Size = new System.Drawing.Size(160, 20);
            this.lblKasa.TabIndex = 5;
            this.lblKasa.Text = "KASA";
            this.lblKasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.lblSureMiktar);
            this.panel3.Controls.Add(this.lblGecenSure);
            this.panel3.Location = new System.Drawing.Point(692, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 119);
            this.panel3.TabIndex = 29;
            // 
            // lblSureMiktar
            // 
            this.lblSureMiktar.BackColor = System.Drawing.Color.LightBlue;
            this.lblSureMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSureMiktar.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblSureMiktar.Location = new System.Drawing.Point(8, 38);
            this.lblSureMiktar.Name = "lblSureMiktar";
            this.lblSureMiktar.Size = new System.Drawing.Size(164, 61);
            this.lblSureMiktar.TabIndex = 14;
            this.lblSureMiktar.Text = "0 SN";
            this.lblSureMiktar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGecenSure
            // 
            this.lblGecenSure.BackColor = System.Drawing.Color.Orange;
            this.lblGecenSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGecenSure.ForeColor = System.Drawing.Color.White;
            this.lblGecenSure.Location = new System.Drawing.Point(10, 10);
            this.lblGecenSure.Name = "lblGecenSure";
            this.lblGecenSure.Size = new System.Drawing.Size(160, 20);
            this.lblGecenSure.TabIndex = 5;
            this.lblGecenSure.Text = "GEÇEN SÜRE";
            this.lblGecenSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnKeciSutSat);
            this.panel2.Controls.Add(this.btnİnekSutSat);
            this.panel2.Controls.Add(this.btnOrdekYumurtaSat);
            this.panel2.Controls.Add(this.btnTavukYumurtaSat);
            this.panel2.Controls.Add(this.lblGidaFabrikasi);
            this.panel2.Location = new System.Drawing.Point(421, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 243);
            this.panel2.TabIndex = 28;
            // 
            // btnKeciSutSat
            // 
            this.btnKeciSutSat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKeciSutSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKeciSutSat.ForeColor = System.Drawing.Color.Red;
            this.btnKeciSutSat.Location = new System.Drawing.Point(9, 185);
            this.btnKeciSutSat.Name = "btnKeciSutSat";
            this.btnKeciSutSat.Size = new System.Drawing.Size(249, 43);
            this.btnKeciSutSat.TabIndex = 11;
            this.btnKeciSutSat.Text = "KEÇİ SÜTÜ SAT";
            this.btnKeciSutSat.UseVisualStyleBackColor = false;
            this.btnKeciSutSat.Click += new System.EventHandler(this.BtnKeciSutSat_Click);
            // 
            // btnİnekSutSat
            // 
            this.btnİnekSutSat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnİnekSutSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİnekSutSat.ForeColor = System.Drawing.Color.Red;
            this.btnİnekSutSat.Location = new System.Drawing.Point(9, 136);
            this.btnİnekSutSat.Name = "btnİnekSutSat";
            this.btnİnekSutSat.Size = new System.Drawing.Size(249, 43);
            this.btnİnekSutSat.TabIndex = 10;
            this.btnİnekSutSat.Text = "İNEK SÜTÜ SAT";
            this.btnİnekSutSat.UseVisualStyleBackColor = false;
            this.btnİnekSutSat.Click += new System.EventHandler(this.BtnİnekSutSat_Click);
            // 
            // btnOrdekYumurtaSat
            // 
            this.btnOrdekYumurtaSat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOrdekYumurtaSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrdekYumurtaSat.ForeColor = System.Drawing.Color.Red;
            this.btnOrdekYumurtaSat.Location = new System.Drawing.Point(9, 87);
            this.btnOrdekYumurtaSat.Name = "btnOrdekYumurtaSat";
            this.btnOrdekYumurtaSat.Size = new System.Drawing.Size(249, 43);
            this.btnOrdekYumurtaSat.TabIndex = 8;
            this.btnOrdekYumurtaSat.Text = "ÖRDEK YUMURTASI SAT";
            this.btnOrdekYumurtaSat.UseVisualStyleBackColor = false;
            this.btnOrdekYumurtaSat.Click += new System.EventHandler(this.BtnOrdekYumurtaSat_Click);
            // 
            // btnTavukYumurtaSat
            // 
            this.btnTavukYumurtaSat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTavukYumurtaSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTavukYumurtaSat.ForeColor = System.Drawing.Color.Red;
            this.btnTavukYumurtaSat.Location = new System.Drawing.Point(9, 38);
            this.btnTavukYumurtaSat.Name = "btnTavukYumurtaSat";
            this.btnTavukYumurtaSat.Size = new System.Drawing.Size(249, 43);
            this.btnTavukYumurtaSat.TabIndex = 7;
            this.btnTavukYumurtaSat.Text = "TAVUK YUMURTASI SAT";
            this.btnTavukYumurtaSat.UseVisualStyleBackColor = false;
            this.btnTavukYumurtaSat.Click += new System.EventHandler(this.BtnTavukYumurtaSat_Click);
            // 
            // lblGidaFabrikasi
            // 
            this.lblGidaFabrikasi.BackColor = System.Drawing.Color.Orange;
            this.lblGidaFabrikasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGidaFabrikasi.ForeColor = System.Drawing.Color.White;
            this.lblGidaFabrikasi.Location = new System.Drawing.Point(16, 7);
            this.lblGidaFabrikasi.Name = "lblGidaFabrikasi";
            this.lblGidaFabrikasi.Size = new System.Drawing.Size(232, 20);
            this.lblGidaFabrikasi.TabIndex = 5;
            this.lblGidaFabrikasi.Text = "GIDA FABRİKASI";
            this.lblGidaFabrikasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(0, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 305);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.btnKeciYemVer);
            this.panel6.Controls.Add(this.btnInekYemVer);
            this.panel6.Controls.Add(this.pbInek);
            this.panel6.Controls.Add(this.pbKeci);
            this.panel6.Controls.Add(this.lblKeciCanlilik);
            this.panel6.Controls.Add(this.lblInekCanlilik);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.lblAhir);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Location = new System.Drawing.Point(445, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(428, 284);
            this.panel6.TabIndex = 27;
            // 
            // btnKeciYemVer
            // 
            this.btnKeciYemVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKeciYemVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKeciYemVer.ForeColor = System.Drawing.Color.Red;
            this.btnKeciYemVer.Location = new System.Drawing.Point(153, 222);
            this.btnKeciYemVer.Name = "btnKeciYemVer";
            this.btnKeciYemVer.Size = new System.Drawing.Size(249, 33);
            this.btnKeciYemVer.TabIndex = 23;
            this.btnKeciYemVer.Text = "YEM VER";
            this.btnKeciYemVer.UseVisualStyleBackColor = false;
            this.btnKeciYemVer.Click += new System.EventHandler(this.BtnKeciYemVer_Click);
            // 
            // btnInekYemVer
            // 
            this.btnInekYemVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInekYemVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInekYemVer.ForeColor = System.Drawing.Color.Red;
            this.btnInekYemVer.Location = new System.Drawing.Point(153, 107);
            this.btnInekYemVer.Name = "btnInekYemVer";
            this.btnInekYemVer.Size = new System.Drawing.Size(249, 33);
            this.btnInekYemVer.TabIndex = 22;
            this.btnInekYemVer.Text = "YEM VER";
            this.btnInekYemVer.UseVisualStyleBackColor = false;
            this.btnInekYemVer.Click += new System.EventHandler(this.BtnInekYemVer_Click);
            // 
            // pbInek
            // 
            this.pbInek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbInek.Location = new System.Drawing.Point(156, 68);
            this.pbInek.Name = "pbInek";
            this.pbInek.Size = new System.Drawing.Size(246, 33);
            this.pbInek.TabIndex = 21;
            this.pbInek.Value = 100;
            // 
            // pbKeci
            // 
            this.pbKeci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbKeci.Location = new System.Drawing.Point(156, 183);
            this.pbKeci.Name = "pbKeci";
            this.pbKeci.Size = new System.Drawing.Size(246, 33);
            this.pbKeci.TabIndex = 19;
            this.pbKeci.Value = 100;
            // 
            // lblKeciCanlilik
            // 
            this.lblKeciCanlilik.BackColor = System.Drawing.Color.Silver;
            this.lblKeciCanlilik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKeciCanlilik.ForeColor = System.Drawing.Color.DarkRed;
            this.lblKeciCanlilik.Location = new System.Drawing.Point(156, 156);
            this.lblKeciCanlilik.Name = "lblKeciCanlilik";
            this.lblKeciCanlilik.Size = new System.Drawing.Size(246, 22);
            this.lblKeciCanlilik.TabIndex = 18;
            this.lblKeciCanlilik.Text = "CANLI";
            this.lblKeciCanlilik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInekCanlilik
            // 
            this.lblInekCanlilik.BackColor = System.Drawing.Color.Silver;
            this.lblInekCanlilik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInekCanlilik.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInekCanlilik.Location = new System.Drawing.Point(156, 41);
            this.lblInekCanlilik.Name = "lblInekCanlilik";
            this.lblInekCanlilik.Size = new System.Drawing.Size(246, 22);
            this.lblInekCanlilik.TabIndex = 19;
            this.lblInekCanlilik.Text = "CANLI";
            this.lblInekCanlilik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proje.Properties.Resources.keci;
            this.pictureBox1.Location = new System.Drawing.Point(21, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblAhir
            // 
            this.lblAhir.BackColor = System.Drawing.Color.Orange;
            this.lblAhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAhir.ForeColor = System.Drawing.Color.White;
            this.lblAhir.Location = new System.Drawing.Point(17, 7);
            this.lblAhir.Name = "lblAhir";
            this.lblAhir.Size = new System.Drawing.Size(396, 20);
            this.lblAhir.TabIndex = 5;
            this.lblAhir.Text = "AHIR";
            this.lblAhir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sure
            // 
            this.sure.Enabled = true;
            this.sure.Interval = 1000;
            this.sure.Tick += new System.EventHandler(this.Sure_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblKumes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTavukYumurta;
        private System.Windows.Forms.Label lblAhir;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblUrunDeposu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblKasa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblGecenSure;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGidaFabrikasi;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblKeciSutKg;
        private System.Windows.Forms.Label lblInekSutKg;
        private System.Windows.Forms.Label lblTavukYumurtaSayi;
        private System.Windows.Forms.Label lblOrdekYumurtaSayi;
        private System.Windows.Forms.Label lblInekSut;
        private System.Windows.Forms.Label lblOrdekYumurta;
        private System.Windows.Forms.Label lblKeciSutu;
        private System.Windows.Forms.Label lblKasaMiktar;
        private System.Windows.Forms.Label lblSureMiktar;
        private System.Windows.Forms.Button btnİnekSutSat;
        private System.Windows.Forms.Button btnOrdekYumurtaSat;
        private System.Windows.Forms.Button btnTavukYumurtaSat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKeciSutSat;
        private System.Windows.Forms.Button btnOrdekYemVer;
        private System.Windows.Forms.Button btnTavukYemVer;
        private System.Windows.Forms.ProgressBar pbOrdek;
        private System.Windows.Forms.ProgressBar pbTavuk;
        private System.Windows.Forms.Label lblOrdekCanlilik;
        private System.Windows.Forms.Button btnKeciYemVer;
        private System.Windows.Forms.Button btnInekYemVer;
        private System.Windows.Forms.ProgressBar pbInek;
        private System.Windows.Forms.ProgressBar pbKeci;
        private System.Windows.Forms.Label lblKeciCanlilik;
        private System.Windows.Forms.Label lblInekCanlilik;
        private System.Windows.Forms.Timer sure;
        private System.Windows.Forms.Label lblTavukCanlilik;
    }
}

