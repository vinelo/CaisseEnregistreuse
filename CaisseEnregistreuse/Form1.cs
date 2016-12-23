using System;
using System.Windows.Forms;

namespace CaisseEnregistreuse
{
    public partial class Form1 : Form
    {
        #region Déclaration des variables
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
        #endregion

        public Form1()
        {
            InitializeComponent();
            //Création de la caisse
            Caisse = new Caisse();
        }

        private void btnInclureFondCaisse_Click(object sender, EventArgs e)
        {
            //Affichage de la page d'inclusion de fond de caisse
            IFDC = new inclusionFondCaisse(Caisse);
            IFDC.ShowDialog();
        }

        private void btnAfficherFondCaisse_Click(object sender, EventArgs e)
        {
            //Affichage de la page affichant le fond de caisse
            FDC = new FondDeCaisse(Caisse);
            FDC.ShowDialog();
        }

        private void btnProcederVente_Click(object sender, EventArgs e)
        {
            //Affichage de la page de vente
            Vente = new Vente(Caisse);
            Vente.ShowDialog();
        }
    }
}
