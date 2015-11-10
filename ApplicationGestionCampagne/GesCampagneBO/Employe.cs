using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GesCampagneBO
{
    class Employe
    {
        int id;
        string nom;
        string prenom;


        public Employe(int unId, string unNom, string unPrenom)
        {
            id = unId;
            nom = unNom;
            prenom = unPrenom;

        }

        public Employe(string unNom, string unPrenom)
        {
            nom = unNom;
            prenom = unPrenom;
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }


    }
}
