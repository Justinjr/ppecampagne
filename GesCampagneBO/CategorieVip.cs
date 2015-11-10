using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GesCampagneBO
{
    public class CategorieVip
    {
        private int id;
        private string libelle;

        public CategorieVip (int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
    // Accesseurs en lecture/éecriture
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public string Libelle
        {
            get
            {
                return libelle;
            }

            set
            {
                libelle = value;
            }
        }
    }
}
