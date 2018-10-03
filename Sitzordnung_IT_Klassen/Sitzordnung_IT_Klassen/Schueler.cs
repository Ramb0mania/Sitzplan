using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitzordnung_IT_Klassen;

namespace Sitzordnung_IT_Klassen
{
    class Schueler
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Beruf { get; set; }
        public string Betrieb { get; set; }
        public string Geschlecht { get; set; }
        public int Sitzplatz { get; set; }

        //Schülerobjekt
        public Schueler(String name, String vorname, String beruf, String betrieb, String geschlecht)
        {
            this.Name       = name;
            this.Vorname    = vorname;
            this.Beruf      = beruf;
            this.Betrieb    = betrieb;
            this.Geschlecht = geschlecht;
        }
        
        //Hier wurde Wasserzeichen-Methode(~) gelöscht

        public void SetName(string name)
        {
            this.Name = name;
        }

        public void SetVorname(string vorname)
        {
            this.Vorname = vorname;
        }

        public void SetBeruf(string beruf)
        {
            this.Beruf = beruf;
        }

        public void SetBetrieb(string betrieb)
        {
            this.Betrieb = betrieb;
        }

        public void SetGeschlecht(string geschlecht)
        {
            this.Geschlecht = geschlecht;
        }

        public void SetSitzplatz(int s)
        {
            this.Sitzplatz = s;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetVorname()
        {
            return Vorname;
        }

        public string GetBeruf()
        {
            return Beruf;
        }

        public string GetBetrieb()
        {
            return Betrieb;
        }

        public string GetGeschlecht()
        {
            return Geschlecht;
        }
    }
}
