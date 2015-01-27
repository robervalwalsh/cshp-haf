/* ######################################################
Einsendeaufgabe 6.6
###################################################### */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cshp06bAufgabe6
{
    class Insekt
    {
        protected int laenge;
        protected int gewicht;

        // der Konstruktor
        public Insekt(int laenge, int gewicht)
        {
            this.laenge = laenge;
            this.gewicht = gewicht;
        }

        // die Methode zum Essem
        public virtual void Essen()
        {
            laenge = laenge + 1;
            gewicht = gewicht + 1;
        }

        // die Methode zur Ausgabe
        public virtual void Ausgabe()
        {
            Console.WriteLine("Das Insekt ist {0} cm lang und wiegt {1} Gramm.", laenge, gewicht);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Insekt kleinInsekt = new Insekt(2, 2);

            kleinInsekt.Ausgabe();
        }
    }
}
