namespace CaisseEnregistreuse
{
    partial class Rendu
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
            this.tbxFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxFin
            // 
            this.tbxFin.Location = new System.Drawing.Point(12, 462);
            this.tbxFin.Name = "tbxFin";
            this.tbxFin.Size = new System.Drawing.Size(589, 43);
            this.tbxFin.TabIndex = 0;
            this.tbxFin.Text = "Fin";
            this.tbxFin.UseVisualStyleBackColor = true;
            this.tbxFin.Click += new System.EventHandler(this.tbxFin_Click);
            // 
            // Rendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 517);
            this.Controls.Add(this.tbxFin);
            this.Name = "Rendu";
            this.Text = "Rendu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rendu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tbxFin;
    }
}