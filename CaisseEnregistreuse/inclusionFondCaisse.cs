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
    public partial class inclusionFondCaisse : Form
    {
        Caisse C = new Caisse();
        public inclusionFondCaisse()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInclure_Click(object sender, EventArgs e)
        {
            C.InclureFondDeCaisse(Convert.ToInt32(num1000.Value), Convert.ToInt32(num200.Value), Convert.ToInt32(num100.Value), Convert.ToInt32(num50.Value), Convert.ToInt32(num20.Value), Convert.ToInt32(num10.Value), Convert.ToInt32(num5.Value), Convert.ToInt32(num2.Value), Convert.ToInt32(num1.Value), Convert.ToInt32(num05.Value), Convert.ToInt32(num02.Value), Convert.ToInt32(num01.Value), Convert.ToInt32(num005.Value));
        }

        public void Change()
        {
            decimal d = num1000.Value * 1000 + num200.Value * 200 + num100.Value * 100 + num50.Value + num20.Value * 20 + num10.Value * 10 + num5.Value * 5 + num2.Value * 2 + num1.Value * 1 + num05.Value * Convert.ToDecimal(0.5) + num02.Value * Convert.ToDecimal(0.2) + num01.Value * Convert.ToDecimal(0.1) + num005.Value * Convert.ToDecimal(0.05);

            tbxTotal.Text = Convert.ToString(d);
        }

        private void num_ValueChanged(object sender, EventArgs e)
        {
            Change();
        }
    }
}