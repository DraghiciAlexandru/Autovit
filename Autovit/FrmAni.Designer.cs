namespace Autovit
{
    partial class FrmAni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAni));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrimulAn = new System.Windows.Forms.TextBox();
            this.txtUltimulAn = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Anul fabricatiei: (intre 1990 si 2020)";
            // 
            // txtPrimulAn
            // 
            this.txtPrimulAn.Location = new System.Drawing.Point(86, 117);
            this.txtPrimulAn.Multiline = true;
            this.txtPrimulAn.Name = "txtPrimulAn";
            this.txtPrimulAn.Size = new System.Drawing.Size(182, 36);
            this.txtPrimulAn.TabIndex = 3;
            this.txtPrimulAn.Text = "De la";
            this.txtPrimulAn.Click += new System.EventHandler(this.txtPrimulAn_Click);
            this.txtPrimulAn.TextChanged += new System.EventHandler(this.txtPrimulAn_TextChanged);
            // 
            // txtUltimulAn
            // 
            this.txtUltimulAn.Location = new System.Drawing.Point(308, 117);
            this.txtUltimulAn.Multiline = true;
            this.txtUltimulAn.Name = "txtUltimulAn";
            this.txtUltimulAn.Size = new System.Drawing.Size(182, 36);
            this.txtUltimulAn.TabIndex = 4;
            this.txtUltimulAn.Text = "Pana la";
            this.txtUltimulAn.Click += new System.EventHandler(this.txtUltimulAn_Click);
            this.txtUltimulAn.TextChanged += new System.EventHandler(this.txtUltimulAn_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(108, 180);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 60);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Cautati";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(308, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 60);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 294);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtUltimulAn);
            this.Controls.Add(this.txtPrimulAn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anul fabricatiei";
            this.Load += new System.EventHandler(this.FrmAni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrimulAn;
        private System.Windows.Forms.TextBox txtUltimulAn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
    }
}