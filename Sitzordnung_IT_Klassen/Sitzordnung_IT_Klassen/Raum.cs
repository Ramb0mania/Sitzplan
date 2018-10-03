using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitzordnung_IT_Klassen
{
    class Raum
    {
        //Raumobjekt für GUI
        List<Schueler> t1 = new List<Schueler>();
        List<Schueler> t2 = new List<Schueler>();
        List<Schueler> t3 = new List<Schueler>();
        List<Schueler> t4 = new List<Schueler>();
        List<Schueler> t5 = new List<Schueler>();

        public Raum()
        {
            throw new System.NotImplementedException();
        }

        ~Raum()
        {
            throw new System.NotImplementedException();
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
        public void AddToTisch(Schueler schueler, int Tischnr)
        {
            switch (Tischnr)
            {
                case 1:
                    t1.Add(schueler);
                    break;
                case 2:
                    t2.Add(schueler);
                    break;
                case 3:
                    t3.Add(schueler);
                    break;
                case 4:
                    t4.Add(schueler);
                    break;
                case 5:
                    t5.Add(schueler);
                    break;
            }
}
    }
}
