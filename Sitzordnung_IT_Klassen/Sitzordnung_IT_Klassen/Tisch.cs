using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitzordnung_IT_Klassen
{
    public class Tisch
    {
        //Tischobjekt
        public Tisch()
        {
            throw new System.NotImplementedException();
        }

        ~Tisch()
        {
            throw new System.NotImplementedException();
        }

        public int AnzPlaetze
        {
            get => AnzPlaetze;
            set => AnzPlaetze = value;
        }

        public int Tischnr
        {
            get => Tischnr;
            set => Tischnr = value;
        }

        /* public Raum Raum
         {
             get { return Raum; }
             set { Raum = value; }
         } */
    }
}
