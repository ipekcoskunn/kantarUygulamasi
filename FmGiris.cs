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


namespace KantarUygulaması
{
    public partial class FmGiris : Form
    {
        public FmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=ALEYNA\\SQLEXPRESS;Initial Catalog=Kantar;Integrated Security=True");
        public static int Kullanici_id;

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            getir();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from KullaniciGiris where KullaniciAdi=@ka and Sifre=@sfr", baglanti);
            komut.Parameters.AddWithValue("@ka", TxtKullanici.Text);
            komut.Parameters.AddWithValue("@sfr", TxtParola.Text);
            
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                FmAnasayfa ana = new FmAnasayfa();
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }
            baglanti.Close();
        }
        public static string isim;
        public static string soyisim;
        private void getir()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select Ad,Soyad,Kullanici_id from KullaniciGiris where KullaniciAdi=@ka and Sifre=@sfr", baglanti);
            komut.Parameters.AddWithValue("@ka", TxtKullanici.Text);
            komut.Parameters.AddWithValue("@sfr", TxtParola.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                isim = dr[0].ToString();
                soyisim = dr[1].ToString(); 
                Kullanici_id = Convert.ToInt16(dr[2].ToString()); 
                               
            }
            baglanti.Close();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
 
    }
}
