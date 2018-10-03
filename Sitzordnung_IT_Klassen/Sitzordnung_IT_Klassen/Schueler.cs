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
        public Schueler(String name, String vorname, String beruf, String betrieb, String geschlecht)
        {
            this.Name = name;
            this.Vorname = vorname;
            this.Beruf = beruf;
            this.Betrieb = betrieb;
            this.Geschlecht = geschlecht;
        }

        ~Schueler()
        {
            throw new System.NotImplementedException();
        }

        public string Name { get { return Name; } set { Name = value; } }

        public string Vorname
        {
            get { return Vorname; }
            set { Vorname = value; }
        }

        public string Beruf
        {
            get { return Beruf; }
            set { Beruf = value; }
        }

        public string Betrieb
        {
            get { return Betrieb; }
            set { Betrieb = value; }
        }

        public string Geschlecht
        {
            get { return Geschlecht; }
            set { Geschlecht = value; }
        }
    }
}
