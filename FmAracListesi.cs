using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KantarUygulaması
{
    public partial class FmAracListesi : Form
    {
        public FmAracListesi()
        {
            InitializeComponent();
        }

        private void FmAracListesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kantarDataSet2.Tbl_Kantar' table. You can move, or remove it, as needed.
            this.tbl_KantarTableAdapter.Fill(this.kantarDataSet2.Tbl_Kantar);
            timer1.Start();
            LbAd.Text = FmGiris.isim.ToString();
            LbSoyad.Text = FmGiris.soyisim.ToString();
            string[] Portlar = SerialPort.GetPortNames();
            foreach (string port in Portlar)
            {
              //  CmbPort.Items.Add(port);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LbSaat.Text = DateTime.Now.ToLongTimeString();
            LbTarih.Text = DateTime.Now.ToLongDateString();
        }

        private void btCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btAnasayfa_Click(object sender, EventArgs e)
        {
            FmAnasayfa fr = new FmAnasayfa();
            fr.Show();
            this.Hide();
        }

        private void LbAd_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
