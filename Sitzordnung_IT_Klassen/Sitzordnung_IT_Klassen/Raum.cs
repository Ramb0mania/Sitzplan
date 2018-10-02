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
            get { return AnzTische; }
            set { AnzTische = value; }
        }

        public int Name
        {
            get { return Name; }
            set { Name = value; }
        }
    }
}
