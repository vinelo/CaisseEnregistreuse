namespace CaisseEnregistreuse
{
    partial class Vente
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
            this.lsbPrix = new System.Windows.Forms.ListBox();
            this.tbxPrixAInserer = new System.Windows.Forms.TextBox();
            this.btnAjouterPrix = new System.Windows.Forms.Button();
            this.btnSupprimerPrix = new System.Windows.Forms.Button();
            this.btnPaiement = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbPrix
            // 
            this.lsbPrix.FormattingEnabled = true;
            this.lsbPrix.Location = new System.Drawing.Point(12, 65);
            this.lsbPrix.Name = "lsbPrix";
            this.lsbPrix.Size = new System.Drawing.Size(221, 238);
            this.lsbPrix.TabIndex = 0;
            // 
            // tbxPrixAInserer
            // 
            this.tbxPrixAInserer.Location = new System.Drawing.Point(12, 28);
            this.tbxPrixAInserer.Name = "tbxPrixAInserer";
            this.tbxPrixAInserer.Size = new System.Drawing.Size(83, 20);
            this.tbxPrixAInserer.TabIndex = 1;
            // 
            // btnAjouterPrix
            // 
            this.btnAjouterPrix.Location = new System.Drawing.Point(101, 28);
            this.btnAjouterPrix.Name = "btnAjouterPrix";
            this.btnAjouterPrix.Size = new System.Drawing.Size(59, 20);
            this.btnAjouterPrix.TabIndex = 2;
            this.btnAjouterPrix.Text = "Ajouter";
            this.btnAjouterPrix.UseVisualStyleBackColor = true;
            this.btnAjouterPrix.Click += new System.EventHandler(this.btnAjouterPrix_Click);
            // 
            // btnSupprimerPrix
            // 
            this.btnSupprimerPrix.Location = new System.Drawing.Point(166, 28);
            this.btnSupprimerPrix.Name = "btnSupprimerPrix";
            this.btnSupprimerPrix.Size = new System.Drawing.Size(67, 20);
            this.btnSupprimerPrix.TabIndex = 3;
            this.btnSupprimerPrix.Text = "Supprimer";
            this.btnSupprimerPrix.UseVisualStyleBackColor = true;
            // 
            // btnPaiement
            // 
            this.btnPaiement.Location = new System.Drawing.Point(12, 350);
            this.btnPaiement.Name = "btnPaiement";
            this.btnPaiement.Size = new System.Drawing.Size(107, 33);
            this.btnPaiement.TabIndex = 4;
            this.btnPaiement.Text = "Paiement";
            this.btnPaiement.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(125, 350);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(108, 33);
            this.btnRetour.TabIndex = 5;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 306);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total : ";
            // 
            // Vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 395);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnPaiement);
            this.Controls.Add(this.btnSupprimerPrix);
            this.Controls.Add(this.btnAjouterPrix);
            this.Controls.Add(this.tbxPrixAInserer);
            this.Controls.Add(this.lsbPrix);
            this.Name = "Vente";
            this.Text = "Vente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbPrix;
        private System.Windows.Forms.TextBox tbxPrixAInserer;
        private System.Windows.Forms.Button btnAjouterPrix;
        private System.Windows.Forms.Button btnSupprimerPrix;
        private System.Windows.Forms.Button btnPaiement;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblTotal;
    }
}