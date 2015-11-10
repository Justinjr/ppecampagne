using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GesCampagneBO
{
    public class Courant
    {
        //attribut
        private int id;
        private string libelle;

        //propriété
        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        //constructeur
        public Courant(int unId, string unLibelle)
        {
            this.id = unId;
            this.libelle = unLibelle;
        }
        public Courant(string unLibelle)
        {
            this.libelle = unLibelle;
        }
    }
}
