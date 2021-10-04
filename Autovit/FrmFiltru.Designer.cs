namespace Autovit
{
    partial class FrmFiltru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiltru));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCombustibil = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboPretMin = new System.Windows.Forms.ComboBox();
            this.cboPretMax = new System.Windows.Forms.ComboBox();
            this.cboAnMin = new System.Windows.Forms.ComboBox();
            this.cboAnMax = new System.Windows.Forms.ComboBox();
            this.s = new System.Windows.Forms.ComboBox();
            this.cboKmMax = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Anul fabricatiei cautat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(483, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kilometraj cautat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(388, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "Introduceti combustibilul cautat:";
            // 
            // cboCombustibil
            // 
            this.cboCombustibil.FormattingEnabled = true;
            this.cboCombustibil.Items.AddRange(new object[] {
            "diesel",
            "benzina",
            "electric",
            "hibrid"});
            this.cboCombustibil.Location = new System.Drawing.Point(17, 55);
            this.cboCombustibil.Name = "cboCombustibil";
            this.cboCombustibil.Size = new System.Drawing.Size(335, 28);
            this.cboCombustibil.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 30);
            this.label6.TabIndex = 18;
            this.label6.Text = "Introduceti pretul cautat:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(240, 234);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 60);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Cautati";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(457, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 60);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cboPretMin
            // 
            this.cboPretMin.FormattingEnabled = true;
            this.cboPretMin.Items.AddRange(new object[] {
            "2000",
            "3000",
            "5000",
            "10000",
            "20000",
            "30000",
            "40000",
            "50000",
            "60000",
            "80000",
            "100000",
            "200000"});
            this.cboPretMin.Location = new System.Drawing.Point(17, 170);
            this.cboPretMin.Name = "cboPretMin";
            this.cboPretMin.Size = new System.Drawing.Size(129, 28);
            this.cboPretMin.TabIndex = 22;
            // 
            // cboPretMax
            // 
            this.cboPretMax.FormattingEnabled = true;
            this.cboPretMax.Items.AddRange(new object[] {
            "2000",
            "3000",
            "5000",
            "10000",
            "20000",
            "30000",
            "40000",
            "50000",
            "60000",
            "80000",
            "100000",
            "200000"});
            this.cboPretMax.Location = new System.Drawing.Point(184, 170);
            this.cboPretMax.Name = "cboPretMax";
            this.cboPretMax.Size = new System.Drawing.Size(129, 28);
            this.cboPretMax.TabIndex = 23;
            // 
            // cboAnMin
            // 
            this.cboAnMin.FormattingEnabled = true;
            this.cboAnMin.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990"});
            this.cboAnMin.Location = new System.Drawing.Point(488, 55);
            this.cboAnMin.Name = "cboAnMin";
            this.cboAnMin.Size = new System.Drawing.Size(129, 28);
            this.cboAnMin.TabIndex = 24;
            // 
            // cboAnMax
            // 
            this.cboAnMax.FormattingEnabled = true;
            this.cboAnMax.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990"});
            this.cboAnMax.Location = new System.Drawing.Point(662, 55);
            this.cboAnMax.Name = "cboAnMax";
            this.cboAnMax.Size = new System.Drawing.Size(129, 28);
            this.cboAnMax.TabIndex = 25;
            // 
            // s
            // 
            this.s.FormattingEnabled = true;
            this.s.Items.AddRange(new object[] {
            "5000",
            "10000",
            "20000",
            "35000",
            "50000",
            "75000",
            "100000",
            "125000",
            "150000",
            "200000",
            "250000",
            "300000",
            "350000",
            "400000"});
            this.s.Location = new System.Drawing.Point(488, 170);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(129, 28);
            this.s.TabIndex = 26;
            // 
            // cboKmMax
            // 
            this.cboKmMax.FormattingEnabled = true;
            this.cboKmMax.Items.AddRange(new object[] {
            "5000",
            "10000",
            "20000",
            "35000",
            "50000",
            "75000",
            "100000",
            "125000",
            "150000",
            "200000",
            "250000",
            "300000",
            "350000",
            "400000"});
            this.cboKmMax.Location = new System.Drawing.Point(662, 170);
            this.cboKmMax.Name = "cboKmMax";
            this.cboKmMax.Size = new System.Drawing.Size(129, 28);
            this.cboKmMax.TabIndex = 27;
            // 
            // FrmFiltru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 326);
            this.Controls.Add(this.cboKmMax);
            this.Controls.Add(this.s);
            this.Controls.Add(this.cboAnMax);
            this.Controls.Add(this.cboAnMin);
            this.Controls.Add(this.cboPretMax);
            this.Controls.Add(this.cboPretMin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboCombustibil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFiltru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCombustibil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboPretMin;
        private System.Windows.Forms.ComboBox cboPretMax;
        private System.Windows.Forms.ComboBox cboAnMin;
        private System.Windows.Forms.ComboBox cboAnMax;
        private System.Windows.Forms.ComboBox s;
        private System.Windows.Forms.ComboBox cboKmMax;
    }
}