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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        public string tc;
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            labelTC.Text = tc;


            //Ad-Soyad Çekme
            SqlCommand komut = new SqlCommand("SELECT HastaAd,HastaSoyad FROM Tbl_Hastalar WHERE HastaTC = @p1", bgl.connection());
            komut.Parameters.AddWithValue("@p1",labelTC.Text);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                labelAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.connection().Close();

            //Randevu Geçmişi

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Randevular WHERE HastaTC ="+tc,bgl.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branş Çekme

            SqlCommand komut2 = new SqlCommand("SELECT BransAd FROM Tbl_Branslar", bgl.connection());
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                comboBrans.Items.Add(dr2[0].ToString());
            }
            bgl.connection().Close();

           


        }

        private void comboBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Doktor Çekme
            comboDoktor.Items.Clear();  
            SqlCommand komut3 = new SqlCommand("SELECT DoktorAd,DoktorSoyad FROM Tbl_Doktorlar WHERE DoktorBrans=@p1", bgl.connection());

            komut3.Parameters.AddWithValue("@p1", comboBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                comboDoktor.Items.Add(dr3[0]+" "+dr3[1]);
            }
        }

        private void comboDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Randevular WHERE RandevuBrans='"+comboBrans.Text+"' AND RandevuDoktor='"+comboDoktor.Text+"' AND RandevuDurum=0",bgl.connection());
            da.Fill(dt);

            dataGridView2.DataSource = dt;
        }

        private void linkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiDuzenle fr = new FrmHastaBilgiDuzenle();
            fr.tc = labelTC.Text;
            fr.Show();

            
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Randevular SET RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 WHERE RandevuId=@p3",bgl.connection());
            komut.Parameters.AddWithValue("@p1",labelTC.Text);
            komut.Parameters.AddWithValue("@p2",richTxtSikayet.Text);
            komut.Parameters.AddWithValue("@p3",txtId.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Randevu Alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Randevular WHERE HastaTC=@p1",bgl.connection());
            komut.Parameters.AddWithValue("@p1",labelTC.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();
        }
    }
}
