﻿namespace ApplicationGestionCampagne
{
    partial class FrmAjoutArtiste
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
            this.txtNomArtiste = new System.Windows.Forms.TextBox();
            this.txtSiteWeb = new System.Windows.Forms.TextBox();
            this.lblNomArtiste = new System.Windows.Forms.Label();
            this.lblSiteWeb = new System.Windows.Forms.Label();
            this.lblCourant = new System.Windows.Forms.Label();
            this.lblTitreAjoutArtiste = new System.Windows.Forms.Label();
            this.btnEnregArtiste = new System.Windows.Forms.Button();
            this.cbxCourantArtiste = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNomArtiste
            // 
            this.txtNomArtiste.Location = new System.Drawing.Point(137, 116);
            this.txtNomArtiste.Name = "txtNomArtiste";
            this.txtNomArtiste.Size = new System.Drawing.Size(123, 20);
            this.txtNomArtiste.TabIndex = 0;
            this.txtNomArtiste.TextChanged += new System.EventHandler(this.txtNomArtiste_TextChanged);
            // 
            // txtSiteWeb
            // 
            this.txtSiteWeb.Location = new System.Drawing.Point(137, 152);
            this.txtSiteWeb.Name = "txtSiteWeb";
            this.txtSiteWeb.Size = new System.Drawing.Size(123, 20);
            this.txtSiteWeb.TabIndex = 1;
            // 
            // lblNomArtiste
            // 
            this.lblNomArtiste.AutoSize = true;
            this.lblNomArtiste.Location = new System.Drawing.Point(22, 116);
            this.lblNomArtiste.Name = "lblNomArtiste";
            this.lblNomArtiste.Size = new System.Drawing.Size(83, 13);
            this.lblNomArtiste.TabIndex = 3;
            this.lblNomArtiste.Text = "Nom de L\'artiste";
            this.lblNomArtiste.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSiteWeb
            // 
            this.lblSiteWeb.AutoSize = true;
            this.lblSiteWeb.Location = new System.Drawing.Point(22, 155);
            this.lblSiteWeb.Name = "lblSiteWeb";
            this.lblSiteWeb.Size = new System.Drawing.Size(101, 13);
            this.lblSiteWeb.TabIndex = 4;
            this.lblSiteWeb.Text = "Site Web de l\'artiste";
            // 
            // lblCourant
            // 
            this.lblCourant.AutoSize = true;
            this.lblCourant.Location = new System.Drawing.Point(22, 188);
            this.lblCourant.Name = "lblCourant";
            this.lblCourant.Size = new System.Drawing.Size(94, 13);
            this.lblCourant.TabIndex = 5;
            this.lblCourant.Text = "Courant de l\'artiste";
            // 
            // lblTitreAjoutArtiste
            // 
            this.lblTitreAjoutArtiste.AutoSize = true;
            this.lblTitreAjoutArtiste.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreAjoutArtiste.Location = new System.Drawing.Point(98, 56);
            this.lblTitreAjoutArtiste.Name = "lblTitreAjoutArtiste";
            this.lblTitreAjoutArtiste.Size = new System.Drawing.Size(162, 26);
            this.lblTitreAjoutArtiste.TabIndex = 6;
            this.lblTitreAjoutArtiste.Text = "Ajout d\'un Artiste";
            // 
            // btnEnregArtiste
            // 
            this.btnEnregArtiste.Location = new System.Drawing.Point(113, 240);
            this.btnEnregArtiste.Name = "btnEnregArtiste";
            this.btnEnregArtiste.Size = new System.Drawing.Size(99, 39);
            this.btnEnregArtiste.TabIndex = 7;
            this.btnEnregArtiste.Text = "Enregistrer";
            this.btnEnregArtiste.UseVisualStyleBackColor = true;
            this.btnEnregArtiste.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxCourantArtiste
            // 
            this.cbxCourantArtiste.FormattingEnabled = true;
            this.cbxCourantArtiste.Location = new System.Drawing.Point(137, 185);
            this.cbxCourantArtiste.Name = "cbxCourantArtiste";
            this.cbxCourantArtiste.Size = new System.Drawing.Size(123, 21);
            this.cbxCourantArtiste.TabIndex = 8;
            this.cbxCourantArtiste.SelectedIndexChanged += new System.EventHandler(this.cbxCourantArtiste_SelectedIndexChanged);
            // 
            // FrmAjoutArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 319);
            this.Controls.Add(this.cbxCourantArtiste);
            this.Controls.Add(this.btnEnregArtiste);
            this.Controls.Add(this.lblTitreAjoutArtiste);
            this.Controls.Add(this.lblCourant);
            this.Controls.Add(this.lblSiteWeb);
            this.Controls.Add(this.lblNomArtiste);
            this.Controls.Add(this.txtSiteWeb);
            this.Controls.Add(this.txtNomArtiste);
            this.Name = "FrmAjoutArtiste";
            this.Text = "frmAjoutArtiste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomArtiste;
        private System.Windows.Forms.TextBox txtSiteWeb;
        private System.Windows.Forms.Label lblNomArtiste;
        private System.Windows.Forms.Label lblSiteWeb;
        private System.Windows.Forms.Label lblCourant;
        private System.Windows.Forms.Label lblTitreAjoutArtiste;
        private System.Windows.Forms.Button btnEnregArtiste;
        private System.Windows.Forms.ComboBox cbxCourantArtiste;
    }
}