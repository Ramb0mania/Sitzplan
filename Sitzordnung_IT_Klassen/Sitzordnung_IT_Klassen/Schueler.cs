using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitzordnung_IT_Klassen
{
    class Schueler
    {
        //Schülerobjekt
        public Schueler()
        {
            throw new System.NotImplementedException();
        }

        ~Schueler()
        {
            throw new System.NotImplementedException();
        }

        public int Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public int Vorname
        {
            get { return Vorname; }
            set { Vorname = value; }
        }

        public int Beruf
        {
            get { return Beruf; }
            set { Beruf = value; }
        }

        public int Betrieb
        {
            get { return Betrieb; }
            set { Betrieb = value; }
        }

        public int Geschlecht
        {
            get { return Geschlecht; }
            set { Geschlecht = value; }
        }
    }
}
