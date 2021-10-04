namespace Autovit
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tbrMenu = new System.Windows.Forms.ToolStrip();
            this.btnMarca = new System.Windows.Forms.ToolStripButton();
            this.btnModel = new System.Windows.Forms.ToolStripButton();
            this.btnAni = new System.Windows.Forms.ToolStripButton();
            this.btnKm = new System.Windows.Forms.ToolStripButton();
            this.btnComb = new System.Windows.Forms.ToolStripButton();
            this.btnPret = new System.Windows.Forms.ToolStripButton();
            this.btnAdauga = new System.Windows.Forms.ToolStripButton();
            this.lstMasini = new System.Windows.Forms.ListView();
            this.btnFiltru = new System.Windows.Forms.ToolStripButton();
            this.tbrMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbrMenu
            // 
            this.tbrMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tbrMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFiltru,
            this.btnMarca,
            this.btnModel,
            this.btnAni,
            this.btnKm,
            this.btnComb,
            this.btnPret,
            this.btnAdauga});
            this.tbrMenu.Location = new System.Drawing.Point(0, 0);
            this.tbrMenu.Name = "tbrMenu";
            this.tbrMenu.Size = new System.Drawing.Size(1346, 33);
            this.tbrMenu.TabIndex = 2;
            this.tbrMenu.Text = "toolStrip1";
            // 
            // btnMarca
            // 
            this.btnMarca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnMarca.Image")));
            this.btnMarca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(34, 28);
            this.btnMarca.Text = "Filtru Marca";
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // btnModel
            // 
            this.btnModel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModel.Image = ((System.Drawing.Image)(resources.GetObject("btnModel.Image")));
            this.btnModel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(34, 28);
            this.btnModel.Text = "Filtru model";
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // btnAni
            // 
            this.btnAni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAni.Image = ((System.Drawing.Image)(resources.GetObject("btnAni.Image")));
            this.btnAni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAni.Name = "btnAni";
            this.btnAni.Size = new System.Drawing.Size(34, 28);
            this.btnAni.Text = "Filtru Ani";
            this.btnAni.Click += new System.EventHandler(this.btnAni_Click);
            // 
            // btnKm
            // 
            this.btnKm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKm.Image = ((System.Drawing.Image)(resources.GetObject("btnKm.Image")));
            this.btnKm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKm.Name = "btnKm";
            this.btnKm.Size = new System.Drawing.Size(34, 28);
            this.btnKm.Text = "Filtru km";
            this.btnKm.Click += new System.EventHandler(this.btnKm_Click);
            // 
            // btnComb
            // 
            this.btnComb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnComb.Image = ((System.Drawing.Image)(resources.GetObject("btnComb.Image")));
            this.btnComb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnComb.Name = "btnComb";
            this.btnComb.Size = new System.Drawing.Size(34, 28);
            this.btnComb.Text = "Filtru combustibil";
            this.btnComb.Click += new System.EventHandler(this.btnComb_Click);
            // 
            // btnPret
            // 
            this.btnPret.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPret.Image = ((System.Drawing.Image)(resources.GetObject("btnPret.Image")));
            this.btnPret.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPret.Name = "btnPret";
            this.btnPret.Size = new System.Drawing.Size(34, 28);
            this.btnPret.Text = "Filtru pret";
            this.btnPret.Click += new System.EventHandler(this.btnPret_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdauga.Image = ((System.Drawing.Image)(resources.GetObject("btnAdauga.Image")));
            this.btnAdauga.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(34, 28);
            this.btnAdauga.Text = "Adauga anunt";
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // lstMasini
            // 
            this.lstMasini.BackColor = System.Drawing.SystemColors.GrayText;
            this.lstMasini.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMasini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstMasini.FullRowSelect = true;
            this.lstMasini.GridLines = true;
            this.lstMasini.HideSelection = false;
            this.lstMasini.Location = new System.Drawing.Point(12, 56);
            this.lstMasini.MultiSelect = false;
            this.lstMasini.Name = "lstMasini";
            this.lstMasini.Size = new System.Drawing.Size(1322, 531);
            this.lstMasini.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstMasini.TabIndex = 3;
            this.lstMasini.UseCompatibleStateImageBehavior = false;
            this.lstMasini.View = System.Windows.Forms.View.Details;
            this.lstMasini.SelectedIndexChanged += new System.EventHandler(this.lstMasini_SelectedIndexChanged);
            this.lstMasini.DoubleClick += new System.EventHandler(this.lstMasini_DoubleClick);
            // 
            // btnFiltru
            // 
            this.btnFiltru.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFiltru.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltru.Image")));
            this.btnFiltru.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltru.Name = "btnFiltru";
            this.btnFiltru.Size = new System.Drawing.Size(34, 28);
            this.btnFiltru.Text = "Filtru";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 599);
            this.Controls.Add(this.lstMasini);
            this.Controls.Add(this.tbrMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autovit";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tbrMenu.ResumeLayout(false);
            this.tbrMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tbrMenu;
        private System.Windows.Forms.ListView lstMasini;
        private System.Windows.Forms.ToolStripButton btnMarca;
        private System.Windows.Forms.ToolStripButton btnModel;
        private System.Windows.Forms.ToolStripButton btnAni;
        private System.Windows.Forms.ToolStripButton btnKm;
        private System.Windows.Forms.ToolStripButton btnComb;
        private System.Windows.Forms.ToolStripButton btnPret;
        private System.Windows.Forms.ToolStripButton btnAdauga;
        private System.Windows.Forms.ToolStripButton btnFiltru;
    }
}