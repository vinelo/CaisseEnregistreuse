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
        private Caisse _caisse1;

        internal Caisse Caisse1
        {
            get { return _caisse1; }
            set { _caisse1 = value; }
        }

        FondDeCaisse FDC;
        inclusionFondCaisse IFDC;
        Vente V;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnInclureFondCaisse_Click(object sender, EventArgs e)
        {
            IFDC = new inclusionFondCaisse();
            IFDC.ShowDialog();
        }

        private void btnAfficherFondCaisse_Click(object sender, EventArgs e)
        {
            FDC = new FondDeCaisse();
            FDC.ShowDialog();
        }

        private void btnProcederVente_Click(object sender, EventArgs e)
        {
            V = new Vente();
            V.ShowDialog();
        }
    }
}
