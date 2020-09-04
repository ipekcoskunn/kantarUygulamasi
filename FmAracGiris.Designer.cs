namespace KantarUygulaması
{
    partial class FmAracGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmAracGiris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblGiris = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LbAd = new System.Windows.Forms.Label();
            this.LbSoyad = new System.Windows.Forms.Label();
            this.LbKullanici = new System.Windows.Forms.Label();
            this.BtnTart = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lbPlaka = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btCikis = new System.Windows.Forms.Button();
            this.btAnasayfa = new System.Windows.Forms.Button();
            this.TbAgirlik = new System.Windows.Forms.TextBox();
            this.TbSofor = new System.Windows.Forms.TextBox();
            this.TbPlaka = new System.Windows.Forms.TextBox();
            this.BtnGrsKyt = new System.Windows.Forms.Button();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-18, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 79);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(113, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 2);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(133, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Araç Giriş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(808, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Saat";
            // 
            // LblGiris
            // 
            this.LblGiris.AutoSize = true;
            this.LblGiris.BackColor = System.Drawing.Color.Transparent;
            this.LblGiris.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGiris.Location = new System.Drawing.Point(808, 16);
            this.LblGiris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGiris.Name = "LblGiris";
            this.LblGiris.Size = new System.Drawing.Size(48, 19);
            this.LblGiris.TabIndex = 17;
            this.LblGiris.Text = "Tarih";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LbAd
            // 
            this.LbAd.AutoSize = true;
            this.LbAd.BackColor = System.Drawing.Color.Transparent;
            this.LbAd.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.LbAd.Location = new System.Drawing.Point(637, 27);
            this.LbAd.Name = "LbAd";
            this.LbAd.Size = new System.Drawing.Size(31, 21);
            this.LbAd.TabIndex = 18;
            this.LbAd.Text = "Ad";
            this.LbAd.Click += new System.EventHandler(this.LbAd_Click);
            // 
            // LbSoyad
            // 
            this.LbSoyad.AutoSize = true;
            this.LbSoyad.BackColor = System.Drawing.Color.Transparent;
            this.LbSoyad.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.LbSoyad.Location = new System.Drawing.Point(674, 27);
            this.LbSoyad.Name = "LbSoyad";
            this.LbSoyad.Size = new System.Drawing.Size(57, 21);
            this.LbSoyad.TabIndex = 19;
            this.LbSoyad.Text = " Soyad";
            // 
            // LbKullanici
            // 
            this.LbKullanici.AutoSize = true;
            this.LbKullanici.BackColor = System.Drawing.Color.Transparent;
            this.LbKullanici.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.LbKullanici.Location = new System.Drawing.Point(546, 27);
            this.LbKullanici.Name = "LbKullanici";
            this.LbKullanici.Size = new System.Drawing.Size(85, 21);
            this.LbKullanici.TabIndex = 21;
            this.LbKullanici.Text = "Kullanıcı: ";
            // 
            // BtnTart
            // 
            this.BtnTart.BackColor = System.Drawing.Color.Maroon;
            this.BtnTart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnTart.Location = new System.Drawing.Point(349, 78);
            this.BtnTart.Name = "BtnTart";
            this.BtnTart.Size = new System.Drawing.Size(293, 69);
            this.BtnTart.TabIndex = 22;
            this.BtnTart.Text = "TART";
            this.BtnTart.UseVisualStyleBackColor = false;
            this.BtnTart.Click += new System.EventHandler(this.BtnTart_Click);
            // 
            // lbPlaka
            // 
            this.lbPlaka.AutoSize = true;
            this.lbPlaka.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPlaka.Location = new System.Drawing.Point(330, 248);
            this.lbPlaka.Name = "lbPlaka";
            this.lbPlaka.Size = new System.Drawing.Size(57, 21);
            this.lbPlaka.TabIndex = 25;
            this.lbPlaka.Text = "Plaka :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(332, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 21);
            this.label10.TabIndex = 26;
            this.label10.Text = "Şoför :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(318, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "Ağırlık :";
            // 
            // btCikis
            // 
            this.btCikis.BackColor = System.Drawing.Color.Transparent;
            this.btCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCikis.BackgroundImage")));
            this.btCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btCikis.Location = new System.Drawing.Point(21, 598);
            this.btCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btCikis.Name = "btCikis";
            this.btCikis.Size = new System.Drawing.Size(70, 70);
            this.btCikis.TabIndex = 29;
            this.btCikis.UseVisualStyleBackColor = false;
            this.btCikis.Click += new System.EventHandler(this.btCikis_Click);
            // 
            // btAnasayfa
            // 
            this.btAnasayfa.BackColor = System.Drawing.Color.Transparent;
            this.btAnasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAnasayfa.BackgroundImage")));
            this.btAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btAnasayfa.Location = new System.Drawing.Point(21, 530);
            this.btAnasayfa.Margin = new System.Windows.Forms.Padding(4);
            this.btAnasayfa.Name = "btAnasayfa";
            this.btAnasayfa.Size = new System.Drawing.Size(70, 70);
            this.btAnasayfa.TabIndex = 28;
            this.btAnasayfa.UseVisualStyleBackColor = false;
            this.btAnasayfa.Click += new System.EventHandler(this.btAnasayfa_Click);
            // 
            // TbAgirlik
            // 
            this.TbAgirlik.Enabled = false;
            this.TbAgirlik.Location = new System.Drawing.Point(407, 348);
            this.TbAgirlik.Margin = new System.Windows.Forms.Padding(4);
            this.TbAgirlik.Multiline = true;
            this.TbAgirlik.Name = "TbAgirlik";
            this.TbAgirlik.Size = new System.Drawing.Size(243, 26);
            this.TbAgirlik.TabIndex = 33;
            // 
            // TbSofor
            // 
            this.TbSofor.Location = new System.Drawing.Point(407, 297);
            this.TbSofor.Margin = new System.Windows.Forms.Padding(4);
            this.TbSofor.Multiline = true;
            this.TbSofor.Name = "TbSofor";
            this.TbSofor.Size = new System.Drawing.Size(243, 26);
            this.TbSofor.TabIndex = 32;
            // 
            // TbPlaka
            // 
            this.TbPlaka.Location = new System.Drawing.Point(407, 248);
            this.TbPlaka.Margin = new System.Windows.Forms.Padding(4);
            this.TbPlaka.Multiline = true;
            this.TbPlaka.Name = "TbPlaka";
            this.TbPlaka.Size = new System.Drawing.Size(243, 26);
            this.TbPlaka.TabIndex = 31;
            // 
            // BtnGrsKyt
            // 
            this.BtnGrsKyt.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnGrsKyt.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.BtnGrsKyt.ForeColor = System.Drawing.Color.Maroon;
            this.BtnGrsKyt.Location = new System.Drawing.Point(357, 402);
            this.BtnGrsKyt.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGrsKyt.Name = "BtnGrsKyt";
            this.BtnGrsKyt.Size = new System.Drawing.Size(293, 60);
            this.BtnGrsKyt.TabIndex = 34;
            this.BtnGrsKyt.Text = "Kayıt";
            this.BtnGrsKyt.UseVisualStyleBackColor = false;
            this.BtnGrsKyt.Click += new System.EventHandler(this.BtnGrsKyt_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdmin.BackgroundImage")));
            this.BtnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdmin.Location = new System.Drawing.Point(21, 465);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(70, 70);
            this.BtnAdmin.TabIndex = 35;
            this.BtnAdmin.UseVisualStyleBackColor = true;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(90, 598);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 36;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FmAracGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 690);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAdmin);
            this.Controls.Add(this.BtnGrsKyt);
            this.Controls.Add(this.TbAgirlik);
            this.Controls.Add(this.TbSofor);
            this.Controls.Add(this.TbPlaka);
            this.Controls.Add(this.btCikis);
            this.Controls.Add(this.btAnasayfa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbPlaka);
            this.Controls.Add(this.BtnTart);
            this.Controls.Add(this.LbKullanici);
            this.Controls.Add(this.LbSoyad);
            this.Controls.Add(this.LbAd);
            this.Controls.Add(this.LblGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FmAracGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmAracGiris";
            this.Load += new System.EventHandler(this.FmAracGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblGiris;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LbAd;
        private System.Windows.Forms.Label LbSoyad;
        private System.Windows.Forms.Label LbKullanici;
        private System.Windows.Forms.Button BtnTart;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lbPlaka;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btCikis;
        private System.Windows.Forms.Button btAnasayfa;
        private System.Windows.Forms.TextBox TbAgirlik;
        private System.Windows.Forms.TextBox TbSofor;
        private System.Windows.Forms.TextBox TbPlaka;
        private System.Windows.Forms.Button BtnGrsKyt;
        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.Button button1;
    }
}