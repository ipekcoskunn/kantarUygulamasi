using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KantarUygulaması
{
    public partial class FmAnasayfa : Form
    {
        public FmAnasayfa()
        {
            InitializeComponent();
        }

        private void BtnAracGiris_Click(object sender, EventArgs e)
        {
            FmAracGiris arac = new FmAracGiris();
            arac.Show();
            this.Hide();
        }

        private void BtnAracCikis_Click(object sender, EventArgs e)
        {
            FmCikis cikis = new FmCikis();
            cikis.Show();
            this.Hide();
        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            FmAracListesi liste = new FmAracListesi();
            liste.Show();
            this.Hide();
        }

        private void BtnRapor_Click(object sender, EventArgs e)
        {
            FmRapor rapor = new FmRapor();
            rapor.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
