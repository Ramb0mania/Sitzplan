using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitzordnung_IT_Klassen
{
    class Schueler
    {
        private string Name         { get; set; }
        private string Vorname      { get; set; }
        private string Beruf        { get; set; }
        private string Betrieb      { get; set; }
        private string Geschlecht   { get; set; }
        private int    Sitzplatz    { get; set; }

        //Schülerobjekt
        public Schueler(String name, String vorname, String beruf, String betrieb, String geschlecht)
        {
            this.Name = name;
            this.Vorname = vorname;
            this.Beruf = beruf;
            this.Betrieb = betrieb;
            this.Geschlecht = geschlecht;
        }
        
        //Hier wurde Wasserzeichen-Methode(~) gelöscht
    }
}
