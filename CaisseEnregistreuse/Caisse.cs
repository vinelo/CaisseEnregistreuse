﻿using System;
namespace CaisseEnregistreuse
{
    public partial class Caisse
    {

        /// <summary>
        /// Déclaration des variables ( billets, pièces et leur valeur)
        /// </summary>
        #region variable
        private int _fr1000;

        public int Fr1000
        {
            get { return _fr1000; }
            set { _fr1000 = value; }
        }
        private int _fr200;

        public int Fr200
        {
            get { return _fr200; }
            set { _fr200 = value; }
        }
        private int _fr100;

        public int Fr100
        {
            get { return _fr100; }
            set { _fr100 = value; }
        }
        private int _fr50;

        public int Fr50
        {
            get { return _fr50; }
            set { _fr50 = value; }
        }
        private int _fr20;

        public int Fr20
        {
            get { return _fr20; }
            set { _fr20 = value; }
        }
        private int _fr10;

        public int Fr10
        {
            get { return _fr10; }
            set { _fr10 = value; }
        }
        private int _fr5;

        public int Fr5
        {
            get { return _fr5; }
            set { _fr5 = value; }
        }
        private int _fr2;

        public int Fr2
        {
            get { return _fr2; }
            set { _fr2 = value; }
        }
        private int _fr1;

        public int Fr1
        {
            get { return _fr1; }
            set { _fr1 = value; }
        }
        private int _fr05;

        public int Fr05
        {
            get { return _fr05; }
            set { _fr05 = value; }
        }
        private int _fr02;

        public int Fr02
        {
            get { return _fr02; }
            set { _fr02 = value; }
        }
        private int _fr01;

        public int Fr01
        {
            get { return _fr01; }
            set { _fr01 = value; }
        }
        private int _fr005;

        public int Fr005
        {
            get { return _fr005; }
            set { _fr005 = value; }
        }

        //readonly car les constante bug avec le type decimal
        readonly decimal mille = 1000;
        readonly decimal deuxCent = 200;
        readonly decimal cent = 100;
        readonly decimal cinquante = 50;
        readonly decimal vingt = 20;
        readonly decimal dix = 10;
        readonly decimal cinq = 5;
        readonly decimal deux = 2;
        readonly decimal un = 1;
        //Décalaration de leurs valeurs dans le constructeur car cela ne fonctionne apparement pas ici
        readonly decimal cinquanteCT;//= 0.5m;
        readonly decimal vingtCT;// = 0.2m;
        readonly decimal dixCT;//= 0.1m;
        readonly decimal cinqCT;//= 0.05m;

        #endregion

        public Caisse()
        {
            vingtCT = 0.2m;
            cinquanteCT = 0.5m;
            dixCT = 0.1m;
            cinqCT = 0.05m;
        }

        #region Méthode
        /// <summary>
        /// Inclut un nouveau fond de caisse
        /// </summary>
        /// <param name="nb1000">Nombre de billet de 1000 Fr</param>
        /// <param name="nb200">Nombre de billet de 200 Fr</param>
        /// <param name="nb100">Nombre de billet de 100 Fr</param>
        /// <param name="nb50">Nombre de billet de 50 Fr</param>
        /// <param name="nb20">Nombre de billet de 20 Fr</param>
        /// <param name="nb10">Nombre de billet de 10 Fr</param>
        /// <param name="nb5">Nombre de pièce de 5 Fr</param>
        /// <param name="nb2">Nombre de pièce de 2 Fr</param>
        /// <param name="nb1">Nombre de pièce de 1 Fr</param>
        /// <param name="nb05">Nombre de pièce de 50 Ct</param>
        /// <param name="nb02">Nombre de pièce de 20 Ct</param>
        /// <param name="nb01">Nombre de pièce de 10 Ct</paramnh
        /// <param name="nb005">Nombre de pièce de 5 Ct</param>
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

        /// <summary>
        /// Retourne un tableau contenant le nombre de billets et de pièce pour chacun des coupures
        /// </summary>
        /// <returns>Tableau contenant le nombre de billets et de pièce pour chacune des coupures</returns>
        public int[] returnNumberOfMoney()
        {
            int[] coupureARendre = { Fr1000, Fr200, Fr100, Fr50, Fr20, Fr10, Fr5, Fr2, Fr1, Fr05, Fr02, Fr01, Fr005 };
            return coupureARendre;
        }

