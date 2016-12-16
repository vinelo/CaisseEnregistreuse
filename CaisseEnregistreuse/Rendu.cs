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
        public Rendu(int[] argentARendre)
        {
            InitializeComponent();
            const int ESPACE_ENTRE_COUPURE = 100;
            int Verification = 0;
            foreach (var coupure in argentARendre)
            {
                Verification += 1;
            }

            if (Verification == 13)
            {
                PictureBox[] pbx = new PictureBox[13];
                pbx[0] = new PictureBox();
                pbx[0].Image = Properties.Resources._1000;
                pbx[1] = new PictureBox();
                pbx[1].Image = Properties.Resources._200;
                pbx[2] = new PictureBox();
                pbx[2].Image = Properties.Resources._100;
                pbx[3] = new PictureBox();
                pbx[3].Image = Properties.Resources._50;
                pbx[4] = new PictureBox();
                pbx[4].Image = Properties.Resources._20;
                pbx[5] = new PictureBox();
                pbx[5].Image = Properties.Resources._10;
                pbx[6] = new PictureBox();
                pbx[6].Image = Properties.Resources._5;
                pbx[7] = new PictureBox();
                pbx[7].Image = Properties.Resources._2;
                pbx[8] = new PictureBox();
                pbx[8].Image = Properties.Resources._1;
                pbx[9] = new PictureBox();
                pbx[9].Image = Properties.Resources._0_5;
                pbx[10] = new PictureBox();
                pbx[10].Image = Properties.Resources._0_2;
                pbx[11] = new PictureBox();
                pbx[11].Image = Properties.Resources._0_1;
                pbx[12] = new PictureBox();
                pbx[12].Image = Properties.Resources._0_05;

                int positionX = 0;
                int positionY = 0;
                int positionDansLeTableau = 0;
                foreach (var coupure in argentARendre)
                {
                    int compteur = 0;
                    if (coupure > 0)
                    {
                        pbx[positionDansLeTableau].Location = new Point(positionX, positionY);
                        pbx[positionDansLeTableau].Name = "pbx" + Convert.ToString(positionDansLeTableau);
                        pbx[positionDansLeTableau].Size = new Size(50, 100);
                        pbx[positionDansLeTableau].SizeMode = PictureBoxSizeMode.StretchImage;

                        this.Controls.Add(pbx[positionDansLeTableau]);

                        for (int i = 0; i < coupure; i++)
                        {
                            compteur++;
                        }

                        Label label = new Label();
                        label.Location = new System.Drawing.Point(positionX + 100, positionY + 50);
                        label.Parent = this;
                        label.Name = "lblFalse";
                        label.Text = Convert.ToString(compteur);
                        label.Size = new System.Drawing.Size(300, 21);
                        this.Controls.Add(label);

                        if (positionY + 100 > this.Height)
                        {
                            positionY = 0;
                        }
                        else
                        {
                            positionY += ESPACE_ENTRE_COUPURE;
                        }

                    }
                    positionDansLeTableau += 1;
                }
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
