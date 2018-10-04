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
        List<Schueler> t1;
        List<Schueler> t2;
        List<Schueler> t3;
        List<Schueler> t4;
        List<Schueler> t5; 

        public Raum()
        { 
            t1 = new List<Schueler>();
            t2 = new List<Schueler>();
            t3 = new List<Schueler>();
            t4 = new List<Schueler>();
            t5 = new List<Schueler>();
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
        public static void AddSchueler(Schueler schueler)
        {
            schuelerListe.Add(schueler);
        }
    }
}
