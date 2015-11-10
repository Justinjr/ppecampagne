using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GesCampagneBO;

namespace GesCampagneBO
{
    public class Event
    {
        private int id;
        private string theme;
        private DateTime dateDebut;
        private DateTime dateFin;
        private string sonNom;
        private string sonPrenom;

        public Event(string sonNom, string sonPrenom)
        {
            this.sonNom = sonNom;
            this.sonPrenom = sonPrenom;
        }

        private Ville laVille;
        private Campagne laCampagne;




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

        public Ville LaVille
        {
            get
            {
                return laVille;
            }

            set
            {
                laVille = value;
            }
        }

        public Campagne LaCampagne
        {
            get
            {
                return laCampagne;
            }

            set
            {
                laCampagne = value;
            }
        }

        public Event(int id,string theme,DateTime dateDebut,DateTime dateFin,Ville laVille,Campagne laCampagne)
        {
            this.id = id;
            this.theme = theme;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.LaVille=laVille;
            this.LaCampagne=laCampagne;
        }

        public Event(string theme, DateTime dateDebut, DateTime dateFin,Ville laVille,Campagne laCampagne)
        {
            this.theme = theme;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.LaVille=laVille;
            this.LaCampagne=laCampagne;
        }


    }
}
