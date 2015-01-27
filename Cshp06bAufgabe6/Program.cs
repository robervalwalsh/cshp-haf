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

    // die Klasse Libelle erbt von der Klasse Insekt
    class Libelle : Insekt
    {
        int fluegellaenge;

        // der Konstruktor
        public Libelle(int laenge, int gewicht, int fluegellaenge) : base (laenge,gewicht)
        {
            this.fluegellaenge = fluegellaenge;
        }

        // die überschriebene Methode zum Essem
        public override void Essen()
        {
            laenge = laenge + 1;
            gewicht = gewicht + 1;
            fluegellaenge = fluegellaenge + 1;
        }

        // die überschriebene Methode zur Ausgabe
        public override void Ausgabe()
        {
            Console.WriteLine("Die Libelle ist {0} cm lang,  wiegt {1} Gramm und ihre Fügel sind {2} cm lang.", laenge, gewicht, fluegellaenge);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            // Insekt
            Console.WriteLine("Insekt");

            // Objekt der Basisklasse erzeugen
            Insekt insekt = new Insekt(2, 2);
            // Methoden aufrufen
            insekt.Ausgabe();
            insekt.Essen();
            insekt.Ausgabe();

            // Libelle
            Console.WriteLine();
            Console.WriteLine("Libelle");

            // Objekt der Basisklasse erzeugen
            Libelle libelle = new Libelle(2, 2, 4);
            // Methoden aufrufen
            libelle.Ausgabe();
            libelle.Essen();
            libelle.Ausgabe();

        }
    }
}
