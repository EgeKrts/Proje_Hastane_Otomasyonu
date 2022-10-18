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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            labelTC.Text = tc;
            
            //Doktor Ad-Soyad
            SqlCommand komut = new SqlCommand("SELECT DoktorAd,DoktorSoyad FROM Tbl_Doktorlar WHERE DoktorTC = @p1",bgl.connection());
            komut.Parameters.AddWithValue("@p1",labelTC.Text);

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                labelAdSoyad.Text = dr[0] +" "+dr[1];
            }
            bgl.connection().Close();

            //Randevular

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Randevular WHERE RandevuDoktor='"+labelAdSoyad.Text+"'",bgl.connection());
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle frm = new FrmDoktorBilgiDuzenle();
            frm.tc = labelTC.Text;
            frm.Show();
           
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richRandevuDetay.Text = "Hasta TC: "+dataGridView1.Rows[secilen].Cells[6].Value.ToString() +"\n"+"Hasta Şikayeti: "+"\n"+dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
