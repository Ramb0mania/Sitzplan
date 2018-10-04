using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitzordnung_IT_Klassen;

namespace Sitzordnung_IT_Klassen
{
    class Raum
    {
        //Raumobjekt für GUI
        public static List<Schueler> schuelerListe = new List<Schueler>();


        public Raum()
        {
        }
        public int AnzTische
        {
            get => AnzTische;
            set => AnzTische = value;
        }

        public int Name
        {
            get => Name;
            set => Name = value;
        }
    }
}
