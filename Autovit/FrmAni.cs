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
    public partial class FrmAni : Form
    {
        public FrmAni()
        {
            InitializeComponent();
        }

        public int prim = 0;
        public int ultim = 2021;

        private void txtPrimulAn_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtPrimulAn.Text, out prim))
                prim = int.Parse(txtPrimulAn.Text);
        }

        private void txtPrimulAn_Click(object sender, EventArgs e)
        {
            if (txtPrimulAn.Text == "De la")
                txtPrimulAn.Text = "";
        }

        private void txtUltimulAn_Click(object sender, EventArgs e)
        {
            if (txtUltimulAn.Text == "Pana la")
                txtUltimulAn.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            int ok = 2;
            if (prim != 0)
            {
                if (!parc.isAn(prim.ToString()))
                {
                    ok--;
                    txtPrimulAn.Text = "";
                    txtPrimulAn.Focus();
                    MessageBox.Show("Unul dintre ani introdusi nu este valid", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if(ultim!=2021)
            {
                if (!parc.isAn(ultim.ToString()))
                {
                    ok--;
                    txtUltimulAn.Text = "";
                    txtUltimulAn.Focus();
                    MessageBox.Show("Unul dintre ani introdusi nu este valid", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (prim > ultim)
            {
                ok--;
                txtPrimulAn.Text = "De la";
                prim = 0;
            }
            if (ok == 2)
                this.Close();
        }

        private void txtUltimulAn_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtUltimulAn.Text, out ultim))
                ultim = int.Parse(txtUltimulAn.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAni_Load(object sender, EventArgs e)
        {

        }
    }
}