        /// <summary>
        /// Calcule la somme total que contient la caisse
        /// </summary>
        /// <returns>Somme total de la caisse</returns>
        public double CalculTotal()
        {
            return 1000 * Fr1000 + 200 * Fr200 + 100 * Fr100 + 50 * Fr50 + 20 * Fr20 + 10 * Fr10 + 5 * Fr5 + 2 * Fr2 + 1 * Fr1 + 0.5 * Fr05 + 0.2 * Fr02 + 0.1 * Fr01 + 0.05 * Fr005;
        }
        /// <summary>
        /// Encaisse la somme à encaisser avec l'argent donné en paramètre puis retourne l'argent à rendre au client
        /// </summary>
        /// <param name="aPayer">Somme à payer</param>
        /// <param name="coupureDonne">Tableau contenant les coupures données par le client</param>
        /// <param name="totalDonne">Somme de toutes les coupures données par le client</param>
        /// <returns>Tableau des coupures à rendre au client</returns>
        public int[] Encaissement(decimal aPayer, int[] coupureDonne, decimal totalDonne)
        {
            //Création d'un tableau qui contiendra les coupures à rendre
            int[] coupureARendre = new int[13];
            decimal aRendre = totalDonne - aPayer;

            //Déclaration de variables temporaire dont la valeur sera le nombre de billet dans la caisse + nombre de billet donné
            //Variable servira à savoir combien de billets nous avons à notre diposition
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

            #region boucle afin de savoir combien il faut rendre de billet de chaque
            while (aRendre >= mille && Fr1000Temp > 0)
            {
                aRendre -= mille;
                coupureARendre[0] += 1;
                Fr1000Temp -= 1;
            }

            while (aRendre >= deuxCent && Fr200Temp > 0)
            {
                aRendre -= deuxCent;
                coupureARendre[1] += 1;
                Fr200Temp -= 1;
            }

            while (aRendre >= cent && Fr100Temp > 0)
            {
                aRendre -= cent;
                coupureARendre[2] += 1;
                Fr100Temp -= 1;
            }

            while (aRendre >= cinquante && Fr50Temp > 0)
            {
                aRendre -= cinquante;
                coupureARendre[3] += 1;
                Fr50Temp -= 1;
            }

            while (aRendre >= vingt && Fr20Temp > 0)
            {
                aRendre -= vingt;
                coupureARendre[4] += 1;
                Fr20Temp -= 1;
            }

            while (aRendre >= dix && Fr10Temp > 0)
            {
                aRendre -= dix;
                coupureARendre[5] += 1;
                Fr10Temp -= 1;
            }

            while (aRendre >= cinq && Fr5Temp > 0)
            {
                aRendre -= cinq;
                coupureARendre[6] += 1;
                Fr5Temp -= 1;
            }

            while (aRendre >= deux && Fr2Temp > 0)
            {
                aRendre -= deux;
                coupureARendre[7] += 1;
                Fr2Temp -= 1;
            }

            while (aRendre >= un && Fr1Temp > 0)
            {
                aRendre -= un;
                coupureARendre[8] += 1;
                Fr1Temp -= 1;
            }

            while (aRendre >= cinquanteCT && Fr05Temp > 0)
            {
                aRendre -= cinquanteCT;
                coupureARendre[9] += 1;
                Fr05Temp -= 1;
            }
            
            while (aRendre >= vingtCT && Fr02Temp > 0)
            {
                aRendre -= vingtCT;
                coupureARendre[10] += 1;
                Fr02Temp -= 1;
            }

            while (aRendre >= dixCT && Fr01Temp > 0)
            {
                aRendre -= dixCT;
                coupureARendre[11] += 1;
                Fr01Temp -= 1;
            }

            while (aRendre >= cinqCT && Fr005Temp > 0)
            {
                aRendre -= cinqCT;
                coupureARendre[12] += 1;
                Fr005Temp -= 1;
            }
            #endregion

            //Si il y a asser pour rendre alors procède à l'encaissement
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
                //sinon modifie le tableau afin que celui qui l'utilise puisse savoir qu'il n'y a pas asser dans la caisse
            else
            {
                coupureARendre = new int[1];
            }
            
            return coupureARendre;
        }
    }
}
        #endregion
