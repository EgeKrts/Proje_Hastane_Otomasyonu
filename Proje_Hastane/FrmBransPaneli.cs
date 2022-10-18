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
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Branslar (BransAd) VALUES(@p1)",bgl.connection());
           
            komut.Parameters.AddWithValue("@p1",txtBransAd.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Branş Eklendi.");
        }

        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {



            //Bransları Datagrid e cekme

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Branslar", bgl.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtBransId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Branslar WHERE BransAd=@p1",bgl.connection());
            komut.Parameters.AddWithValue("@p1", txtBransAd.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Branş Silindi");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Branslar",bgl.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Branslar SET BransAd=@p1 WHERE BransId = @p2",bgl.connection());
            komut.Parameters.AddWithValue("@p1",txtBransAd.Text);
            komut.Parameters.AddWithValue("@p2",txtBransId.Text);
            komut.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Branş Güncellendi.");
        }
    }
}
