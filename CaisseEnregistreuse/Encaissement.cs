using System;
using System.Windows.Forms;

namespace CaisseEnregistreuse
{
    public partial class Encaissement : Form
    {
        decimal Total;
        decimal ArgentDonne;
        decimal Reste;

        private Caisse _caisse;

        public Caisse Caisse
        {
            get { return _caisse; }
            set { _caisse = value; }
        }

        Rendu _rendu;

        public Rendu Rendu
        {
            get { return _rendu; }
            set { _rendu = value; }
        }

        private Vente _vente;

        public Vente Vente
        {
            get { return _vente; }
            set { _vente = value; }
        }

        public Encaissement(decimal TotalAPayer, Caisse C, Vente V)
        {
            InitializeComponent();
            Total = TotalAPayer;
            tbxTotal.Text = Convert.ToString(Total) + " Fr";

            Caisse = C;
            Vente = V;
        }

        private void Change()
        {
            ArgentDonne = 1000 * num1000.Value + 200 * num200.Value + 100 * num100.Value + 50 * num50.Value + 20 * num20.Value + 10 * num10.Value + 5 * num5.Value + 2 * num2.Value + 1 * num1.Value + Convert.ToDecimal(0.5) * num05.Value + Convert.ToDecimal(0.2) * num02.Value + Convert.ToDecimal(0.1) * num01.Value + Convert.ToDecimal(0.05) * num005.Value;
            tbxArgentDonne.Text = Convert.ToString(ArgentDonne) + " Fr";

            Reste = Total - ArgentDonne;
            if (Reste > 0)
            {
                lblReste.Text = "Reste :";
                tbxReste.Text = Convert.ToString(Reste) + " Fr";
                btnEncaisser.Enabled = false;
            }
            else if (Reste < 0)
            {
                lblReste.Text = "A rendre :";
                tbxReste.Text = Convert.ToString(Reste * -1) + " Fr";
                btnEncaisser.Enabled = true;
            }
            else
            {
                tbxReste.Text = "0 Fr";
                btnEncaisser.Enabled = true;
            }

        }

        private void btnEncaisser_Click(object sender, EventArgs e)
        {
            int[] Coupure = { Convert.ToInt32(num1000.Value), Convert.ToInt32(num200.Value), Convert.ToInt32(num100.Value), Convert.ToInt32(num50.Value), Convert.ToInt32(num20.Value), Convert.ToInt32(num10.Value), Convert.ToInt32(num5.Value), Convert.ToInt32(num2.Value), Convert.ToInt32(num1.Value), Convert.ToInt32(num05.Value), Convert.ToInt32(num02.Value), Convert.ToInt32(num01.Value), Convert.ToInt32(num005.Value) };

            Rendu = new Rendu(Caisse.Encaissement(Total, Coupure, ArgentDonne), Reste * -1,Vente, this);
            Rendu.ShowDialog();
        }
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void num_ValueChanged(object sender, EventArgs e)
        {
            Change();
        }
    }
}
