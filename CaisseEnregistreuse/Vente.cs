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
            lsbPrix.Items.Add(tbxPrixAInserer.Text);
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
            tbxPrixAInserer.Text = "";
        }

        private void btnSupprimerPrix_Click(object sender, EventArgs e)
        {
            lsbPrix.Items.Remove(lsbPrix.SelectedItem);
            Change();
        }

        private void tbxPrixAInserer_TextChanged(object sender, EventArgs e)
        {

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
            E = new Encaissement(Total);
            E.ShowDialog();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}