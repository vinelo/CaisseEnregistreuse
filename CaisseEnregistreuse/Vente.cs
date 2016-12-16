using System;
using System.Windows.Forms;

namespace CaisseEnregistreuse
{
    public partial class Vente : Form
    {
        public Vente()
        {
            InitializeComponent();
        }

        Encaissement E;
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

        private void tbxPrixAInserer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnPaiement_Click(object sender, EventArgs e)
        {
            Total = Math.Round(Total * 2, 1) / 2;
            E = new Encaissement(Total);
            E.ShowDialog();
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