﻿using System;
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
    public partial class FondDeCaisse : Form
    {
        Caisse C = new Caisse();

        public FondDeCaisse()
        {
            // TODO: Complete member initialization
            InitializeComponent();
            int[] FR = C.returnNumberOfMoney();
            this.lbl1000.Text = "x " + Convert.ToString(FR[0]);
            this.lbl200.Text = "x " + Convert.ToString(FR[1]);
            this.lbl100.Text = "x " + Convert.ToString(FR[2]);
            this.lbl50.Text = "x " + Convert.ToString(FR[3]);
            this.lbl20.Text = "x " + Convert.ToString(FR[4]);
            this.lbl10.Text = "x " + Convert.ToString(FR[5]);
            this.lbl5.Text = "x " + Convert.ToString(FR[6]);
            this.lbl2.Text = "x " + Convert.ToString(FR[7]);
            this.lbl1.Text = "x " + Convert.ToString(FR[8]);
            this.lbl05.Text = "x " + Convert.ToString(FR[9]);
            this.lbl02.Text = "x " + Convert.ToString(FR[10]);
            this.lbl01.Text = "x " + Convert.ToString(FR[11]);
            this.lbl005.Text = "x " + Convert.ToString(FR[12]);
        }
        

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FondDeCaisse_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
