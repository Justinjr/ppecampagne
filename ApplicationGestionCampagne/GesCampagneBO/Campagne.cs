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

        public Campagne(int unId, string unIntitule, string unObjectif, DateTime uneDateDebut, DateTime uneDateFin)
        {
            id = unId;
            intitule = unIntitule;
            objectif = unObjectif;
            dateDebut = uneDateDebut;
            dateFin = uneDateFin;

        }

        public Campagne(string unIntitule, string unObjectif, DateTime uneDateDebut, DateTime uneDateFin)
        {
            intitule = unIntitule;
            objectif = unObjectif;
            dateDebut = uneDateDebut;
            dateFin = uneDateFin;

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















    }
}
