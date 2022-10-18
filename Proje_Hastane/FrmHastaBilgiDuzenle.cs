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
    public partial class FrmHastaBilgiDuzenle : Form
    {
        public FrmHastaBilgiDuzenle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        public string tc;
        private void FrmHastaBilgiDuzenle_Load(object sender, EventArgs e)
        {
            maskedTCKimlik.Text = tc;

            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Hastalar WHERE HastaTC=@p1",bgl.connection());
            komut.Parameters.AddWithValue("@p1", maskedTCKimlik.Text);

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                maskedTelefon.Text=dr[4].ToString();
                txtSifre.Text=dr[5].ToString();
                comboCinsiyet.Text = dr[6].ToString();
            }
            bgl.connection().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Hastalar SET HastaAd = @p1, HastaSoyad = @p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 WHERE HastaTC=@p6",bgl.connection());
            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",maskedTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut.Parameters.AddWithValue("@p5", comboCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", maskedTCKimlik.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Bilgileriniz Güncellenmiştir","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
