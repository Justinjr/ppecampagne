using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GesCampagneBO
{
    public class Message
    {
        private int id;
        private string corps;
        private DateTime date;
        CategorieVip laCategorieVip;
        Event lEvent;

    // Constructeurs
        public Message(int id, string corps, DateTime date, CategorieVip laCategorieVip, Event lEvent)
        {
            this.id = id;
            this.corps = corps;
            this.date = date;
            this.laCategorieVip = laCategorieVip;
            this.lEvent = lEvent;
        }
        public Message(string corps, DateTime date, CategorieVip laCategorieVip, Event lEvent)
        {
            this.corps = corps;
            this.date = date;
            this.laCategorieVip = laCategorieVip;
            this.lEvent = lEvent;
        }
    // Accesseurs en lecture/écriture
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
        public string Corps
        {
            get
            {
                return corps;
            }

            set
            {
                corps = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
        public CategorieVip LaCategorieVip
        {
            get
            {
                return laCategorieVip;
            }

            set
            {
                laCategorieVip = value;
            }
        }
        public Event LEvent
        {
            get
            {
                return lEvent;
            }

            set
            {
                lEvent = value;
            }
        }

    }
}
