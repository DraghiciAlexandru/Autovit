using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autovit
{
    public partial class FrmKm : Form
    {
        public FrmKm()
        {
            InitializeComponent();
        }

        public long mic = 0;
        public long mare = 400000;



        private void FrmKm_Load(object sender, EventArgs e)
        {

        }

        private void txtKm1_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(txtKm1.Text, out mic))
                mic = long.Parse(txtKm1.Text);
        }

        private void txtKm2_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(txtKm2.Text, out mare))
                mare = long.Parse(txtKm2.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            int ok = 2;
            if (mic != 0)
            {
                if (!parc.isKm(mic.ToString()))
                {
                    ok--;
                    txtKm1.Text = "";
                    txtKm1.Focus();
                    MessageBox.Show("Unul dintre km introdusi nu este valid", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (mare != 400000)
            {
                if (!parc.isKm(mare.ToString()))
                {
                    ok--;
                    txtKm2.Text = "";
                    txtKm2.Focus();
                    MessageBox.Show("Unul dintre km introdusi nu este valid", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (mic > mare)
            {
                ok--;
                txtKm1.Text = "De la";
                mic = 0;
            }
            if (ok == 2)
                this.Close();
        }

        private void txtKm1_Click(object sender, EventArgs e)
        {
            if (txtKm1.Text == "De la")
                txtKm1.Text = "";
        }

        private void txtKm2_Click(object sender, EventArgs e)
        {
            if (txtKm2.Text == "Pana la")
                txtKm2.Text = "";
        }
    }
}
