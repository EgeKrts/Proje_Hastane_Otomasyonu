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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        sqlbaglantisi baglanti = new sqlbaglantisi();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti.connection());
            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTCKimlik.Text);
            komut.Parameters.AddWithValue("@p4", maskedTelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.Parameters.AddWithValue("@p6", comboCinsiyet.Text);

            komut.ExecuteNonQuery();
            baglanti.connection().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir."+"\n"+"Sifreniz: "+txtSifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
