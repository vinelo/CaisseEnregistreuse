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
    public partial class Encaissement : Form
    {
        double Total;
        public Encaissement(double TotalAPayer)
        {
            InitializeComponent();
            Total = TotalAPayer;
            tbxTotal.Text = Convert.ToString(Total);
        }

        int FR1000 = 0;
        int FR200 = 0;
        int FR100 = 0;
        int FR50 = 0;
        int FR20 = 0;
        int FR10 = 0;
        int FR5 = 0;
        int FR2 = 0;
        int FR1 = 0;
        int FR05 = 0;
        int FR02 = 0;
        int FR01 = 0;
        int FR005 = 0;

        private void Change()
        {
            lbl1000.Text = "x " + Convert.ToString(FR1000);
            lbl200.Text = "x " + Convert.ToString(FR200);
            lbl100.Text = "x " + Convert.ToString(FR100);
            lbl50.Text = "x " + Convert.ToString(FR50);
            lbl20.Text = "x " + Convert.ToString(FR20);
            lbl10.Text = "x " + Convert.ToString(FR10);
            lbl5.Text = "x " + Convert.ToString(FR5);
            lbl2.Text = "x " + Convert.ToString(FR2);
            lbl1.Text = "x " + Convert.ToString(FR1);
            lbl05.Text = "x " + Convert.ToString(FR05);
            lbl02.Text = "x " + Convert.ToString(FR02);
            lbl01.Text = "x " + Convert.ToString(FR01);
            lbl005.Text = "x " + Convert.ToString(FR005);
            
            double ArgentDonne = 1000 * FR1000 + 200 * FR200 + 100 * FR100 + 50 * FR50 + 20 * FR20 + 10 * FR10 + 5 * FR5 + 2 * FR2 + 1 * FR1 + 0.5 * FR05 + 0.2 * FR02 + 0.1 * FR01 + 0.05 * FR005;
            tbxArgentDonne.Text = Convert.ToString(ArgentDonne) + " Fr";

            double Reste = Total - ArgentDonne;
            if(Reste >= 0){
                tbxReste.Text = Convert.ToString(Reste);
            }
            else{
                tbxReste.Text = "0";
            }
        }

        private void btnAdd1000_Click(object sender, EventArgs e)
        {
            FR1000 += 1;
            Change();
        }
        private void btnAdd200_Click(object sender, EventArgs e)
        {
            FR200 += 1;
            Change();
        }

        private void btnAdd100_Click(object sender, EventArgs e)
        {
            FR100 += 1;
            Change();
        }

        private void btnAdd50_Click(object sender, EventArgs e)
        {
            FR50 += 1;
            Change();
        }

        private void btnAdd20_Click(object sender, EventArgs e)
        {
            FR20 += 1;
            Change();
        }

        private void btnAdd10_Click(object sender, EventArgs e)
        {
            FR10 += 1;
            Change();
        }

        private void btnAdd5_Click(object sender, EventArgs e)
        {
            FR5 += 1;
            Change();
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            FR2 += 1;
            Change();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            FR1 += 1;
            Change();
        }

        private void btnAdd05_Click(object sender, EventArgs e)
        {
            FR05 += 1;
            Change();
        }

        private void btnAdd02_Click(object sender, EventArgs e)
        {
            FR02 += 1;
            Change();
        }

        private void btnAdd01_Click(object sender, EventArgs e)
        {
            FR01 += 1;
            Change();
        }

        private void btnAdd005_Click(object sender, EventArgs e)
        {
            FR005 += 1;
            Change();
        }

        private void btnSub1000_Click(object sender, EventArgs e)
        {
            if (FR1000 > 0)
                FR1000 = FR1000 - 1;
            Change();
        }

        private void btnSub200_Click(object sender, EventArgs e)
        {
            if (FR200 > 0)
                FR200 -= 1;
            Change();
        }

        private void btnSub100_Click(object sender, EventArgs e)
        {
            if (FR100 > 0)
                FR100 -= 1;
            Change();
        }

        private void btnSub50_Click(object sender, EventArgs e)
        {
            if (FR50 > 0)
                FR50 -= 1;
            Change();
        }

        private void btnSub20_Click(object sender, EventArgs e)
        {
            if (FR20 > 0)
                FR20 -= 1;
            Change();
        }

        private void btnSub10_Click(object sender, EventArgs e)
        {
            if (FR10 > 0)
                FR10 -= 1;
            Change();
        }

        private void btnSub5_Click(object sender, EventArgs e)
        {
            if (FR5 > 0)
                FR5 -= 1;
            Change();
        }

        private void btnSub2_Click(object sender, EventArgs e)
        {
            if (FR2 > 0)
                FR2 -= 1;
            Change();
        }

        private void btnSub1_Click(object sender, EventArgs e)
        {
            if (FR1 > 0)
                FR1 -= 1;
            Change();
        }

        private void btnSub05_Click(object sender, EventArgs e)
        {
            if (FR05 > 0)
                FR05 -= 1;
            Change();
        }

        private void btnSub02_Click(object sender, EventArgs e)
        {
            if (FR02 > 0)
                FR02 -= 1;
            Change();
        }

        private void btnSub01_Click(object sender, EventArgs e)
        {
            if (FR01 > 0)
                FR01 -= 1;
            Change();
        }

        private void btnSub005_Click(object sender, EventArgs e)
        {
            if (FR005 > 0)
                FR005 -= 1;
            Change();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEncaisser_Click(object sender, EventArgs e)
        {

        }
    }
}
