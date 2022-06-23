using System;
using System.Windows.Forms;

namespace RattrapageCSharp.views
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListerComptes lc = new ListerComptes();
            lc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AjouterCompte ac = new AjouterCompte();
            ac.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FaireDepot fp = new FaireDepot();
            fp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FaireRetrait fr = new FaireRetrait();
            fr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FaireConsultation fc = new FaireConsultation();
            fc.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FaireVirement fv = new FaireVirement();
            fv.Show();
            this.Hide();
        }
    }
}
