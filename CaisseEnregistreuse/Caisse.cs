using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseEnregistreuse
{
    public partial class Caisse
    {
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
            int[] coupureARendre = { Fr1000, Fr200, Fr100, Fr50, Fr20, Fr10, Fr5, Fr2, Fr1, Fr05, Fr02, Fr01, Fr005 };
            return coupureARendre;
        }

        public double CalculTotal()
        {
            return 1000 * Fr1000 + 200 * Fr200 + 100 * Fr100 + 50 * Fr50 + 20 * Fr20 + 10 * Fr10 + 5 * Fr5 + 2 * Fr2 + 1 * Fr1 + 0.5 * Fr05 + 0.2 * Fr02 + 0.1 * Fr01 + 0.05 * Fr005;
        }

        public int[] Encaissement(double aPayer, int[] coupureDonne, double totalDonne)
        {

            int[] coupureARendre = new int[13];
            double aRendre = totalDonne - aPayer;

            int Fr1000Temp = Fr1000 + coupureDonne[0];
            int Fr200Temp = Fr200 + coupureDonne[1];
            int Fr100Temp = Fr100 + coupureDonne[2];
            int Fr50Temp = Fr50 + coupureDonne[3];
            int Fr20Temp = Fr20 + coupureDonne[4];
            int Fr10Temp = Fr10 + coupureDonne[5];
            int Fr5Temp = Fr5 + coupureDonne[6];
            int Fr2Temp = Fr2 + coupureDonne[7];
            int Fr1Temp = Fr1 + coupureDonne[8];
            int Fr05Temp = Fr05 + coupureDonne[9];
            int Fr02Temp = Fr02 + coupureDonne[10];
            int Fr01Temp = Fr01 + coupureDonne[11];
            int Fr005Temp = Fr005 + coupureDonne[12];

            while (aRendre >= 1000 && Fr1000Temp > 0)
            {
                aRendre -= 1000;
                coupureARendre[0] += 1;
                Fr1000Temp -= 1;
            }

            while (aRendre >= 200 && Fr200Temp > 0)
            {
                aRendre -= 200;
                coupureARendre[1] += 1;
                Fr200Temp -= 1;
            }

            while (aRendre >= 100 && Fr100Temp > 0)
            {
                aRendre -= 100;
                coupureARendre[2] += 1;
                Fr100Temp -= 1;
            }

            while (aRendre >= 50 && Fr50Temp > 0)
            {
                aRendre -= 50;
                coupureARendre[3] += 1;
                Fr50Temp -= 1;
            }

            while (aRendre >= 20 && Fr20Temp > 0)
            {
                aRendre -= 20;
                coupureARendre[4] += 1;
                Fr20Temp -= 1;
            }

            while (aRendre >= 10 && Fr10Temp > 0)
            {
                aRendre -= 10;
                coupureARendre[5] += 1;
                Fr10Temp -= 1;
            }

            while (aRendre >= 5 && Fr5Temp > 0)
            {
                aRendre -= 5;
                coupureARendre[6] += 1;
                Fr5Temp -= 1;
            }

            while (aRendre >= 2 && Fr2Temp > 0)
            {
                aRendre -= 2;
                coupureARendre[7] += 1;
                Fr2Temp -= 1;
            }

            while (aRendre >= 1 && Fr1Temp > 0)
            {
                aRendre -= 1;
                coupureARendre[8] += 1;
                Fr1Temp -= 1;
            }

            while (aRendre >= 0.5 && Fr05Temp > 0)
            {
                aRendre -= 0.5;
                coupureARendre[9] += 1;
                Fr05Temp -= 1;
            }

            while (aRendre >= 0.2 && Fr02Temp > 0)
            {
                aRendre -= 0.2;
                coupureARendre[10] += 1;
                Fr02Temp -= 1;
            }

            while (aRendre >= 0.1 && Fr01Temp > 0)
            {
                aRendre -= 0.1;
                coupureARendre[11] += 1;
                Fr01Temp -= 1;
            }

            while (aRendre >= 0.05 && Fr005Temp > 0)
            {
                aRendre -= 0.05;
                coupureARendre[12] += 1;
                Fr005Temp -= 1;
            }

            if (aRendre == 0)
            {
                Fr1000 = Fr1000Temp;
                Fr200 = Fr200Temp;
                Fr100 = Fr100Temp;
                Fr50 = Fr50Temp;
                Fr20 = Fr20Temp;
                Fr10 = Fr10Temp;
                Fr5 = Fr5Temp;
                Fr2 = Fr2Temp;
                Fr1 = Fr1Temp;
                Fr05 = Fr05Temp;
                Fr02 = Fr02Temp;
                Fr01 = Fr01Temp;
                Fr005 = Fr005Temp;
            }
            else
            {
                coupureARendre = new int[1];
            }

            return coupureARendre;
        }
    }
}
