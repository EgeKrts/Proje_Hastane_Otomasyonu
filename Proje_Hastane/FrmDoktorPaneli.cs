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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM Tbl_Doktorlar", bgl.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;


            //Brans Cekme

            SqlCommand komut = new SqlCommand("SELECT BransAd FROM Tbl_Branslar",bgl.connection());
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                comboBrans.Items.Add(dr[0].ToString());
            }
            bgl.connection().Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) VALUES(@p1,@p2,@p3,@p4,@p5)",bgl.connection());

            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBrans.Text);
            komut.Parameters.AddWithValue("@p4", maskedTC.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Doktor Kaydı Yapıldı.");

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM Tbl_Doktorlar", bgl.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Doktorlar WHERE DoktorTC=@p1",bgl.connection());
            komut.Parameters.AddWithValue("@p1",maskedTC.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Doktor Kaydı Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Doktorlar SET DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 WHERE DoktorTC=@p4",bgl.connection());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBrans.Text);
            komut.Parameters.AddWithValue("@p4", maskedTC.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Doktor Bilgisi Güncellendi.");
        }
    }
}
