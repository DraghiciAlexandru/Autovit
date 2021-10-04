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
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            parc.uploadView(lstMasini);
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            FrmMarca x = new FrmMarca();
            x.ShowDialog();
            if (x.mar != "no")
                parc.marcaView(lstMasini, x.mar.ToLower());
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            FrmModel x = new FrmModel();
            x.ShowDialog();
            if (x.mod != "no")
                parc.modelView(lstMasini, x.mod.ToLower());
        }

        private void aniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            FrmAni x = new FrmAni();
            x.ShowDialog();
            parc.anView(lstMasini, x.prim, x.ultim);
        }

        private void kilometriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            FrmKm x = new FrmKm();
            x.ShowDialog();
            parc.kmView(lstMasini, x.mic, x.mare);
        }

        private void combustibilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            FrmCombustibil x = new FrmCombustibil();
            x.ShowDialog();
            if (x.comb != "no")
                parc.combView(lstMasini, x.comb);
        }

        private void pretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            FrmPret x = new FrmPret();
            x.ShowDialog();
            parc.pretView(lstMasini, x.mic, x.mare);
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            FrmMarca x = new FrmMarca();
            x.ShowDialog();
            if (x.mar != "no")
                parc.marcaView(lstMasini, x.mar.ToLower());
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            FrmModel x = new FrmModel();
            x.ShowDialog();
            if (x.mod != "no")
                parc.modelView(lstMasini, x.mod.ToLower());
        }

        private void btnAni_Click(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            FrmAni x = new FrmAni();
            x.ShowDialog();
            parc.anView(lstMasini, x.prim, x.ultim);
        }

        private void btnKm_Click(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            FrmKm x = new FrmKm();
            x.ShowDialog();
            parc.kmView(lstMasini, x.mic, x.mare);
        }

        private void btnComb_Click(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            FrmCombustibil x = new FrmCombustibil();
            x.ShowDialog();
            if (x.comb != "no")
                parc.combView(lstMasini, x.comb);
        }

        private void btnPret_Click(object sender, EventArgs e)
        {
            ParcAuto parc = new ParcAuto();
            FrmPret x = new FrmPret();
            x.ShowDialog();
            parc.pretView(lstMasini, x.mic, x.mare);
        }

        private void lstMasini_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void schimbariToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adaugaAnuntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdauga x = new FrmAdauga();
            x.ShowDialog();
            ParcAuto parc = new ParcAuto();
            parc.uploadView(lstMasini);
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            FrmAdauga x = new FrmAdauga();
            x.ShowDialog();
            ParcAuto parc = new ParcAuto();
            parc.uploadView(lstMasini);
        }

        private void lstMasini_DoubleClick(object sender, EventArgs e)
        {
            FrmCumpara cumpara = new FrmCumpara();
            cumpara.ShowDialog();
            ParcAuto parc = new ParcAuto();
            parc.uploadView(lstMasini);
            if (cumpara.raspuns == "ofera")
            {
                
            }
        }
    }
}
