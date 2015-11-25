namespace ApplicationGestionCampagne
{
    partial class FrmMenu
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
            this.btnAjoutCampagne = new System.Windows.Forms.Button();
            this.btnAjoutEvent = new System.Windows.Forms.Button();
            this.btnAjoutArtiste = new System.Windows.Forms.Button();
            this.btnAjoutMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjoutCampagne
            // 
            this.btnAjoutCampagne.Location = new System.Drawing.Point(71, 89);
            this.btnAjoutCampagne.Name = "btnAjoutCampagne";
            this.btnAjoutCampagne.Size = new System.Drawing.Size(173, 23);
            this.btnAjoutCampagne.TabIndex = 0;
            this.btnAjoutCampagne.Text = "Ajout d\'une campagne";
            this.btnAjoutCampagne.UseVisualStyleBackColor = true;
            this.btnAjoutCampagne.Click += new System.EventHandler(this.btnAjoutCampagne_Click);
            // 
            // btnAjoutEvent
            // 
            this.btnAjoutEvent.Location = new System.Drawing.Point(340, 89);
            this.btnAjoutEvent.Name = "btnAjoutEvent";
            this.btnAjoutEvent.Size = new System.Drawing.Size(173, 23);
            this.btnAjoutEvent.TabIndex = 1;
            this.btnAjoutEvent.Text = "Ajout d\'un évenement";
            this.btnAjoutEvent.UseVisualStyleBackColor = true;
            this.btnAjoutEvent.Click += new System.EventHandler(this.btnAjoutEvent_Click);
            // 
            // btnAjoutArtiste
            // 
            this.btnAjoutArtiste.Location = new System.Drawing.Point(71, 236);
            this.btnAjoutArtiste.Name = "btnAjoutArtiste";
            this.btnAjoutArtiste.Size = new System.Drawing.Size(173, 23);
            this.btnAjoutArtiste.TabIndex = 2;
            this.btnAjoutArtiste.Text = "Ajout d\'un artiste";
            this.btnAjoutArtiste.UseVisualStyleBackColor = true;
            this.btnAjoutArtiste.Click += new System.EventHandler(this.btnAjoutArtiste_Click);
            // 
            // btnAjoutMessage
            // 
            this.btnAjoutMessage.Location = new System.Drawing.Point(340, 236);
            this.btnAjoutMessage.Name = "btnAjoutMessage";
            this.btnAjoutMessage.Size = new System.Drawing.Size(173, 23);
            this.btnAjoutMessage.TabIndex = 3;
            this.btnAjoutMessage.Text = "Ajout d\'un message";
            this.btnAjoutMessage.UseVisualStyleBackColor = true;
            this.btnAjoutMessage.Click += new System.EventHandler(this.btnAjoutMessage_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 525);
            this.Controls.Add(this.btnAjoutMessage);
            this.Controls.Add(this.btnAjoutArtiste);
            this.Controls.Add(this.btnAjoutEvent);
            this.Controls.Add(this.btnAjoutCampagne);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjoutCampagne;
        private System.Windows.Forms.Button btnAjoutEvent;
        private System.Windows.Forms.Button btnAjoutArtiste;
        private System.Windows.Forms.Button btnAjoutMessage;
    }
}