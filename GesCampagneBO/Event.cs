using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GesCampagneBO
{
    public class Evenement
    {
        private int id;
        private string theme;
        private DateTime dateDebut;
        private DateTime dateFin;
        //private Ville laVille;
        //private Campagne laCampagne;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Theme
        {
            get { return theme; }
            set { theme = value; }
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

        public Evenement(int id, string theme, DateTime dateDebut, DateTime dateFin)//Ville laVille,Campagne laCampagne)
        {
            this.id = id;
            this.theme = theme;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            //this.laVille=laVille;
            //this.laCampagne=laCampagne;
        }

        public Evenement(string theme, DateTime dateDebut, DateTime dateFin)//Ville laVille,Campagne laCampagne)
        {
            this.theme = theme;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            //this.laVille=laVille;
            //this.laCampagne=laCampagne;
        }


    }
}
