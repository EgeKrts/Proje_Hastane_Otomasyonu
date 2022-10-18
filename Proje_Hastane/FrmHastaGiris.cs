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

namespace Proje_Hastane
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi baglanti = new sqlbaglantisi();


        private void linkLblUyeOL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit();

            fr.Show();

            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Hastalar WHERE HastaTC=@p1 AND HastaSifre=@p2",baglanti.connection());
            komut.Parameters.AddWithValue("@p1",maskedTC.Text);
            komut.Parameters.AddWithValue("@p2",txtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc = maskedTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre");
            }

            baglanti.connection().Close();
        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
