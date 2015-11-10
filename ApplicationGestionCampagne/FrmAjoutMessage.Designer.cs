namespace ApplicationGestionCampagne
{
    partial class FrmAjoutMessage
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.cbxCategorieVip = new System.Windows.Forms.ComboBox();
            this.cbxEvenement = new System.Windows.Forms.ComboBox();
            this.cbxCampagne = new System.Windows.Forms.ComboBox();
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
            this.btnAjoutMessage = new System.Windows.Forms.Button();
            this.lblCategorieVip = new System.Windows.Forms.Label();
            this.lblEvenement = new System.Windows.Forms.Label();
            this.lblCampagne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(121, 185);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(56, 13);
            this.lblMessage.TabIndex = 17;
            this.lblMessage.Text = "Message :";
            // 
            // cbxCategorieVip
            // 
            this.cbxCategorieVip.FormattingEnabled = true;
            this.cbxCategorieVip.Location = new System.Drawing.Point(264, 109);
            this.cbxCategorieVip.Name = "cbxCategorieVip";
            this.cbxCategorieVip.Size = new System.Drawing.Size(121, 21);
            this.cbxCategorieVip.TabIndex = 16;
            // 
            // cbxEvenement
            // 
            this.cbxEvenement.FormattingEnabled = true;
            this.cbxEvenement.Location = new System.Drawing.Point(264, 60);
            this.cbxEvenement.Name = "cbxEvenement";
            this.cbxEvenement.Size = new System.Drawing.Size(121, 21);
            this.cbxEvenement.TabIndex = 15;
            // 
            // cbxCampagne
            // 
            this.cbxCampagne.FormattingEnabled = true;
            this.cbxCampagne.Location = new System.Drawing.Point(264, 10);
            this.cbxCampagne.Name = "cbxCampagne";
            this.cbxCampagne.Size = new System.Drawing.Size(121, 21);
            this.cbxCampagne.TabIndex = 14;
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.Location = new System.Drawing.Point(195, 205);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.Size = new System.Drawing.Size(370, 119);
            this.rtxtMessage.TabIndex = 13;
            this.rtxtMessage.Text = "";
            // 
            // btnAjoutMessage
            // 
            this.btnAjoutMessage.Location = new System.Drawing.Point(310, 369);
            this.btnAjoutMessage.Name = "btnAjoutMessage";
            this.btnAjoutMessage.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutMessage.TabIndex = 12;
            this.btnAjoutMessage.Text = "Ajouter";
            this.btnAjoutMessage.UseVisualStyleBackColor = true;
            // 
            // lblCategorieVip
            // 
            this.lblCategorieVip.AutoSize = true;
            this.lblCategorieVip.Location = new System.Drawing.Point(120, 118);
            this.lblCategorieVip.Name = "lblCategorieVip";
            this.lblCategorieVip.Size = new System.Drawing.Size(96, 13);
            this.lblCategorieVip.TabIndex = 11;
            this.lblCategorieVip.Text = "Catégorie de VIP : ";
            // 
            // lblEvenement
            // 
            this.lblEvenement.AutoSize = true;
            this.lblEvenement.Location = new System.Drawing.Point(121, 69);
            this.lblEvenement.Name = "lblEvenement";
            this.lblEvenement.Size = new System.Drawing.Size(70, 13);
            this.lblEvenement.TabIndex = 10;
            this.lblEvenement.Text = "Evénement : ";
            // 
            // lblCampagne
            // 
            this.lblCampagne.AutoSize = true;
            this.lblCampagne.Location = new System.Drawing.Point(118, 19);
            this.lblCampagne.Name = "lblCampagne";
            this.lblCampagne.Size = new System.Drawing.Size(67, 13);
            this.lblCampagne.TabIndex = 9;
            this.lblCampagne.Text = "Campagne : ";
            // 
            // FrmAjoutMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 403);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.cbxCategorieVip);
            this.Controls.Add(this.cbxEvenement);
            this.Controls.Add(this.cbxCampagne);
            this.Controls.Add(this.rtxtMessage);
            this.Controls.Add(this.btnAjoutMessage);
            this.Controls.Add(this.lblCategorieVip);
            this.Controls.Add(this.lblEvenement);
            this.Controls.Add(this.lblCampagne);
            this.Name = "FrmAjoutMessage";
            this.Text = "Création d\'un message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ComboBox cbxCategorieVip;
        private System.Windows.Forms.ComboBox cbxEvenement;
        private System.Windows.Forms.ComboBox cbxCampagne;
        private System.Windows.Forms.RichTextBox rtxtMessage;
        private System.Windows.Forms.Button btnAjoutMessage;
        private System.Windows.Forms.Label lblCategorieVip;
        private System.Windows.Forms.Label lblEvenement;
        private System.Windows.Forms.Label lblCampagne;
    }
}