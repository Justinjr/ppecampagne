using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GesCampagneBO
{
    public class Theme
    {
        private int id;
        private string libelle;

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

        public Theme(int id,string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public Theme(int id)
        {
            this.id = id;
            
        }
    }
}
