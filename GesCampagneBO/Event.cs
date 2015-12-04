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
        private Theme theme;
        private DateTime dateDebut;
        private DateTime dateFin;
        private string sonNom;
        private string sonPrenom;
        

        public Event(string sonNom, string sonPrenom)
        {
            this.sonNom = sonNom;
            this.sonPrenom = sonPrenom;
        }

        private Campagne laCampagne;
        private Ville laVille;
        




        public int Id
        {
            get { return id; }
            set { id = value; }
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

        public Theme Theme
        {
            get
            {
                return theme;
            }

            set
            {
                theme = value;
            }
        }

        public Event(int id,Theme theme,DateTime dateDebut,DateTime dateFin,Campagne laCampagne, Ville laVille)
        {
            this.id = id;
            this.Theme = theme;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.LaVille=laVille;
            this.LaCampagne=laCampagne;
        }

        public Event(Theme theme, DateTime dateDebut, DateTime dateFin,Campagne laCampagne, Ville laVille)
        {
            this.Theme = theme;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.LaVille=laVille;
            this.LaCampagne=laCampagne;
        }


    }
}
