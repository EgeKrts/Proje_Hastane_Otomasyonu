using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Doktorlar SET DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 WHERE DoktorTC=@p5",bgl.connection());
            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",comboBrans.Text);
            komut.Parameters.AddWithValue("@p4",txtSifre.Text);
            komut.Parameters.AddWithValue("@p5",maskedTC.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Doktor Bilgileri Güncellendi.");
        }

        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            maskedTC.Text = tc;

            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Doktorlar WHERE DoktorTC=@p1",bgl.connection());
            komut.Parameters.AddWithValue("@p1", maskedTC.Text);

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                txtSifre.Text = dr[5].ToString();
                comboBrans.Text = dr[3].ToString();

            }
            bgl.connection().Close();
        }
    }
}
