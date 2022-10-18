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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        public string tc;
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            labelTC.Text = tc;

            //Ad-Soyad Cekme
            SqlCommand komut = new SqlCommand("SELECT SekAdSoyad FROM Tbl_Sekreter WHERE SekTC =@p1",bgl.connection());
            komut.Parameters.AddWithValue("@p1", labelTC.Text);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                labelAdSoyad.Text = dr[0].ToString();
            }
            bgl.connection().Close();

            //Bransları DataGrid e Cekme

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Branslar",bgl.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Doktorları Datagrid e Cekme

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT (DoktorAd+' '+DoktorSoyad) AS 'Doktorlar',DoktorBrans FROM Tbl_Doktorlar", bgl.connection());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;


            //Bransı comboBox a Cekme
            SqlCommand komut2 = new SqlCommand("SELECT BransAd FROM Tbl_Branslar",bgl.connection());
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                comboBrans.Items.Add(dr2[0].ToString());
            }
            bgl.connection().Close();

            
        }

        private void comboBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT DoktorAd,DoktorSoyad FROM Tbl_Doktorlar WHERE DoktorBrans=@p1",bgl.connection());
            komut.Parameters.AddWithValue("@p1",comboBrans.Text);

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                comboDoktor.Items.Add(dr[0]+" "+dr[1]);
            }
            bgl.connection().Close();
          
        }

        private void btnRandevuKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) VALUES(@r1,@r2,@r3,@r4)",bgl.connection());
            komut.Parameters.AddWithValue("@r1",maskedTarih.Text);
            komut.Parameters.AddWithValue("@r2", maskedSaat.Text);
            komut.Parameters.AddWithValue("@r3", comboBrans.Text);
            komut.Parameters.AddWithValue("@r4", comboDoktor.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Randevu Oluşturuldu.");
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Duyurular (Duyuru) VALUES(@p1)",bgl.connection());
            komut.Parameters.AddWithValue("@p1",richDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fr = new FrmDoktorPaneli();

            fr.Show();
        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBransPaneli fr = new FrmBransPaneli();

            fr.Show();
        }

        private void btnRandevuPaneli_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr = new FrmRandevuListesi();

            fr.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();

        }
    }
}
