﻿namespace CaisseEnregistreuse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rendu));
            this.tbxFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxFin
            // 
            resources.ApplyResources(this.tbxFin, "tbxFin");
            this.tbxFin.Name = "tbxFin";
            this.tbxFin.UseVisualStyleBackColor = true;
            this.tbxFin.Click += new System.EventHandler(this.tbxFin_Click);
            // 
            // Rendu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbxFin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Rendu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rendu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tbxFin;
    }
}