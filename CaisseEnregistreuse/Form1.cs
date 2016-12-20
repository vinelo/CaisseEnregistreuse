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
    public partial class Form1 : Form
    {
        private Caisse _caisse;

        internal Caisse Caisse
        {
            get { return _caisse; }
            set { _caisse = value; }
        }

        FondDeCaisse _fdc;

        public FondDeCaisse FDC
        {
            get { return _fdc; }
            set { _fdc = value; }
        }

        inclusionFondCaisse _ifdc;

        public inclusionFondCaisse IFDC
        {
            get { return _ifdc; }

            set { _ifdc = value; }
        }

        Vente _vente;

        public Vente Vente
        {
            get { return _vente; }
            set { _vente = value; }
        }


        public Form1()
        {
            InitializeComponent();
            Caisse = new Caisse();
        }

        private void btnInclureFondCaisse_Click(object sender, EventArgs e)
        {
            IFDC = new inclusionFondCaisse(Caisse);
            IFDC.ShowDialog();
        }

        private void btnAfficherFondCaisse_Click(object sender, EventArgs e)
        {
            FDC = new FondDeCaisse(Caisse);
            FDC.ShowDialog();
        }

        private void btnProcederVente_Click(object sender, EventArgs e)
        {
            Vente = new Vente(Caisse);
            Vente.ShowDialog();
        }
    }
}
