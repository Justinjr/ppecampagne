namespace ApplicationGestionCampagne
{
    partial class frmAjoutArtiste
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
            this.lstCourantArtiste = new System.Windows.Forms.ListBox();
            this.lblNomArtiste = new System.Windows.Forms.Label();
            this.lblSiteWeb = new System.Windows.Forms.Label();
            this.lblCourant = new System.Windows.Forms.Label();
            this.lblTitreAjoutArtiste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomArtiste
            // 
            this.txtNomArtiste.Location = new System.Drawing.Point(137, 116);
            this.txtNomArtiste.Name = "txtNomArtiste";
            this.txtNomArtiste.Size = new System.Drawing.Size(123, 20);
            this.txtNomArtiste.TabIndex = 0;
            // 
            // txtSiteWeb
            // 
            this.txtSiteWeb.Location = new System.Drawing.Point(137, 152);
            this.txtSiteWeb.Name = "txtSiteWeb";
            this.txtSiteWeb.Size = new System.Drawing.Size(123, 20);
            this.txtSiteWeb.TabIndex = 1;
            // 
            // lstCourantArtiste
            // 
            this.lstCourantArtiste.FormattingEnabled = true;
            this.lstCourantArtiste.Location = new System.Drawing.Point(137, 188);
            this.lstCourantArtiste.Name = "lstCourantArtiste";
            this.lstCourantArtiste.Size = new System.Drawing.Size(123, 30);
            this.lstCourantArtiste.TabIndex = 2;
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
            this.lblTitreAjoutArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreAjoutArtiste.Location = new System.Drawing.Point(109, 56);
            this.lblTitreAjoutArtiste.Name = "lblTitreAjoutArtiste";
            this.lblTitreAjoutArtiste.Size = new System.Drawing.Size(151, 24);
            this.lblTitreAjoutArtiste.TabIndex = 6;
            this.lblTitreAjoutArtiste.Text = "Ajout d\'un Artiste";
            // 
            // frmAjoutArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 319);
            this.Controls.Add(this.lblTitreAjoutArtiste);
            this.Controls.Add(this.lblCourant);
            this.Controls.Add(this.lblSiteWeb);
            this.Controls.Add(this.lblNomArtiste);
            this.Controls.Add(this.lstCourantArtiste);
            this.Controls.Add(this.txtSiteWeb);
            this.Controls.Add(this.txtNomArtiste);
            this.Name = "frmAjoutArtiste";
            this.Text = "frmAjoutArtiste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomArtiste;
        private System.Windows.Forms.TextBox txtSiteWeb;
        private System.Windows.Forms.ListBox lstCourantArtiste;
        private System.Windows.Forms.Label lblNomArtiste;
        private System.Windows.Forms.Label lblSiteWeb;
        private System.Windows.Forms.Label lblCourant;
        private System.Windows.Forms.Label lblTitreAjoutArtiste;
    }
}