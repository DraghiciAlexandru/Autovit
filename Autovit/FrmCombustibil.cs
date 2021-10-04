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
    public partial class FrmCombustibil : Form
    {
        public FrmCombustibil()
        {
            InitializeComponent();
        }

        public String comb = "no";

        private void FrmCombustibil_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            if (parc.isCombustibil(txtCombustibil.Text.ToLower()))
            {
                comb = txtCombustibil.Text.ToLower();
                this.Close();
            }
            else
                MessageBox.Show("Acest combustibil nu exista sau sunt 0 masini de vanzare cu acesta", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
