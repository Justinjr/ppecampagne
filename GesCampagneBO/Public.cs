using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GesCampagneBO
{
    public class Public
    {
        private int id;
        private string libelle;

        
        public Public(int unId, string unLibelle)
        {
            id = unId;
            libelle = unLibelle;
        }

        public Public(string unLibelle)
        {
            libelle = unLibelle;
        }

        public Public(int unId)
        {
            id = unId;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

    }
}
