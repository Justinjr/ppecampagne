using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDico
{
    class Employe
    {
        string matricule;
        string nom;
        int age;

        
        public Employe(string unMatricule,string unNom,int unAge)
        {
            matricule = unMatricule;
            nom = unNom;
            age = unAge;
        }

        public string Matricule
        {
            get
            {
                return matricule;
            }

            set
            {
                matricule = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

    }
}
