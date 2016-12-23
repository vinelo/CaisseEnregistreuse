using System;
using System.Windows.Forms;

namespace CaisseEnregistreuse
{
    public partial class Vente : Form
    {
        #region Déclaration des variables
        decimal Total;
        Encaissement _encaissement;

        public Encaissement Encaissement
        {
            get { return _encaissement; }
            set { _encaissement = value; }
        }

        Caisse _caisse;

        public Caisse Caisse
        {
            get { return _caisse; }
            set { _caisse = value; }
        }
        #endregion

        /// <summary>
        /// Constructeur de la form
        /// </summary>
        /// <param name="C">Classe caisse</param>
        public Vente(Caisse C)
        {
            InitializeComponent();
            Caisse = C;
            //"Grisage" des boutons que l'utilisateur est censé ne pas pouvoir utiliser pour l'instant
            btnAjouterPrix.Enabled = false;
            btnSupprimerPrix.Enabled = false;
            btnPaiement.Enabled = false;
        }
        /// <summary>
        /// Fonction qui rafraichit la page
        /// </summary>
        public void Change()
        {
            //Calculer la somme des prix ajouté dans la liste
            Total = 0;
            foreach (var item in lsbPrix.Items)
            {
                Total += Convert.ToDecimal(item);
            }
            //Affichage de la somme des prix dans le label
            lblTotal.Text = Convert.ToString(Total) + " Fr";

            //Si la somme des produit est égal à 0 alors il grise le bouton "supprimer" et "paiement"
            if (Total == 0)
            {
                btnSupprimerPrix.Enabled = false;
                btnPaiement.Enabled = false;
            }
            else
            { 
                //Sinon il les "dégrise"
                btnSupprimerPrix.Enabled = true;
                btnPaiement.Enabled = true;
            }


            numPrix.Value = 0;
        }

        private void btnAjouterPrix_Click(object sender, EventArgs e)
        {
            //Ajoute un prix à la liste
            if (numPrix.Value != 0)
                lsbPrix.Items.Add(numPrix.Value);
            //applique les changement
            Change();
        }

        private void btnSupprimerPrix_Click(object sender, EventArgs e)
        {
            //Supprime un prix de la liste
            lsbPrix.Items.Remove(lsbPrix.SelectedItem);
            //applique les changements
            Change();
        }

        private void btnPaiement_Click(object sender, EventArgs e)
        {
            //arondit la somme total et nous redirige sur la page "Encaissement"
            Total = Math.Round(Total / 2, 1) * 2;
            Encaissement = new Encaissement(Total, Caisse, this);
            Encaissement.ShowDialog();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numPrix_ValueChanged(object sender, EventArgs e)
        {
            //Si le numérique UpDown est égal à 0 alors gris le boutton pour ajouter le prix
            if (numPrix.Value == 0)
                btnAjouterPrix.Enabled = false;
            else//Sinon dégrise le bouton pour ajouter le prix
                btnAjouterPrix.Enabled = true;

            //Arrondit la valeur du numérique UpDown au centième
            numPrix.Value = Math.Round((numPrix.Value), 2);
            numPrix.DecimalPlaces = 2;
            numPrix.Increment = 0.5M;
        }
    }
}