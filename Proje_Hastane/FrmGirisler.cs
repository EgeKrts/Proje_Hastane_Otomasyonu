using System;
using System.Threading;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmGirisler : Form
    {
        Thread th;
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            FrmHastaGiris fr = new FrmHastaGiris();

            fr.Show();

            this.Hide();
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
           FrmDoktorGiris fr = new FrmDoktorGiris();

            fr.Show();

            this.Hide();
        }

        private void btnSekreter_Click(object sender, EventArgs e)
        {
            FrmSekreter fr = new FrmSekreter(); 
            fr.Show();

            this.Hide();
        }
    }
}
