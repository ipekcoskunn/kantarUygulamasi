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
    public partial class FmCikis : Form
    {
        public FmCikis()
        {
            InitializeComponent();
        }
        public static string cikiskilo;
        SqlConnection baglanti = new SqlConnection("Data Source=ALEYNA\\SQLEXPRESS;Initial Catalog=Kantar;Integrated Security=True");
        String portnum;
        String tarih;
       public void verilerigoster()
        {
            DataTable dt = new DataTable();
            string sql = "select k.Plaka,k.Sofor_adi,k.Giris_agirligi,k.Cikis_agirligi,k.Giris_tarihi,k.Cikis_tarihi,k.Urün_miktar,kg.Ad from Tbl_Kantar k join KullaniciGiris kg on k.Kullanici_id=kg.Kullanici_id";
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            da.Fill(dt);
            //DtVeriKaydi.DataSource = dt;
        }

        private void FmCikis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kantarDataSet4.Tbl_Kantar' table. You can move, or remove it, as needed.
            this.tbl_KantarTableAdapter.Fill(this.kantarDataSet4.Tbl_Kantar);
            
            timer1.Start();
            LbAd.Text = FmGiris.isim.ToString();
            LbSoyad.Text = FmGiris.soyisim.ToString();
            string[] Portlar = SerialPort.GetPortNames();
            foreach (string port in Portlar)
            {
                portnum = port;
            }
            verilerigoster();

        }

        private void btCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btAnasayfa_Click(object sender, EventArgs e)
        {
            FmAnasayfa ana = new FmAnasayfa();
            ana.Show();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LbTarih.Text = DateTime.Now.ToLongDateString();
            DateTime ck = DateTime.Now;
            string format = "yyyy-MM-dd";
            var zamanim = ck.ToString(format);
            tarih = zamanim.ToString();
        }

   
        private void BtnTart_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = portnum;
            serialPort1.Open();
            string sonuc = serialPort1.ReadLine();
            BtnTart.Text = sonuc + "";
            serialPort1.DiscardInBuffer();
            cikiskilo = BtnTart.Text;
            serialPort1.Close();
            TbCikis.Text = BtnTart.Text;
            TbÜrün.Text = (Convert.ToInt32(TbAgirlik.Text) - Convert.ToInt32(TbCikis.Text)).ToString();
            if (Convert.ToInt32(TbÜrün.Text) < 0)
            {
                TbÜrün.Text = (-(Convert.ToInt32(TbÜrün.Text))).ToString();
            }
            else
            {
                TbÜrün.Text = (-(Convert.ToInt32(TbÜrün.Text))).ToString();

            }
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            DateTime ck = Convert.ToDateTime(tarih);
            baglanti.Open();
            SqlCommand gncll = new SqlCommand("update Tbl_Kantar set Cikis_agirligi=@p1,Urün_miktar=@p2,Cikis_tarihi=@p3 where Plaka=@p4", baglanti);
            string sql = "select k.Plaka,k.Sofor_adi,k.Giris_agirligi,k.Cikis_agirligi,k.Giris_tarihi,k.Cikis_tarihi,k.Urün_miktar,kg.Ad from Tbl_Kantar k join KullaniciGiris kg on k.Kullanici_id=kg.Kullanici_id";
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            gncll.Parameters.AddWithValue("@p1", Convert.ToInt32(TbCikis.Text));
            gncll.Parameters.AddWithValue("@p2", TbÜrün.Text);
            gncll.Parameters.AddWithValue("@p3", ck);
            gncll.Parameters.AddWithValue("@p4", TbPlaka.Text);
            gncll.Parameters.AddWithValue("@p5", FmGiris.Kullanici_id);
            gncll.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydınız başarılı bir şekilde alındı");
            verilerigoster();
            TbPlaka.Text = " ";
            TbSofor.Text = " ";
            TbAgirlik.Text = " ";
            TbCikis.Text = " ";
            TbÜrün.Text = " ";
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            FmGiris grs = new FmGiris();
            grs.Show();
            this.Hide();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DtVeriKaydi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DtVeriKaydi_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = DtVeriKaydi.SelectedCells[0].RowIndex;

            TbPlaka.Text = DtVeriKaydi.Rows[secilen].Cells[0].Value.ToString();
            TbSofor.Text = DtVeriKaydi.Rows[secilen].Cells[1].Value.ToString();
            TbAgirlik.Text = DtVeriKaydi.Rows[secilen].Cells[2].Value.ToString();
        }
    }
}
