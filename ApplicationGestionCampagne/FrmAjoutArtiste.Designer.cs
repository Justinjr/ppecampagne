namespace ApplicationGestionCampagne
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
            this.lstCourantArtiste = new System.Windows.Forms.ListBox();
            this.txtSiteWeb = new System.Windows.Forms.TextBox();
            this.txtNomArtiste = new System.Windows.Forms.TextBox();
            this.btnAjoutArtiste = new System.Windows.Forms.Button();
            this.lblTitreAjoutArtiste = new System.Windows.Forms.Label();
            this.lblCourantDeArtiste = new System.Windows.Forms.Label();
            this.lblSiteWeb = new System.Windows.Forms.Label();
            this.lblArtiste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCourantArtiste
            // 
            this.lstCourantArtiste.FormattingEnabled = true;
            this.lstCourantArtiste.Location = new System.Drawing.Point(157, 165);
            this.lstCourantArtiste.Name = "lstCourantArtiste";
            this.lstCourantArtiste.Size = new System.Drawing.Size(120, 17);
            this.lstCourantArtiste.TabIndex = 15;
            this.lstCourantArtiste.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtSiteWeb
            // 
            this.txtSiteWeb.Location = new System.Drawing.Point(157, 126);
            this.txtSiteWeb.Name = "txtSiteWeb";
            this.txtSiteWeb.Size = new System.Drawing.Size(100, 20);
            this.txtSiteWeb.TabIndex = 14;
            this.txtSiteWeb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNomArtiste
            // 
            this.txtNomArtiste.Location = new System.Drawing.Point(157, 91);
            this.txtNomArtiste.Name = "txtNomArtiste";
            this.txtNomArtiste.Size = new System.Drawing.Size(100, 20);
            this.txtNomArtiste.TabIndex = 13;
            this.txtNomArtiste.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAjoutArtiste
            // 
            this.btnAjoutArtiste.Location = new System.Drawing.Point(157, 214);
            this.btnAjoutArtiste.Name = "btnAjoutArtiste";
            this.btnAjoutArtiste.Size = new System.Drawing.Size(100, 32);
            this.btnAjoutArtiste.TabIndex = 12;
            this.btnAjoutArtiste.Text = "Ajouter un artiste";
            this.btnAjoutArtiste.UseVisualStyleBackColor = true;
            this.btnAjoutArtiste.Click += new System.EventHandler(this.btnAjoutArtiste_Click);
            // 
            // lblTitreAjoutArtiste
            // 
            this.lblTitreAjoutArtiste.AutoSize = true;
            this.lblTitreAjoutArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreAjoutArtiste.Location = new System.Drawing.Point(106, 34);
            this.lblTitreAjoutArtiste.Name = "lblTitreAjoutArtiste";
            this.lblTitreAjoutArtiste.Size = new System.Drawing.Size(171, 24);
            this.lblTitreAjoutArtiste.TabIndex = 11;
            this.lblTitreAjoutArtiste.Text = "Ajouter un Artiste";
            // 
            // lblCourantDeArtiste
            // 
            this.lblCourantDeArtiste.AutoSize = true;
            this.lblCourantDeArtiste.Location = new System.Drawing.Point(41, 165);
            this.lblCourantDeArtiste.Name = "lblCourantDeArtiste";
            this.lblCourantDeArtiste.Size = new System.Drawing.Size(100, 13);
            this.lblCourantDeArtiste.TabIndex = 10;
            this.lblCourantDeArtiste.Text = "Courant de l\'artiste :";
            // 
            // lblSiteWeb
            // 
            this.lblSiteWeb.AutoSize = true;
            this.lblSiteWeb.Location = new System.Drawing.Point(41, 133);
            this.lblSiteWeb.Name = "lblSiteWeb";
            this.lblSiteWeb.Size = new System.Drawing.Size(54, 13);
            this.lblSiteWeb.TabIndex = 9;
            this.lblSiteWeb.Text = "Site web :";
            // 
            // lblArtiste
            // 
            this.lblArtiste.AutoSize = true;
            this.lblArtiste.Location = new System.Drawing.Point(41, 94);
            this.lblArtiste.Name = "lblArtiste";
            this.lblArtiste.Size = new System.Drawing.Size(85, 13);
            this.lblArtiste.TabIndex = 8;
            this.lblArtiste.Text = "Nom de l\'artiste :";
            // 
            // FrmAjoutArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 297);
            this.Controls.Add(this.lstCourantArtiste);
            this.Controls.Add(this.txtSiteWeb);
            this.Controls.Add(this.txtNomArtiste);
            this.Controls.Add(this.btnAjoutArtiste);
            this.Controls.Add(this.lblTitreAjoutArtiste);
            this.Controls.Add(this.lblCourantDeArtiste);
            this.Controls.Add(this.lblSiteWeb);
            this.Controls.Add(this.lblArtiste);
            this.Name = "FrmAjoutArtiste";
            this.Text = "FrmAjoutArtiste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCourantArtiste;
        private System.Windows.Forms.TextBox txtSiteWeb;
        private System.Windows.Forms.TextBox txtNomArtiste;
        private System.Windows.Forms.Button btnAjoutArtiste;
        private System.Windows.Forms.Label lblTitreAjoutArtiste;
        private System.Windows.Forms.Label lblCourantDeArtiste;
        private System.Windows.Forms.Label lblSiteWeb;
        private System.Windows.Forms.Label lblArtiste;
    }
}