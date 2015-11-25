namespace ApplicationGestionCampagne
{
    partial class FrmAjoutCampagne
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNomCampagne = new System.Windows.Forms.TextBox();
            this.txtObjectifCampagne = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblObjectif = new System.Windows.Forms.Label();
            this.lblPublic = new System.Windows.Forms.Label();
            this.lblEmploye = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.cbxPublicCampagne = new System.Windows.Forms.ComboBox();
            this.cbxEmployeCampagne = new System.Windows.Forms.ComboBox();
            this.dtpDateDebutCampagne = new System.Windows.Forms.DateTimePicker();
            this.dteDateFinCampagne = new System.Windows.Forms.DateTimePicker();
            this.btnAjoutCampagne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomCampagne
            // 
            this.txtNomCampagne.Location = new System.Drawing.Point(204, 66);
            this.txtNomCampagne.Name = "txtNomCampagne";
            this.txtNomCampagne.Size = new System.Drawing.Size(100, 20);
            this.txtNomCampagne.TabIndex = 0;
            // 
            // txtObjectifCampagne
            // 
            this.txtObjectifCampagne.Location = new System.Drawing.Point(204, 104);
            this.txtObjectifCampagne.Name = "txtObjectifCampagne";
            this.txtObjectifCampagne.Size = new System.Drawing.Size(100, 20);
            this.txtObjectifCampagne.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(54, 75);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(108, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom de la campagne";
            // 
            // lblObjectif
            // 
            this.lblObjectif.AutoSize = true;
            this.lblObjectif.Location = new System.Drawing.Point(54, 111);
            this.lblObjectif.Name = "lblObjectif";
            this.lblObjectif.Size = new System.Drawing.Size(43, 13);
            this.lblObjectif.TabIndex = 3;
            this.lblObjectif.Text = "Objectif";
            // 
            // lblPublic
            // 
            this.lblPublic.AutoSize = true;
            this.lblPublic.Location = new System.Drawing.Point(54, 146);
            this.lblPublic.Name = "lblPublic";
            this.lblPublic.Size = new System.Drawing.Size(36, 13);
            this.lblPublic.TabIndex = 4;
            this.lblPublic.Text = "Public";
            // 
            // lblEmploye
            // 
            this.lblEmploye.AutoSize = true;
            this.lblEmploye.Location = new System.Drawing.Point(54, 184);
            this.lblEmploye.Name = "lblEmploye";
            this.lblEmploye.Size = new System.Drawing.Size(86, 13);
            this.lblEmploye.TabIndex = 5;
            this.lblEmploye.Text = "Employe assigné";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(430, 69);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(75, 13);
            this.lblDateDebut.TabIndex = 8;
            this.lblDateDebut.Text = "Date de début";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(430, 158);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(59, 13);
            this.lblDateFin.TabIndex = 9;
            this.lblDateFin.Text = "Date de fin";
            // 
            // cbxPublicCampagne
            // 
            this.cbxPublicCampagne.FormattingEnabled = true;
            this.cbxPublicCampagne.Location = new System.Drawing.Point(205, 150);
            this.cbxPublicCampagne.Name = "cbxPublicCampagne";
            this.cbxPublicCampagne.Size = new System.Drawing.Size(159, 21);
            this.cbxPublicCampagne.TabIndex = 10;
            // 
            // cbxEmployeCampagne
            // 
            this.cbxEmployeCampagne.FormattingEnabled = true;
            this.cbxEmployeCampagne.Location = new System.Drawing.Point(205, 184);
            this.cbxEmployeCampagne.Name = "cbxEmployeCampagne";
            this.cbxEmployeCampagne.Size = new System.Drawing.Size(159, 21);
            this.cbxEmployeCampagne.TabIndex = 11;
            // 
            // dtpDateDebutCampagne
            // 
            this.dtpDateDebutCampagne.Location = new System.Drawing.Point(433, 101);
            this.dtpDateDebutCampagne.Name = "dtpDateDebutCampagne";
            this.dtpDateDebutCampagne.Size = new System.Drawing.Size(200, 20);
            this.dtpDateDebutCampagne.TabIndex = 14;
            // 
            // dteDateFinCampagne
            // 
            this.dteDateFinCampagne.Location = new System.Drawing.Point(433, 185);
            this.dteDateFinCampagne.Name = "dteDateFinCampagne";
            this.dteDateFinCampagne.Size = new System.Drawing.Size(200, 20);
            this.dteDateFinCampagne.TabIndex = 15;
            // 
            // btnAjoutCampagne
            // 
            this.btnAjoutCampagne.Location = new System.Drawing.Point(377, 398);
            this.btnAjoutCampagne.Name = "btnAjoutCampagne";
            this.btnAjoutCampagne.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutCampagne.TabIndex = 16;
            this.btnAjoutCampagne.Text = "Enregistrer";
            this.btnAjoutCampagne.UseVisualStyleBackColor = true;
            // 
            // FrmAjoutCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 521);
            this.Controls.Add(this.btnAjoutCampagne);
            this.Controls.Add(this.dteDateFinCampagne);
            this.Controls.Add(this.dtpDateDebutCampagne);
            this.Controls.Add(this.cbxEmployeCampagne);
            this.Controls.Add(this.cbxPublicCampagne);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.lblEmploye);
            this.Controls.Add(this.lblPublic);
            this.Controls.Add(this.lblObjectif);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtObjectifCampagne);
            this.Controls.Add(this.txtNomCampagne);
            this.Name = "FrmAjoutCampagne";
            this.Text = "Formulaire d\'ajout de campagne";
            this.Load += new System.EventHandler(this.FrmAjoutCampagne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomCampagne;
        private System.Windows.Forms.TextBox txtObjectifCampagne;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblObjectif;
        private System.Windows.Forms.Label lblPublic;
        private System.Windows.Forms.Label lblEmploye;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.ComboBox cbxPublicCampagne;
        private System.Windows.Forms.ComboBox cbxEmployeCampagne;
        private System.Windows.Forms.DateTimePicker dtpDateDebutCampagne;
        private System.Windows.Forms.DateTimePicker dteDateFinCampagne;
        private System.Windows.Forms.Button btnAjoutCampagne;
    }
}

