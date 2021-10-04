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
    public partial class FrmPret : Form
    {
        public FrmPret()
        {
            InitializeComponent();
        }

        public long mic = 0;
        public long mare = 800000;

        private void FrmPret_Load(object sender, EventArgs e)
        {

        }

        private void s_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(txtPretMic.Text, out mic))
                mic = long.Parse(txtPretMic.Text);
        }

        private void txtPretMare_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(txtPretMare.Text, out mare))
                mare = long.Parse(txtPretMare.Text);
        }

        private void txtPretMic_Click(object sender, EventArgs e)
        {
            if (txtPretMic.Text == "De la")
                txtPretMic.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPretMare_Click(object sender, EventArgs e)
        {
            if (txtPretMare.Text == "Pana la")
                txtPretMare.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            int ok = 2;
            if (mic != 0)
            {
                if (!parc.isPret(mic.ToString()))
                {
                    ok--;
                    txtPretMic.Text = "";
                    txtPretMic.Focus();
                    MessageBox.Show("Unul dintre preturi introduse nu este valid", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (mare != 400000)
            {
                if (!parc.isPret(mare.ToString()))
                {
                    ok--;
                    txtPretMare.Text = "";
                    txtPretMare.Focus();
                    MessageBox.Show("Unul dintre preturi introduse nu este valid", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if(mic>mare)
            {
                ok--;
                txtPretMic.Text = "De la";
                mic = 0;
            }
            if (ok == 2)
                this.Close();
        }
    }
}
