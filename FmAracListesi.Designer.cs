namespace KantarUygulaması
{
    partial class FmAracListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmAracListesi));
            this.LbKullanici = new System.Windows.Forms.Label();
            this.LbSoyad = new System.Windows.Forms.Label();
            this.LbAd = new System.Windows.Forms.Label();
            this.LbSaat = new System.Windows.Forms.Label();
            this.LbTarih = new System.Windows.Forms.Label();
            this.LbAracListesi = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btCikis = new System.Windows.Forms.Button();
            this.btAnasayfa = new System.Windows.Forms.Button();
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
            this.kantarDataSet2 = new KantarUygulaması.KantarDataSet2();
            this.tbl_KantarTableAdapter = new KantarUygulaması.KantarDataSet2TableAdapters.Tbl_KantarTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKantarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // LbKullanici
            // 
            this.LbKullanici.AutoSize = true;
            this.LbKullanici.BackColor = System.Drawing.Color.Transparent;
            this.LbKullanici.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.LbKullanici.Location = new System.Drawing.Point(550, 33);
            this.LbKullanici.Name = "LbKullanici";
            this.LbKullanici.Size = new System.Drawing.Size(85, 21);
            this.LbKullanici.TabIndex = 62;
            this.LbKullanici.Text = "Kullanıcı: ";
            // 
            // LbSoyad
            // 
            this.LbSoyad.AutoSize = true;
            this.LbSoyad.BackColor = System.Drawing.Color.Transparent;
            this.LbSoyad.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.LbSoyad.Location = new System.Drawing.Point(694, 33);
            this.LbSoyad.Name = "LbSoyad";
            this.LbSoyad.Size = new System.Drawing.Size(57, 21);
            this.LbSoyad.TabIndex = 61;
            this.LbSoyad.Text = " Soyad";
            // 
            // LbAd
            // 
            this.LbAd.AutoSize = true;
            this.LbAd.BackColor = System.Drawing.Color.Transparent;
            this.LbAd.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.LbAd.Location = new System.Drawing.Point(631, 33);
            this.LbAd.Name = "LbAd";
            this.LbAd.Size = new System.Drawing.Size(31, 21);
            this.LbAd.TabIndex = 60;
            this.LbAd.Text = "Ad";
            this.LbAd.Click += new System.EventHandler(this.LbAd_Click);
            // 
            // LbSaat
            // 
            this.LbSaat.AutoSize = true;
            this.LbSaat.BackColor = System.Drawing.Color.Transparent;
            this.LbSaat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbSaat.Location = new System.Drawing.Point(815, 35);
            this.LbSaat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LbSaat.Name = "LbSaat";
            this.LbSaat.Size = new System.Drawing.Size(40, 19);
            this.LbSaat.TabIndex = 59;
            this.LbSaat.Text = "Saat";
            // 
            // LbTarih
            // 
            this.LbTarih.AutoSize = true;
            this.LbTarih.BackColor = System.Drawing.Color.Transparent;
            this.LbTarih.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbTarih.Location = new System.Drawing.Point(815, 14);
            this.LbTarih.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LbTarih.Name = "LbTarih";
            this.LbTarih.Size = new System.Drawing.Size(48, 19);
            this.LbTarih.TabIndex = 58;
            this.LbTarih.Text = "Tarih";
            // 
            // LbAracListesi
            // 
            this.LbAracListesi.AutoSize = true;
            this.LbAracListesi.BackColor = System.Drawing.Color.Transparent;
            this.LbAracListesi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbAracListesi.Location = new System.Drawing.Point(138, 30);
            this.LbAracListesi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LbAracListesi.Name = "LbAracListesi";
            this.LbAracListesi.Size = new System.Drawing.Size(112, 23);
            this.LbAracListesi.TabIndex = 57;
            this.LbAracListesi.Text = "Araç Listesi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(118, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 2);
            this.panel2.TabIndex = 56;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 89);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btCikis
            // 
            this.btCikis.BackColor = System.Drawing.Color.Transparent;
            this.btCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCikis.BackgroundImage")));
            this.btCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btCikis.Location = new System.Drawing.Point(13, 562);
            this.btCikis.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btCikis.Name = "btCikis";
            this.btCikis.Size = new System.Drawing.Size(59, 62);
            this.btCikis.TabIndex = 64;
            this.btCikis.UseVisualStyleBackColor = false;
            this.btCikis.Click += new System.EventHandler(this.btCikis_Click);
            // 
            // btAnasayfa
            // 
            this.btAnasayfa.BackColor = System.Drawing.Color.Transparent;
            this.btAnasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAnasayfa.BackgroundImage")));
            this.btAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btAnasayfa.Location = new System.Drawing.Point(13, 502);
            this.btAnasayfa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btAnasayfa.Name = "btAnasayfa";
            this.btAnasayfa.Size = new System.Drawing.Size(59, 62);
            this.btAnasayfa.TabIndex = 63;
            this.btAnasayfa.UseVisualStyleBackColor = false;
            this.btAnasayfa.Click += new System.EventHandler(this.btAnasayfa_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(118, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(851, 618);
            this.dataGridView1.TabIndex = 65;
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
            this.cikisagirligiDataGridViewTextBoxColumn.HeaderText = "Çıkış Ağırlığı";
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
            this.tblKantarBindingSource.DataSource = this.kantarDataSet2;
            // 
            // kantarDataSet2
            // 
            this.kantarDataSet2.DataSetName = "KantarDataSet2";
            this.kantarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_KantarTableAdapter
            // 
            this.tbl_KantarTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(13, 623);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 62);
            this.button1.TabIndex = 66;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FmAracListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 708);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btCikis);
            this.Controls.Add(this.btAnasayfa);
            this.Controls.Add(this.LbKullanici);
            this.Controls.Add(this.LbSoyad);
            this.Controls.Add(this.LbAd);
            this.Controls.Add(this.LbSaat);
            this.Controls.Add(this.LbTarih);
            this.Controls.Add(this.LbAracListesi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmAracListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmAracListesi";
            this.Load += new System.EventHandler(this.FmAracListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKantarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantarDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbKullanici;
        private System.Windows.Forms.Label LbSoyad;
        private System.Windows.Forms.Label LbAd;
        private System.Windows.Forms.Label LbSaat;
        private System.Windows.Forms.Label LbTarih;
        private System.Windows.Forms.Label LbAracListesi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btCikis;
        private System.Windows.Forms.Button btAnasayfa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KantarDataSet2 kantarDataSet2;
        private System.Windows.Forms.BindingSource tblKantarBindingSource;
        private KantarDataSet2TableAdapters.Tbl_KantarTableAdapter tbl_KantarTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soforadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisagirligiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisagirligiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giristarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikistarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urünmiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciidDataGridViewTextBoxColumn;
    }
}