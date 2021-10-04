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
    public partial class FrmModel : Form
    {
        public FrmModel()
        {
            InitializeComponent();
        }

        public String mod = "no";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            if (parc.isModel(txtModel.Text.ToLower()))
            {
                mod = txtModel.Text;
                this.Close();
            }
            else
                MessageBox.Show("Acest model nu exista sau sunt 0 masini de vanzare cu acest model", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmModel_Load(object sender, EventArgs e)
        {

        }
    }
}
