namespace Autovit
{
    partial class FrmAdauga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdauga));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblIntructiuni1 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLocalitate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduceti marca masinii:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(17, 77);
            this.txtMarca.Multiline = true;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(249, 36);
            this.txtMarca.TabIndex = 2;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // lblIntructiuni1
            // 
            this.lblIntructiuni1.AutoSize = true;
            this.lblIntructiuni1.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntructiuni1.Location = new System.Drawing.Point(306, 65);
            this.lblIntructiuni1.Name = "lblIntructiuni1";
            this.lblIntructiuni1.Size = new System.Drawing.Size(215, 48);
            this.lblIntructiuni1.TabIndex = 3;
            this.lblIntructiuni1.Text = "In loc de spatiu folositi\r\ncaracterul \"_\"";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Image = ((System.Drawing.Image)(resources.GetObject("btnAdauga.Image")));
            this.btnAdauga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdauga.Location = new System.Drawing.Point(310, 446);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(160, 60);
            this.btnAdauga.TabIndex = 4;
            this.btnAdauga.Text = "Adaugati";
            this.btnAdauga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(510, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 60);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Introduceti modelul masinii:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(17, 176);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(249, 36);
            this.txtModel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Introduceti anul de fabricatie al masinii:";
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(17, 275);
            this.txtAn.Multiline = true;
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(249, 36);
            this.txtAn.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Introduceti kilometrajul masinii:";
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(17, 376);
            this.txtKm.Multiline = true;
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(249, 36);
            this.txtKm.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(550, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(392, 60);
            this.label5.TabIndex = 12;
            this.label5.Text = "Introduceti combustibilul folosit \r\nde masina:";
            // 
            // txtComb
            // 
            this.txtComb.Location = new System.Drawing.Point(555, 77);
            this.txtComb.Multiline = true;
            this.txtComb.Name = "txtComb";
            this.txtComb.Size = new System.Drawing.Size(249, 36);
            this.txtComb.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(550, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Introduceti pretul cerut:";
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(555, 176);
            this.txtPret.Multiline = true;
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(249, 36);
            this.txtPret.TabIndex = 15;
            this.txtPret.TextChanged += new System.EventHandler(this.txtPret_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(550, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(362, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "Introduceti localitatea voastra:";
            // 
            // txtLocalitate
            // 
            this.txtLocalitate.Location = new System.Drawing.Point(555, 275);
            this.txtLocalitate.Multiline = true;
            this.txtLocalitate.Name = "txtLocalitate";
            this.txtLocalitate.Size = new System.Drawing.Size(249, 36);
            this.txtLocalitate.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(550, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(308, 30);
            this.label8.TabIndex = 18;
            this.label8.Text = "Introduceti datele voastre:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(555, 376);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(249, 36);
            this.txtDate.TabIndex = 19;
            // 
            // FrmAdauga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 522);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLocalitate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtComb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lblIntructiuni1);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmAdauga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adauga anunt";
            this.Load += new System.EventHandler(this.FrmAdauga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblIntructiuni1;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLocalitate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDate;
    }
}