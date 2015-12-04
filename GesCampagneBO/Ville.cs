using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GesCampagneBO
{
    public class Ville
    {
        private string libelle;
        private int numInsee;
        private string cp;

        public int NumInsee
        {
            get { return numInsee; }
            set { numInsee = value; }
        }


        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }


        public string Cp
        {
            get { return cp; }
            set { cp = value; }
        }

        public Ville(int numInsee, string libelle, string cp)
        {
            this.numInsee = numInsee;
            this.libelle = libelle;
            this.cp = cp;
        }

        public Ville(int numInsee, string libelle)
        {
            this.numInsee = numInsee;
            this.libelle = libelle;
            
        }
        public Ville(int numInsee)
        {
            this.numInsee = numInsee;
           

        }
    }
}
