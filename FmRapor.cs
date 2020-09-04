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
using excel = Microsoft.Office.Interop.Excel;


namespace KantarUygulaması
{
    public partial class FmRapor : Form
    {
        public FmRapor()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALEYNA\\SQLEXPRESS;Initial Catalog=Kantar;Integrated Security=True");

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

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            //LbSaat.Text = DateTime.Now.ToLongTimeString();
            LbTarih.Text = DateTime.Now.ToLongDateString();
        }

        private void FmRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kantarDataSet3.Tbl_Kantar' table. You can move, or remove it, as needed.
            this.tbl_KantarTableAdapter.Fill(this.kantarDataSet3.Tbl_Kantar);
            LbAd.Text = FmGiris.isim.ToString();
            LbSoyad.Text = FmGiris.soyisim.ToString();

        }

        private void TbArama_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("Select * from Tbl_Kantar where Plaka like '%" + TbArama.Text + "%' or Sofor_adi like'%" + TbArama.Text + "%'", baglanti);
            ara.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglanti.Close();
        }

      

        private void BtnAraPlaka_Click(object sender, EventArgs e)
        {
            LblPlk.Visible = true;
            TbArama.Visible = true;
            BtnAraPlaka.Visible = false;
            BtnAraTarih.Visible = false;
            BtnTarihAra.Visible=false;
            
        }

        private void BtnAraTarih_Click(object sender, EventArgs e)
        {
            LblGTarih.Visible = true;
            DtCikisTarihi.Visible = true;
            DtGirisTarihi.Visible = true;
            BtnAraTarih.Visible = false;
            BtnAraPlaka.Visible = false;
            BtnTarihAra.Visible = true;
        }

        private void Btnexcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application rapor = new Microsoft.Office.Interop.Excel.Application();
            rapor.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = rapor.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, i + 1];
                alan.Value2 = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[j + 2, i + 1];
                    alan.Value2 = dataGridView1[i, j].Value;
                }
            }

        }

        private void BtnTarihAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter ara = new SqlDataAdapter("Select * from Tbl_Kantar where Giris_tarihi between @tarih1 and @tarih2 or Cikis_tarihi between @tarih1 and @tarih2", baglanti);
            ara.SelectCommand.Parameters.AddWithValue("@tarih1", DtGirisTarihi.Value);
            ara.SelectCommand.Parameters.AddWithValue("@tarih2", DtCikisTarihi.Value);
            DataTable tbl = new DataTable();
            ara.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

       
    }
}
