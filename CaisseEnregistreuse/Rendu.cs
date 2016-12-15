using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaisseEnregistreuse
{
    public partial class Rendu : Form
    {
        public Rendu(int [] argentARendre)
        {
            InitializeComponent();
            int Verification = 0;
            foreach (var coupure in argentARendre)
            {
                Verification += 1;
            }

            if(Verification == 13)
            {
                Label label = new Label();
                label.Location = new System.Drawing.Point(317, 26);
                label.Parent = this;
                label.Name = "lblFalse";
                label.Text = "13";
                label.Size = new System.Drawing.Size(77, 21);
                this.Controls.Add(label);
            }
            else
            {
                Label label = new Label();
                label.Location = new System.Drawing.Point(317, 26);
                label.Parent = this;
                label.Name = "lblFalse";
                label.Text = "Pas assez d'argent dans la caisse";
                label.Size = new System.Drawing.Size(300, 21);
                this.Controls.Add(label);
            }
            
        }
        

        private void tbxFin_Click(object sender, EventArgs e)
        {

        }
    }
}
