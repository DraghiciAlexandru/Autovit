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
    public partial class FrmMarca : Form
    {
        public FrmMarca()
        {
            InitializeComponent();
            lblIntructiuni.Visible = false;
        }

        public String mar = "no";

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            if (parc.isValid(txtMarca))
            {
                lblIntructiuni.Visible = false;
            }
            else
                lblIntructiuni.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            if (parc.isMarca(txtMarca.Text.ToLower()))
            {
                mar = txtMarca.Text;
                this.Close();
            }
            else
                MessageBox.Show("Aceasta marca nu exista sau sunt 0 masini de vanzare cu aceasta marca", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
