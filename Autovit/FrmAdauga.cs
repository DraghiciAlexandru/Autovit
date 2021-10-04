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
    public partial class FrmAdauga : Form
    {
        public FrmAdauga()
        {
            InitializeComponent();
        }

        private void FrmAdauga_Load(object sender, EventArgs e)
        {
            lblIntructiuni1.Visible = false;
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            if (parc.isValid(txtMarca))
            {
                lblIntructiuni1.Visible = false;
            }
            else
                lblIntructiuni1.Visible = true;
        }

        bool isComplete()
        {
            if (txtMarca.Text != null && txtModel.Text != null && txtComb.Text != null && txtAn.Text != null && txtKm.Text != null && txtPret.Text != null)
                return true;
            MessageBox.Show("Completati toate datele dumneavoastra", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return false;
        }

        bool isValid()
        {
            ParcAuto parc = new ParcAuto();
            if(!parc.isPret(txtPret.Text))
            {
                MessageBox.Show("Pretul nu este valid", "", MessageBoxButtons.OK);
                txtPret.Text = "";
                txtPret.Focus();
                return false;
            }
            else if(!parc.isAn(txtAn.Text))
            {
                MessageBox.Show("Anul nu este valid", "", MessageBoxButtons.OK);
                txtAn.Text = "";
                txtAn.Focus();
                return false;
            }
            else if(!parc.isKm(txtKm.Text))
            {
                MessageBox.Show("Kilometrajul nu este valid", "", MessageBoxButtons.OK);
                txtKm.Text = "";
                txtKm.Focus();
                return false;
            }
            return true;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if(isComplete()&isValid())
            {
                ParcAuto parc = new ParcAuto();
                Masina masina = new Masina();
                masina.Marca = txtMarca.Text;
                masina.Model = txtModel.Text;
                masina.An = int.Parse(txtAn.Text);
                masina.Km = long.Parse(txtKm.Text);
                masina.Combustibil = txtComb.Text;
                masina.Pret = long.Parse(txtPret.Text);
                masina.Localitate = txtLocalitate.Text;
                masina.DateProprietar = txtDate.Text;
                parc.add(masina);
                parc.saveFile();
                this.Close();
            }
        }

        private void txtPret_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
