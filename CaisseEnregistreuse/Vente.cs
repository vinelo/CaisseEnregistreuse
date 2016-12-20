using System;
using System.Windows.Forms;

namespace CaisseEnregistreuse
{
    public partial class Vente : Form
    {
        Encaissement _encaissement;

        public Encaissement Encaissement
        {
            get
            {
                return _encaissement;
            }

            set
            {
                _encaissement = value;
            }
        }

        Caisse _caisse;

        public Caisse Caisse
        {
            get
            {
                return _caisse;
            }

            set
            {
                _caisse = value;
            }
        }

       

        public Vente(Caisse C)
        {
            InitializeComponent();
            Caisse = C;
        }

        double Total;



        private void btnAjouterPrix_Click(object sender, EventArgs e)
        {
            if (numPrix.Value != 0)
            {
                lsbPrix.Items.Add(numPrix.Value);
            }
            Change();

        }

        public void Change()
        {
            Total = 0;
            foreach (var item in lsbPrix.Items)
            {
                Total += Convert.ToDouble(item);
            }
            lblTotal.Text = Convert.ToString(Total);
            numPrix.Value = 0;
        }

        private void btnSupprimerPrix_Click(object sender, EventArgs e)
        {
            lsbPrix.Items.Remove(lsbPrix.SelectedItem);
            Change();
        }

        private void btnPaiement_Click(object sender, EventArgs e)
        {
            Total = Math.Round(Total * 2, 1) / 2;
            Encaissement = new Encaissement(Total, Caisse, this);
            Encaissement.ShowDialog();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numPrix_ValueChanged(object sender, EventArgs e)
        {
            numPrix.Value = Math.Round((numPrix.Value), 2);
            numPrix.DecimalPlaces = 2;
            numPrix.Increment = 0.5M;
        }
    }
}