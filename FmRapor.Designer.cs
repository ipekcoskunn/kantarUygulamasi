namespace KantarUygulaması
{
    partial class FmRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmRapor));
            this.LbKullanici = new System.Windows.Forms.Label();
            this.LbSoyad = new System.Windows.Forms.Label();
            this.LbAd = new System.Windows.Forms.Label();
            this.LbSaat = new System.Windows.Forms.Label();
            this.LbTarih = new System.Windows.Forms.Label();
            this.LbRapor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btCikis = new System.Windows.Forms.Button();
            this.btAnasayfa = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soforadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisagirligiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisagirligiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giristarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikistarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urünmiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKantarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kantarDataSet3 = new KantarUygulaması.KantarDataSet3();
            this.TbArama = new System.Windows.Forms.TextBox();
            this.LblPlk = new System.Windows.Forms.Label();
            this.BtnAraPlaka = new System.Windows.Forms.Button();
            this.BtnAraTarih = new System.Windows.Forms.Button();
            this.DtGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.LblGTarih = new System.Windows.Forms.Label();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.tbl_KantarTableAdapter = new KantarUygulaması.KantarDataSet3TableAdapters.Tbl_KantarTableAdapter();
            this.Btnexcel = new System.Windows.Forms.Button();
            this.BtnTarihAra = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKantarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // LbKullanici
            // 
            this.LbKullanici.AutoSize = true;
            this.LbKullanici.BackColor = System.Drawing.Color.Transparent;
            this.LbKullanici.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbKullanici.Location = new System.Drawing.Point(545, 34);
            this.LbKullanici.Name = "LbKullanici";
            this.LbKullanici.Size = new System.Drawing.Size(74, 19);
            this.LbKullanici.TabIndex = 70;
            this.LbKullanici.Text = "Kullanıcı: ";
            // 
            // LbSoyad
            // 
            this.LbSoyad.AutoSize = true;
            this.LbSoyad.BackColor = System.Drawing.Color.Transparent;
            this.LbSoyad.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.LbSoyad.Location = new System.Drawing.Point(689, 34);
            this.LbSoyad.Name = "LbSoyad";
            this.LbSoyad.Size = new System.Drawing.Size(57, 21);
            this.LbSoyad.TabIndex = 69;
            this.LbSoyad.Text = " Soyad";
            // 
            // LbAd
            // 
            this.LbAd.AutoSize = true;
            this.LbAd.BackColor = System.Drawing.Color.Transparent;
            this.LbAd.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.LbAd.Location = new System.Drawing.Point(626, 34);
            this.LbAd.Name = "LbAd";
            this.LbAd.Size = new System.Drawing.Size(31, 21);
            this.LbAd.TabIndex = 68;
            this.LbAd.Text = "Ad";
            // 
            // LbSaat
            // 
            this.LbSaat.AutoSize = true;
            this.LbSaat.BackColor = System.Drawing.Color.Transparent;
            this.LbSaat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbSaat.Location = new System.Drawing.Point(810, 36);
            this.LbSaat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbSaat.Name = "LbSaat";
            this.LbSaat.Size = new System.Drawing.Size(40, 19);
            this.LbSaat.TabIndex = 67;
            this.LbSaat.Text = "Saat";
            // 
            // LbTarih
            // 
            this.LbTarih.AutoSize = true;
            this.LbTarih.BackColor = System.Drawing.Color.Transparent;
            this.LbTarih.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbTarih.Location = new System.Drawing.Point(810, 15);
            this.LbTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTarih.Name = "LbTarih";
            this.LbTarih.Size = new System.Drawing.Size(48, 19);
            this.LbTarih.TabIndex = 66;
            this.LbTarih.Text = "Tarih";
            // 
            // LbRapor
            // 
            this.LbRapor.AutoSize = true;
            this.LbRapor.BackColor = System.Drawing.Color.Transparent;
            this.LbRapor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbRapor.Location = new System.Drawing.Point(137, 32);
            this.LbRapor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbRapor.Name = "LbRapor";
            this.LbRapor.Size = new System.Drawing.Size(62, 23);
            this.LbRapor.TabIndex = 65;
            this.LbRapor.Text = "Rapor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(113, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 2);
            this.panel2.TabIndex = 64;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 89);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // btCikis
            // 
            this.btCikis.BackColor = System.Drawing.Color.Transparent;
            this.btCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCikis.BackgroundImage")));
            this.btCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btCikis.Location = new System.Drawing.Point(10, 565);
            this.btCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btCikis.Name = "btCikis";
            this.btCikis.Size = new System.Drawing.Size(60, 60);
            this.btCikis.TabIndex = 72;
            this.btCikis.UseVisualStyleBackColor = false;
            this.btCikis.Click += new System.EventHandler(this.btCikis_Click);
            // 
            // btAnasayfa
            // 
            this.btAnasayfa.BackColor = System.Drawing.Color.Transparent;
            this.btAnasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAnasayfa.BackgroundImage")));
            this.btAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btAnasayfa.Location = new System.Drawing.Point(10, 501);
            this.btAnasayfa.Margin = new System.Windows.Forms.Padding(4);
            this.btAnasayfa.Name = "btAnasayfa";
            this.btAnasayfa.Size = new System.Drawing.Size(60, 60);
            this.btAnasayfa.TabIndex = 71;
            this.btAnasayfa.UseVisualStyleBackColor = false;
            this.btAnasayfa.Click += new System.EventHandler(this.btAnasayfa_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plakaDataGridViewTextBoxColumn,
            this.soforadiDataGridViewTextBoxColumn,
            this.girisagirligiDataGridViewTextBoxColumn,
            this.cikisagirligiDataGridViewTextBoxColumn,
            this.giristarihiDataGridViewTextBoxColumn,
            this.cikistarihiDataGridViewTextBoxColumn,
            this.urünmiktarDataGridViewTextBoxColumn,
            this.kullaniciidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblKantarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(113, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(885, 502);
            this.dataGridView1.TabIndex = 73;
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
            this.soforadiDataGridViewTextBoxColumn.HeaderText = "Şoför";
            this.soforadiDataGridViewTextBoxColumn.Name = "soforadiDataGridViewTextBoxColumn";
            // 
            // girisagirligiDataGridViewTextBoxColumn
            // 
            this.girisagirligiDataGridViewTextBoxColumn.DataPropertyName = "Giris_agirligi";
            this.girisagirligiDataGridViewTextBoxColumn.HeaderText = "Giriş Ağırlığı";
            this.girisagirligiDataGridViewTextBoxColumn.Name = "girisagirligiDataGridViewTextBoxColumn";
            // 
            // cikisagirligiDataGridViewTextBoxColumn
            // 
            this.cikisagirligiDataGridViewTextBoxColumn.DataPropertyName = "Cikis_agirligi";
            this.cikisagirligiDataGridViewTextBoxColumn.HeaderText = "Çıkış Ağırlı";
            this.cikisagirligiDataGridViewTextBoxColumn.Name = "cikisagirligiDataGridViewTextBoxColumn";
            // 
            // giristarihiDataGridViewTextBoxColumn
            // 
            this.giristarihiDataGridViewTextBoxColumn.DataPropertyName = "Giris_tarihi";
            this.giristarihiDataGridViewTextBoxColumn.HeaderText = "Giriş Tarihi";
            this.giristarihiDataGridViewTextBoxColumn.Name = "giristarihiDataGridViewTextBoxColumn";
            // 
            // cikistarihiDataGridViewTextBoxColumn
            // 
            this.cikistarihiDataGridViewTextBoxColumn.DataPropertyName = "Cikis_tarihi";
            this.cikistarihiDataGridViewTextBoxColumn.HeaderText = "Çıkış Tarihi";
            this.cikistarihiDataGridViewTextBoxColumn.Name = "cikistarihiDataGridViewTextBoxColumn";
            // 
            // urünmiktarDataGridViewTextBoxColumn
            // 
            this.urünmiktarDataGridViewTextBoxColumn.DataPropertyName = "Urün_miktar";
            this.urünmiktarDataGridViewTextBoxColumn.HeaderText = "Ürün Miktarı";
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
            this.tblKantarBindingSource.DataSource = this.kantarDataSet3;
            // 
            // kantarDataSet3
            // 
            this.kantarDataSet3.DataSetName = "KantarDataSet3";
            this.kantarDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TbArama
            // 
            this.TbArama.Location = new System.Drawing.Point(440, 132);
            this.TbArama.Name = "TbArama";
            this.TbArama.Size = new System.Drawing.Size(179, 26);
            this.TbArama.TabIndex = 75;
            this.TbArama.Visible = false;
            this.TbArama.TextChanged += new System.EventHandler(this.TbArama_TextChanged);
            // 
            // LblPlk
            // 
            this.LblPlk.AutoSize = true;
            this.LblPlk.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPlk.Location = new System.Drawing.Point(440, 108);
            this.LblPlk.Name = "LblPlk";
            this.LblPlk.Size = new System.Drawing.Size(167, 21);
            this.LblPlk.TabIndex = 76;
            this.LblPlk.Text = "Aranacak Plaka/Şoför:";
            this.LblPlk.Visible = false;
            // 
            // BtnAraPlaka
            // 
            this.BtnAraPlaka.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnAraPlaka.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAraPlaka.ForeColor = System.Drawing.Color.Maroon;
            this.BtnAraPlaka.Location = new System.Drawing.Point(356, 87);
            this.BtnAraPlaka.Name = "BtnAraPlaka";
            this.BtnAraPlaka.Size = new System.Drawing.Size(176, 71);
            this.BtnAraPlaka.TabIndex = 77;
            this.BtnAraPlaka.Text = "Plaka/Şoföre Göre Arama";
            this.BtnAraPlaka.UseVisualStyleBackColor = false;
            this.BtnAraPlaka.Click += new System.EventHandler(this.BtnAraPlaka_Click);
            // 
            // BtnAraTarih
            // 
            this.BtnAraTarih.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnAraTarih.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAraTarih.ForeColor = System.Drawing.Color.Maroon;
            this.BtnAraTarih.Location = new System.Drawing.Point(570, 87);
            this.BtnAraTarih.Name = "BtnAraTarih";
            this.BtnAraTarih.Size = new System.Drawing.Size(176, 71);
            this.BtnAraTarih.TabIndex = 78;
            this.BtnAraTarih.Text = "Tarihe Göre Arama";
            this.BtnAraTarih.UseVisualStyleBackColor = false;
            this.BtnAraTarih.Click += new System.EventHandler(this.BtnAraTarih_Click);
            // 
            // DtGirisTarihi
            // 
            this.DtGirisTarihi.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtGirisTarihi.Location = new System.Drawing.Point(347, 133);
            this.DtGirisTarihi.Name = "DtGirisTarihi";
            this.DtGirisTarihi.Size = new System.Drawing.Size(200, 25);
            this.DtGirisTarihi.TabIndex = 79;
            this.DtGirisTarihi.Visible = false;
            // 
            // DtCikisTarihi
            // 
            this.DtCikisTarihi.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtCikisTarihi.Location = new System.Drawing.Point(556, 133);
            this.DtCikisTarihi.Name = "DtCikisTarihi";
            this.DtCikisTarihi.Size = new System.Drawing.Size(200, 25);
            this.DtCikisTarihi.TabIndex = 80;
            this.DtCikisTarihi.Visible = false;
            // 
            // LblGTarih
            // 
            this.LblGTarih.AutoSize = true;
            this.LblGTarih.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGTarih.Location = new System.Drawing.Point(397, 109);
            this.LblGTarih.Name = "LblGTarih";
            this.LblGTarih.Size = new System.Drawing.Size(321, 21);
            this.LblGTarih.TabIndex = 81;
            this.LblGTarih.Text = "Arama Yapacağınız Tarih Aralığını Seçiniz :";
            this.LblGTarih.Visible = false;
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdmin.BackgroundImage")));
            this.BtnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdmin.Location = new System.Drawing.Point(10, 440);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(60, 60);
            this.BtnAdmin.TabIndex = 83;
            this.BtnAdmin.UseVisualStyleBackColor = false;
            // 
            // tbl_KantarTableAdapter
            // 
            this.tbl_KantarTableAdapter.ClearBeforeFill = true;
            // 
            // Btnexcel
            // 
            this.Btnexcel.BackColor = System.Drawing.Color.RosyBrown;
            this.Btnexcel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnexcel.ForeColor = System.Drawing.Color.Maroon;
            this.Btnexcel.Location = new System.Drawing.Point(165, 87);
            this.Btnexcel.Name = "Btnexcel";
            this.Btnexcel.Size = new System.Drawing.Size(176, 71);
            this.Btnexcel.TabIndex = 84;
            this.Btnexcel.Text = "Excel\'e Aktar";
            this.Btnexcel.UseVisualStyleBackColor = false;
            this.Btnexcel.Click += new System.EventHandler(this.Btnexcel_Click);
            // 
            // BtnTarihAra
            // 
            this.BtnTarihAra.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnTarihAra.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTarihAra.ForeColor = System.Drawing.Color.Maroon;
            this.BtnTarihAra.Location = new System.Drawing.Point(777, 87);
            this.BtnTarihAra.Name = "BtnTarihAra";
            this.BtnTarihAra.Size = new System.Drawing.Size(176, 71);
            this.BtnTarihAra.TabIndex = 85;
            this.BtnTarihAra.Text = "Ara";
            this.BtnTarihAra.UseVisualStyleBackColor = false;
            this.BtnTarihAra.Visible = false;
            this.BtnTarihAra.Click += new System.EventHandler(this.BtnTarihAra_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(10, 628);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 50);
            this.button1.TabIndex = 86;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1010, 690);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnTarihAra);
            this.Controls.Add(this.Btnexcel);
            this.Controls.Add(this.BtnAdmin);
            this.Controls.Add(this.LblGTarih);
            this.Controls.Add(this.DtCikisTarihi);
            this.Controls.Add(this.DtGirisTarihi);
            this.Controls.Add(this.BtnAraTarih);
            this.Controls.Add(this.BtnAraPlaka);
            this.Controls.Add(this.LblPlk);
            this.Controls.Add(this.TbArama);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btCikis);
            this.Controls.Add(this.btAnasayfa);
            this.Controls.Add(this.LbKullanici);
            this.Controls.Add(this.LbSoyad);
            this.Controls.Add(this.LbAd);
            this.Controls.Add(this.LbSaat);
            this.Controls.Add(this.LbTarih);
            this.Controls.Add(this.LbRapor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmRapor";
            this.Load += new System.EventHandler(this.FmRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKantarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbKullanici;
        private System.Windows.Forms.Label LbSoyad;
        private System.Windows.Forms.Label LbAd;
        private System.Windows.Forms.Label LbSaat;
        private System.Windows.Forms.Label LbTarih;
        private System.Windows.Forms.Label LbRapor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btCikis;
        private System.Windows.Forms.Button btAnasayfa;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TbArama;
        private System.Windows.Forms.Label LblPlk;
        private System.Windows.Forms.Button BtnAraPlaka;
        private System.Windows.Forms.Button BtnAraTarih;
        private System.Windows.Forms.DateTimePicker DtGirisTarihi;
        private System.Windows.Forms.DateTimePicker DtCikisTarihi;
        private System.Windows.Forms.Label LblGTarih;
        private System.Windows.Forms.Button BtnAdmin;
        private KantarDataSet3 kantarDataSet3;
        private System.Windows.Forms.BindingSource tblKantarBindingSource;
        private KantarDataSet3TableAdapters.Tbl_KantarTableAdapter tbl_KantarTableAdapter;
        private System.Windows.Forms.Button Btnexcel;
        private System.Windows.Forms.Button BtnTarihAra;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soforadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisagirligiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisagirligiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giristarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikistarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urünmiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}