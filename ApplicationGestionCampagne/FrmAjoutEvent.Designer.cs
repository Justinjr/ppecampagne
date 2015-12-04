namespace ApplicationGestionCampagne
{
    partial class FrmAjoutEvent
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
            this.lblErreur = new System.Windows.Forms.Label();
            this.btnAjoutEvent = new System.Windows.Forms.Button();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.cbxVille = new System.Windows.Forms.ComboBox();
            this.cbxCampagne = new System.Windows.Forms.ComboBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblTheme = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblCampagne = new System.Windows.Forms.Label();
            this.cbxTheme = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Location = new System.Drawing.Point(490, 429);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(77, 13);
            this.lblErreur.TabIndex = 23;
            this.lblErreur.Text = "en cas d\'erreur";
            // 
            // btnAjoutEvent
            // 
            this.btnAjoutEvent.Location = new System.Drawing.Point(239, 398);
            this.btnAjoutEvent.Name = "btnAjoutEvent";
            this.btnAjoutEvent.Size = new System.Drawing.Size(153, 44);
            this.btnAjoutEvent.TabIndex = 22;
            this.btnAjoutEvent.Text = "Ajouter";
            this.btnAjoutEvent.UseVisualStyleBackColor = true;
            this.btnAjoutEvent.Click += new System.EventHandler(this.btnAjoutEvent_Click);
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(239, 192);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFin.TabIndex = 21;
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(239, 147);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDateDebut.TabIndex = 20;
            // 
            // cbxVille
            // 
            this.cbxVille.FormattingEnabled = true;
            this.cbxVille.Location = new System.Drawing.Point(239, 251);
            this.cbxVille.Name = "cbxVille";
            this.cbxVille.Size = new System.Drawing.Size(200, 21);
            this.cbxVille.TabIndex = 19;
            // 
            // cbxCampagne
            // 
            this.cbxCampagne.FormattingEnabled = true;
            this.cbxCampagne.Location = new System.Drawing.Point(239, 100);
            this.cbxCampagne.Name = "cbxCampagne";
            this.cbxCampagne.Size = new System.Drawing.Size(200, 21);
            this.cbxCampagne.TabIndex = 17;
            this.cbxCampagne.SelectedIndexChanged += new System.EventHandler(this.cbxCampagne_SelectedIndexChanged);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(41, 251);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(26, 13);
            this.lblVille.TabIndex = 16;
            this.lblVille.Text = "Ville";
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(41, 305);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(40, 13);
            this.lblTheme.TabIndex = 15;
            this.lblTheme.Text = "Thème";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(41, 198);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(59, 13);
            this.lblDateFin.TabIndex = 14;
            this.lblDateFin.Text = "Date de fin";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(41, 147);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(75, 13);
            this.lblDateDebut.TabIndex = 13;
            this.lblDateDebut.Text = "Date de début";
            // 
            // lblCampagne
            // 
            this.lblCampagne.AutoSize = true;
            this.lblCampagne.Location = new System.Drawing.Point(41, 100);
            this.lblCampagne.Name = "lblCampagne";
            this.lblCampagne.Size = new System.Drawing.Size(64, 13);
            this.lblCampagne.TabIndex = 12;
            this.lblCampagne.Text = "Campagne :";
            // 
            // cbxTheme
            // 
            this.cbxTheme.FormattingEnabled = true;
            this.cbxTheme.Location = new System.Drawing.Point(239, 297);
            this.cbxTheme.Name = "cbxTheme";
            this.cbxTheme.Size = new System.Drawing.Size(200, 21);
            this.cbxTheme.TabIndex = 24;
            // 
            // FrmAjoutEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 542);
            this.Controls.Add(this.cbxTheme);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.btnAjoutEvent);
            this.Controls.Add(this.dtpDateFin);
            this.Controls.Add(this.dtpDateDebut);
            this.Controls.Add(this.cbxVille);
            this.Controls.Add(this.cbxCampagne);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.lblCampagne);
            this.Name = "FrmAjoutEvent";
            this.Text = "Formulaire ajout d\'évenements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.Button btnAjoutEvent;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.ComboBox cbxVille;
        private System.Windows.Forms.ComboBox cbxCampagne;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblCampagne;
        private System.Windows.Forms.ComboBox cbxTheme;
    }
}