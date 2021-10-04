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
    public partial class FrmCumpara : Form
    {
        public FrmCumpara()
        {
            InitializeComponent();
        }

        public String raspuns = "no";

        private void FrmCumpara_Load(object sender, EventArgs e)
        {

        }

        bool isComplete()
        {
            if (txtPret.Text != "")
                return true;
            MessageBox.Show("Completati pretul", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        bool isValid()
        {
            ParcAuto parc = new ParcAuto();
            if (parc.isPret(txtPret.Text.ToString()))
                return true;
            MessageBox.Show("Pretul nu este valid", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void txtPret_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(isComplete()&&isValid())
            {
                raspuns = "ofera";
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
