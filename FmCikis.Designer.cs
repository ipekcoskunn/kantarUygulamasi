namespace KantarUygulaması
{
    partial class FmCikis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmCikis));
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.btCikis = new System.Windows.Forms.Button();
            this.btAnasayfa = new System.Windows.Forms.Button();
            this.LbKullanici = new System.Windows.Forms.Label();
            this.LbSoyad = new System.Windows.Forms.Label();
            this.LbAd = new System.Windows.Forms.Label();
            this.BtnTart = new System.Windows.Forms.Button();
            this.LbSaat = new System.Windows.Forms.Label();
            this.LbTarih = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LbUrunAgirlik = new System.Windows.Forms.Label();
            this.LbCikisAgirlik = new System.Windows.Forms.Label();
            this.TbÜrün = new System.Windows.Forms.TextBox();
            this.TbCikis = new System.Windows.Forms.TextBox();
            this.BtnKayit = new System.Windows.Forms.Button();
            this.TbAgirlik = new System.Windows.Forms.TextBox();
            this.TbSofor = new System.Windows.Forms.TextBox();
            this.TbPlaka = new System.Windows.Forms.TextBox();
            this.LbGirisAgirlik = new System.Windows.Forms.Label();
            this.LbSofor = new System.Windows.Forms.Label();
            this.LbPlaka = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.DtVeriKaydi = new System.Windows.Forms.DataGridView();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soforadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisagirligiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giristarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikistarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urünmiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKantarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kantarDataSet4 = new KantarUygulaması.KantarDataSet4();
            this.tbl_KantarTableAdapter = new KantarUygulaması.KantarDataSet4TableAdapters.Tbl_KantarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtVeriKaydi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKantarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdmin.BackgroundImage")));
            this.BtnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdmin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAdmin.Location = new System.Drawing.Point(13, 473);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(60, 60);
            this.BtnAdmin.TabIndex = 58;
            this.BtnAdmin.UseVisualStyleBackColor = false;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // btCikis
            // 
            this.btCikis.BackColor = System.Drawing.Color.Transparent;
            this.btCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCikis.BackgroundImage")));
            this.btCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btCikis.Location = new System.Drawing.Point(13, 607);
            this.btCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btCikis.Name = "btCikis";
            this.btCikis.Size = new System.Drawing.Size(60, 60);
            this.btCikis.TabIndex = 57;
            this.btCikis.UseVisualStyleBackColor = false;
            this.btCikis.Click += new System.EventHandler(this.btCikis_Click);
            // 
            // btAnasayfa
            // 
            this.btAnasayfa.BackColor = System.Drawing.Color.Transparent;
            this.btAnasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAnasayfa.BackgroundImage")));
            this.btAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAnasayfa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btAnasayfa.Location = new System.Drawing.Point(13, 540);
            this.btAnasayfa.Margin = new System.Windows.Forms.Padding(4);
            this.btAnasayfa.Name = "btAnasayfa";
            this.btAnasayfa.Size = new System.Drawing.Size(60, 60);
            this.btAnasayfa.TabIndex = 56;
            this.btAnasayfa.UseVisualStyleBackColor = false;
            this.btAnasayfa.Click += new System.EventHandler(this.btAnasayfa_Click);
            // 
            // LbKullanici
            // 
            this.LbKullanici.AutoSize = true;
            this.LbKullanici.BackColor = System.Drawing.Color.Transparent;
            this.LbKullanici.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.LbKullanici.Location = new System.Drawing.Point(608, 50);
            this.LbKullanici.Name = "LbKullanici";
            this.LbKullanici.Size = new System.Drawing.Size(85, 21);
            this.LbKullanici.TabIndex = 67;
            this.LbKullanici.Text = "Kullanıcı: ";
            // 
            // LbSoyad
            // 
            this.LbSoyad.AutoSize = true;
            this.LbSoyad.BackColor = System.Drawing.Color.Transparent;
            this.LbSoyad.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.LbSoyad.Location = new System.Drawing.Point(752, 50);
            this.LbSoyad.Name = "LbSoyad";
            this.LbSoyad.Size = new System.Drawing.Size(57, 21);
            this.LbSoyad.TabIndex = 66;
            this.LbSoyad.Text = " Soyad";
            // 
            // LbAd
            // 
            this.LbAd.AutoSize = true;
            this.LbAd.BackColor = System.Drawing.Color.Transparent;
            this.LbAd.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.LbAd.Location = new System.Drawing.Point(689, 50);
            this.LbAd.Name = "LbAd";
            this.LbAd.Size = new System.Drawing.Size(31, 21);
            this.LbAd.TabIndex = 65;
            this.LbAd.Text = "Ad";
            // 
            // BtnTart
            // 
            this.BtnTart.BackColor = System.Drawing.Color.Maroon;
            this.BtnTart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnTart.Location = new System.Drawing.Point(86, 151);
            this.BtnTart.Name = "BtnTart";
            this.BtnTart.Size = new System.Drawing.Size(255, 57);
            this.BtnTart.TabIndex = 64;
            this.BtnTart.Text = "TART";
            this.BtnTart.UseVisualStyleBackColor = false;
            this.BtnTart.Click += new System.EventHandler(this.BtnTart_Click);
            // 
            // LbSaat
            // 
            this.LbSaat.AutoSize = true;
            this.LbSaat.BackColor = System.Drawing.Color.Transparent;
            this.LbSaat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbSaat.Location = new System.Drawing.Point(873, 52);
            this.LbSaat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbSaat.Name = "LbSaat";
            this.LbSaat.Size = new System.Drawing.Size(40, 19);
            this.LbSaat.TabIndex = 63;
            this.LbSaat.Text = "Saat";
            // 
            // LbTarih
            // 
            this.LbTarih.AutoSize = true;
            this.LbTarih.BackColor = System.Drawing.Color.Transparent;
            this.LbTarih.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbTarih.Location = new System.Drawing.Point(873, 33);
            this.LbTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTarih.Name = "LbTarih";
            this.LbTarih.Size = new System.Drawing.Size(48, 19);
            this.LbTarih.TabIndex = 62;
            this.LbTarih.Text = "Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(196, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 61;
            this.label1.Text = "Araç Çıkış";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(185, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 2);
            this.panel2.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 79);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // LbUrunAgirlik
            // 
            this.LbUrunAgirlik.AutoSize = true;
            this.LbUrunAgirlik.BackColor = System.Drawing.Color.Transparent;
            this.LbUrunAgirlik.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.LbUrunAgirlik.Location = new System.Drawing.Point(12, 403);
            this.LbUrunAgirlik.Name = "LbUrunAgirlik";
            this.LbUrunAgirlik.Size = new System.Drawing.Size(115, 21);
            this.LbUrunAgirlik.TabIndex = 78;
            this.LbUrunAgirlik.Text = "Ürün Ağırlığı :";
            // 
            // LbCikisAgirlik
            // 
            this.LbCikisAgirlik.AutoSize = true;
            this.LbCikisAgirlik.BackColor = System.Drawing.Color.Transparent;
            this.LbCikisAgirlik.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.LbCikisAgirlik.Location = new System.Drawing.Point(14, 363);
            this.LbCikisAgirlik.Name = "LbCikisAgirlik";
            this.LbCikisAgirlik.Size = new System.Drawing.Size(113, 21);
            this.LbCikisAgirlik.TabIndex = 77;
            this.LbCikisAgirlik.Text = "Çıkış Ağırlığı :";
            // 
            // TbÜrün
            // 
            this.TbÜrün.Location = new System.Drawing.Point(137, 402);
            this.TbÜrün.Margin = new System.Windows.Forms.Padding(4);
            this.TbÜrün.Multiline = true;
            this.TbÜrün.Name = "TbÜrün";
            this.TbÜrün.Size = new System.Drawing.Size(203, 25);
            this.TbÜrün.TabIndex = 76;
            // 
            // TbCikis
            // 
            this.TbCikis.Enabled = false;
            this.TbCikis.Location = new System.Drawing.Point(137, 362);
            this.TbCikis.Margin = new System.Windows.Forms.Padding(4);
            this.TbCikis.Multiline = true;
            this.TbCikis.Name = "TbCikis";
            this.TbCikis.Size = new System.Drawing.Size(203, 25);
            this.TbCikis.TabIndex = 75;
            // 
            // BtnKayit
            // 
            this.BtnKayit.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnKayit.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.BtnKayit.ForeColor = System.Drawing.Color.Maroon;
            this.BtnKayit.Location = new System.Drawing.Point(86, 446);
            this.BtnKayit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(254, 54);
            this.BtnKayit.TabIndex = 74;
            this.BtnKayit.Text = "Kayıt";
            this.BtnKayit.UseVisualStyleBackColor = false;
            this.BtnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // TbAgirlik
            // 
            this.TbAgirlik.Enabled = false;
            this.TbAgirlik.Location = new System.Drawing.Point(137, 320);
            this.TbAgirlik.Margin = new System.Windows.Forms.Padding(4);
            this.TbAgirlik.Multiline = true;
            this.TbAgirlik.Name = "TbAgirlik";
            this.TbAgirlik.Size = new System.Drawing.Size(203, 25);
            this.TbAgirlik.TabIndex = 73;
            // 
            // TbSofor
            // 
            this.TbSofor.Enabled = false;
            this.TbSofor.Location = new System.Drawing.Point(137, 277);
            this.TbSofor.Margin = new System.Windows.Forms.Padding(4);
            this.TbSofor.Multiline = true;
            this.TbSofor.Name = "TbSofor";
            this.TbSofor.Size = new System.Drawing.Size(203, 25);
            this.TbSofor.TabIndex = 72;
            // 
            // TbPlaka
            // 
            this.TbPlaka.Enabled = false;
            this.TbPlaka.Location = new System.Drawing.Point(137, 234);
            this.TbPlaka.Margin = new System.Windows.Forms.Padding(4);
            this.TbPlaka.Multiline = true;
            this.TbPlaka.Name = "TbPlaka";
            this.TbPlaka.Size = new System.Drawing.Size(203, 25);
            this.TbPlaka.TabIndex = 71;
            // 
            // LbGirisAgirlik
            // 
            this.LbGirisAgirlik.AutoSize = true;
            this.LbGirisAgirlik.BackColor = System.Drawing.Color.Transparent;
            this.LbGirisAgirlik.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.LbGirisAgirlik.Location = new System.Drawing.Point(14, 320);
            this.LbGirisAgirlik.Name = "LbGirisAgirlik";
            this.LbGirisAgirlik.Size = new System.Drawing.Size(113, 21);
            this.LbGirisAgirlik.TabIndex = 70;
            this.LbGirisAgirlik.Text = "Giriş Ağırlığı :";
            // 
            // LbSofor
            // 
            this.LbSofor.AutoSize = true;
            this.LbSofor.BackColor = System.Drawing.Color.Transparent;
            this.LbSofor.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.LbSofor.Location = new System.Drawing.Point(72, 278);
            this.LbSofor.Name = "LbSofor";
            this.LbSofor.Size = new System.Drawing.Size(55, 21);
            this.LbSofor.TabIndex = 69;
            this.LbSofor.Text = "Şoför :";
            // 
            // LbPlaka
            // 
            this.LbPlaka.AutoSize = true;
            this.LbPlaka.BackColor = System.Drawing.Color.Transparent;
            this.LbPlaka.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbPlaka.Location = new System.Drawing.Point(70, 235);
            this.LbPlaka.Name = "LbPlaka";
            this.LbPlaka.Size = new System.Drawing.Size(57, 21);
            this.LbPlaka.TabIndex = 68;
            this.LbPlaka.Text = "Plaka :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(76, 628);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 39);
            this.button1.TabIndex = 80;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DtVeriKaydi
            // 
            this.DtVeriKaydi.AutoGenerateColumns = false;
            this.DtVeriKaydi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtVeriKaydi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plakaDataGridViewTextBoxColumn,
            this.soforadiDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.cikisagirligiDataGridViewTextBoxColumn,
            this.giristarihiDataGridViewTextBoxColumn,
            this.cikistarihiDataGridViewTextBoxColumn,
            this.urünmiktarDataGridViewTextBoxColumn,
            this.kullaniciidDataGridViewTextBoxColumn});
            this.DtVeriKaydi.DataSource = this.tblKantarBindingSource;
            this.DtVeriKaydi.Location = new System.Drawing.Point(347, 90);
            this.DtVeriKaydi.Name = "DtVeriKaydi";
            this.DtVeriKaydi.RowTemplate.Height = 24;
            this.DtVeriKaydi.Size = new System.Drawing.Size(844, 563);
            this.DtVeriKaydi.TabIndex = 81;
            this.DtVeriKaydi.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtVeriKaydi_CellContentDoubleClick_1);
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "Plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "Plaka";
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            // 
            // soforadiDataGridViewTextBoxColumn
            // 
            this.soforadiDataGridViewTextBoxColumn.DataPropertyName = "Sofor_adi";
            this.soforadiDataGridViewTextBoxColumn.HeaderText = "Sofor_adi";
            this.soforadiDataGridViewTextBoxColumn.Name = "soforadiDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Giris_agirligi";
            this.dataGridViewTextBoxColumn1.HeaderText = "Giris_agirligi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // cikisagirligiDataGridViewTextBoxColumn
            // 
            this.cikisagirligiDataGridViewTextBoxColumn.DataPropertyName = "Cikis_agirligi";
            this.cikisagirligiDataGridViewTextBoxColumn.HeaderText = "Cikis_agirligi";
            this.cikisagirligiDataGridViewTextBoxColumn.Name = "cikisagirligiDataGridViewTextBoxColumn";
            // 
            // giristarihiDataGridViewTextBoxColumn
            // 
            this.giristarihiDataGridViewTextBoxColumn.DataPropertyName = "Giris_tarihi";
            this.giristarihiDataGridViewTextBoxColumn.HeaderText = "Giris_tarihi";
            this.giristarihiDataGridViewTextBoxColumn.Name = "giristarihiDataGridViewTextBoxColumn";
            // 
            // cikistarihiDataGridViewTextBoxColumn
            // 
            this.cikistarihiDataGridViewTextBoxColumn.DataPropertyName = "Cikis_tarihi";
            this.cikistarihiDataGridViewTextBoxColumn.HeaderText = "Cikis_tarihi";
            this.cikistarihiDataGridViewTextBoxColumn.Name = "cikistarihiDataGridViewTextBoxColumn";
            // 
            // urünmiktarDataGridViewTextBoxColumn
            // 
            this.urünmiktarDataGridViewTextBoxColumn.DataPropertyName = "Urün_miktar";
            this.urünmiktarDataGridViewTextBoxColumn.HeaderText = "Urün_miktar";
            this.urünmiktarDataGridViewTextBoxColumn.Name = "urünmiktarDataGridViewTextBoxColumn";
            // 
            // kullaniciidDataGridViewTextBoxColumn
            // 
            this.kullaniciidDataGridViewTextBoxColumn.DataPropertyName = "Kullanici_id";
            this.kullaniciidDataGridViewTextBoxColumn.HeaderText = "Kullanici_id";
            this.kullaniciidDataGridViewTextBoxColumn.Name = "kullaniciidDataGridViewTextBoxColumn";
            // 
            // tblKantarBindingSource
            // 
            this.tblKantarBindingSource.DataMember = "Tbl_Kantar";
            this.tblKantarBindingSource.DataSource = this.kantarDataSet4;
            // 
            // kantarDataSet4
            // 
            this.kantarDataSet4.DataSetName = "KantarDataSet4";
            this.kantarDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_KantarTableAdapter
            // 
            this.tbl_KantarTableAdapter.ClearBeforeFill = true;
            // 
            // FmCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1203, 690);
            this.Controls.Add(this.DtVeriKaydi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LbUrunAgirlik);
            this.Controls.Add(this.LbCikisAgirlik);
            this.Controls.Add(this.TbÜrün);
            this.Controls.Add(this.TbCikis);
            this.Controls.Add(this.BtnKayit);
            this.Controls.Add(this.TbAgirlik);
            this.Controls.Add(this.TbSofor);
            this.Controls.Add(this.TbPlaka);
            this.Controls.Add(this.LbGirisAgirlik);
            this.Controls.Add(this.LbSofor);
            this.Controls.Add(this.LbPlaka);
            this.Controls.Add(this.LbKullanici);
            this.Controls.Add(this.LbSoyad);
            this.Controls.Add(this.LbAd);
            this.Controls.Add(this.BtnTart);
            this.Controls.Add(this.LbSaat);
            this.Controls.Add(this.LbTarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnAdmin);
            this.Controls.Add(this.btCikis);
            this.Controls.Add(this.btAnasayfa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(90, 90);
            this.Name = "FmCikis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmCikis";
            this.Load += new System.EventHandler(this.FmCikis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtVeriKaydi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKantarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.Button btCikis;
        private System.Windows.Forms.Button btAnasayfa;
        private System.Windows.Forms.Label LbKullanici;
        private System.Windows.Forms.Label LbSoyad;
        private System.Windows.Forms.Label LbAd;
        private System.Windows.Forms.Button BtnTart;
        private System.Windows.Forms.Label LbSaat;
        private System.Windows.Forms.Label LbTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbUrunAgirlik;
        private System.Windows.Forms.Label LbCikisAgirlik;
        private System.Windows.Forms.TextBox TbÜrün;
        private System.Windows.Forms.TextBox TbCikis;
        private System.Windows.Forms.Button BtnKayit;
        private System.Windows.Forms.TextBox TbAgirlik;
        private System.Windows.Forms.TextBox TbSofor;
        private System.Windows.Forms.TextBox TbPlaka;
        private System.Windows.Forms.Label LbGirisAgirlik;
        private System.Windows.Forms.Label LbSofor;
        private System.Windows.Forms.Label LbPlaka;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisagirligiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DtVeriKaydi;
        private KantarDataSet4 kantarDataSet4;
        private System.Windows.Forms.BindingSource tblKantarBindingSource;
        private KantarDataSet4TableAdapters.Tbl_KantarTableAdapter tbl_KantarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soforadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisagirligiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giristarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikistarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urünmiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciidDataGridViewTextBoxColumn;
    }
}