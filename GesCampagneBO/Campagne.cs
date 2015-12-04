using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GesCampagneBO
{
    public class Campagne
    {
        private int id;
        private string intitule;
        private string objectif;
        private DateTime dateDebut;
        private DateTime dateFin;
        private Public idPublic;
        private Employe idEmploye;

        public Campagne(int unId, string unIntitule, string unObjectif, DateTime uneDateDebut, DateTime uneDateFin, Public unIdPublic,Employe unIdEmploye)
        {
            id = unId;
            intitule = unIntitule;
            objectif = unObjectif;
            dateDebut = uneDateDebut;
            dateFin = uneDateFin;
            idPublic = unIdPublic;
            idEmploye = unIdEmploye;

        }

        public Campagne(string unIntitule, string unObjectif, DateTime uneDateDebut, DateTime uneDateFin, Public unIdPublic, Employe unIdEmploye)
        {
            intitule = unIntitule;
            objectif = unObjectif;
            dateDebut = uneDateDebut;
            dateFin = uneDateFin;
            idPublic = unIdPublic;
            idEmploye = unIdEmploye;

        }

        public Campagne(int unId,string unIntitule)
        {
            id = unId;
            intitule = unIntitule;
           

        }

        public Campagne(int unId)
        {
            id = unId;
           


        }



        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Intitule
        {
            get { return intitule; }
            set { intitule = value; }
        }
        public string Objectif
        {
            get { return objectif; }
            set { objectif = value; }
        }
        public DateTime DateDebut
        {
            get { return dateDebut; }
            set { dateDebut = value; }
        }
        public DateTime DateFin
        {
            get { return dateFin; }
            set { dateFin = value; }
        }

        public Public IdPublic
        {
            get
            {
                return idPublic;
            }

            set
            {
                idPublic = value;
            }
        }

        public Employe IdEmploye
        {
            get
            {
                return idEmploye;
            }

            set
            {
                idEmploye = value;
            }
        }
    }
}
