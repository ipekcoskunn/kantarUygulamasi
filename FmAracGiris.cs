using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO.Ports;


namespace KantarUygulaması
{
    public partial class FmAracGiris : Form
    {
        public FmAracGiris()
        {
            InitializeComponent();
        }
        public static string giriskilo;
        string tarih;
        SqlConnection baglanti = new SqlConnection("Data Source=ALEYNA\\SQLEXPRESS;Initial Catalog=Kantar;Integrated Security=True");
        String portnum;
  
        private void FmAracGiris_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LbAd.Text = FmGiris.isim.ToString();
            LbSoyad.Text = FmGiris.soyisim.ToString();
            string[] Portlar = SerialPort.GetPortNames();
            foreach (string port in Portlar)
            {
                portnum = port;
            }
   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label2.Text = DateTime.Now.ToLongTimeString();
            LblGiris.Text = DateTime.Now.ToString();
            
            DateTime dt=DateTime.Now;
            string format = "yyyy-MM-dd";
            var zamanim = dt.ToString(format);
            tarih = zamanim.ToString();
          //  tarih = dt.Year+ "-"  + dt.Month + "-" +dt.Day ;        
        }

        private void BtnTart_Click(object sender, EventArgs e)
        {
            serialPort1.PortName =portnum;
            serialPort1.Open();
            string sonuc = serialPort1.ReadLine();
            BtnTart.Text = sonuc + "";
            serialPort1.DiscardInBuffer();
            giriskilo = BtnTart.Text;
            serialPort1.Close();
            TbAgirlik.Text = BtnTart.Text;
        }

        private void btAnasayfa_Click(object sender, EventArgs e)
        {
            FmAnasayfa ana = new FmAnasayfa();
            ana.Show();
            this.Hide();
        }

        private void btCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void BtnGrsKyt_Click(object sender, EventArgs e)
        {
           /* DataTable dt = new DataTable();
            string sql = "select k.Plaka,k.Sofor_adi,k.Giris_agirligi,k.Cikis_agirligi,k.Giris_tarihi,k.Cikis_tarihi,k.Urün_miktar,kg.Ad from Tbl_Kantar k join KullaniciGiris kg on k.Kullanici_id=kg.Kullanici_id";
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            da.Fill(dt);*/


            DateTime gt = Convert.ToDateTime(tarih);
            baglanti.Open();
            SqlCommand kaydet = new SqlCommand("insert into Tbl_Kantar (Plaka,Sofor_adi,Giris_agirligi,Giris_tarihi,Kullanici_id) values (@plk,@sfr,@grsa,@grst,@id)", baglanti);
            kaydet.Parameters.AddWithValue("@plk", TbPlaka.Text);
            kaydet.Parameters.AddWithValue("@sfr", TbSofor.Text);
            kaydet.Parameters.AddWithValue("@grsa", Convert.ToInt32(TbAgirlik.Text));
            kaydet.Parameters.AddWithValue("@grst", gt);
            kaydet.Parameters.AddWithValue("@id", FmGiris.Kullanici_id);
            kaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araç Kaydı Alındı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
             

        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            FmGiris grs = new FmGiris();
            grs.Show();
            this.Hide();
        }

        private void LbAd_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }





        public object Kullanici_id { get; set; }
    }
}
