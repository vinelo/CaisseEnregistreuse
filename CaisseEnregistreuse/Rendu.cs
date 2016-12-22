using System;
using System.Drawing;
using System.Windows.Forms;

namespace CaisseEnregistreuse
{
    public partial class Rendu : Form
    {
        const int ESPACE_ENTRE_COUPURE = 200;
        int positionX = 0;
        int positionY = 0;
        int positionDansLeTableau = 0;

        private Encaissement _encaissement;

        public Encaissement Encaissement
        {
            get { return _encaissement; }
            set { _encaissement = value; }
        }

        private Vente _vente;

        public Vente Vente
        {
            get { return _vente; }
            set { _vente = value; }
        }


        /// <summary>
        /// Affiche les coupures à rendre sur la forme
        /// </summary>
        /// <param name="argentARendre">Tableau contenant le nombre de coupure à rendre pour chacune d'elle</param>
        /// <param name="totalARendre">Somme total à rendre au client</param>
        /// <param name="V">Classe "Vente" </param>
        /// <param name="E">Classe "Encaissement" </param>
        public Rendu(int[] argentARendre,decimal totalARendre, Vente V, Encaissement E)
        {
            InitializeComponent();
            Encaissement = E;
            Vente = V;

            //Vérifie si le tableau "argentARendre" contient bien 13 valeurs
            int Verification = 0;
            foreach (var coupure in argentARendre)
            {
                Verification += 1;
            }
            //Si oui alors commence l'affichage des billets
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

                bool Rendre = false;

                foreach (var coupure in argentARendre)
                {

                    int compteurDeBillet = 0;
                    if (coupure > 0)
                    {
                        for (int i = 0; i < coupure; i++)
                        {
                            compteurDeBillet++;
                        }

                        Label label = new Label();
                        label.Parent = this;
                        label.Text = "x " + Convert.ToString(compteurDeBillet);
                        label.Size = new System.Drawing.Size(25, 25);
                        
                        pbx[positionDansLeTableau].Location = new Point(positionX, positionY);
                        pbx[positionDansLeTableau].Name = "pbx" + Convert.ToString(positionDansLeTableau);
                        pbx[positionDansLeTableau].SizeMode = PictureBoxSizeMode.StretchImage;

                        if (positionDansLeTableau >= 6)
                        {
                            pbx[positionDansLeTableau].Size = new Size(150, 100);
                            label.Location = new System.Drawing.Point(positionX + 160, positionY + 20);
                            
                            if (positionY + 200 < btnFin.Location.Y)
                            {
                                positionY += 100;
                            }
                            else
                            {
                                positionY = 0;
                                positionX += 200;
                            }
                        }
                        else
                        {
                            pbx[positionDansLeTableau].Size = new Size(100, 200);
                            label.Location = new System.Drawing.Point(positionX + 120, positionY + 100);

                            if (positionY + 300 < btnFin.Location.Y)
                            {
                                positionY += 200;
                            }
                            else
                            {
                                positionY = 0;
                                positionX += 200;
                            }
                        }


                        this.Controls.Add(pbx[positionDansLeTableau]);
                        this.Controls.Add(label);

                        Rendre = true;
                    }
                    positionDansLeTableau += 1;
                }
                if (Rendre == false)
                {
                    Label label = new Label();
                    label.Location = new System.Drawing.Point(317, 26);
                    label.Parent = this;
                    label.Name = "lblAucunRendu";
                    label.Text = "Rien à rendre";
                    label.Size = new System.Drawing.Size(300, 21);
                    this.Controls.Add(label);
                }
                else
                {
                    Label label = new Label();
                    label.Location = new System.Drawing.Point(positionX + 20, positionY);
                    label.Parent = this;
                    label.Name = "lblARendre";
                    label.Text = Convert.ToString(totalARendre) + " Fr";
                    label.Size = new System.Drawing.Size(25, 25);
                    this.Controls.Add(label);
                }
            }//Sinon affiche un label qui dit qu'il n'y a pas asser d'argent dans la caisse pour rendre
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

        private void Rendu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vente.Close();
            Encaissement.Close();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
