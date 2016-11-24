using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseEnregistreuse
{
    class Caisse
    {
        private int _frr1000;

        public int Frr1000
        {
            get { return _frr1000; }
            set { _frr1000 = value; }
        }
        static private int _fr1000;

        static public int Fr1000
        {
            get { return _fr1000; }
            set { _fr1000 = value; }
        }
        static private int _fr200;

        static public int Fr200
        {
            get { return _fr200; }
            set { _fr200 = value; }
        }
        static private int _fr100;

        static public int Fr100
        {
            get { return _fr100; }
            set { _fr100 = value; }
        }
        static private int _fr50;

        static public int Fr50
        {
            get { return _fr50; }
            set { _fr50 = value; }
        }
        static private int _fr20;

        static public int Fr20
        {
            get { return _fr20; }
            set { _fr20 = value; }
        }
        static private int _fr10;

        static public int Fr10
        {
            get { return _fr10; }
            set { _fr10 = value; }
        }
        static private int _fr5;

        static public int Fr5
        {
            get { return _fr5; }
            set { _fr5 = value; }
        }
        static private int _fr2;

        static public int Fr2
        {
            get { return _fr2; }
            set { _fr2 = value; }
        }
        static private int _fr1;

        static public int Fr1
        {
            get { return _fr1; }
            set { _fr1 = value; }
        }
        static private int _fr05;

        static public int Fr05
        {
            get { return _fr05; }
            set { _fr05 = value; }
        }
        static private int _fr02;

        static public int Fr02
        {
            get { return _fr02; }
            set { _fr02 = value; }
        }
        static private int _fr01;

        static public int Fr01
        {
            get { return _fr01; }
            set { _fr01 = value; }
        }
        static private int _fr005;

        static public int Fr005
        {
            get { return _fr005; }
            set { _fr005 = value; }
        }

        public Caisse()
        {
        }

        public void InclureFondDeCaisse(int nb1000, int nb200, int nb100, int nb50, int nb20, int nb10, int nb5, int nb2, int nb1, int nb05, int nb02, int nb01, int nb005)
        {
            Fr1000 = nb1000;
            Fr200 = nb200;
            Fr100 = nb100;
            Fr50 = nb50;
            Fr20 = nb20;
            Fr10 = nb10;
            Fr5 = nb5;
            Fr2 = nb2;
            Fr1 = nb1;
            Fr05 = nb05;
            Fr02 = nb02;
            Fr01 = nb01;
            Fr005 = nb005;
        }
        public int[] returnNumberOfMoney()
        {
            int[] NumberMoney = { Fr1000,Fr200,Fr100,Fr50,Fr20,Fr10,Fr5,Fr2,Fr1,Fr05,Fr02,Fr01,Fr005};
            return NumberMoney;
        }

        public double CalculTotal()
        {
            return 1000 * Fr1000 + 200 * Fr200 + 100 * Fr100 + 50 * Fr50 + 20 * Fr20 + 10 * Fr10 + 5 * Fr5 + 2 * Fr2 + 1 * Fr1 + 0.5 * Fr05 + 0.2 * Fr02 + 0.1 * Fr01 + 0.05 * Fr005;
        }
    }
}
