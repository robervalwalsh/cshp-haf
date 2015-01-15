/* ######################################################
Einsendeaufgabe 5.2
###################################################### */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cshp05bAufgabe2
{
    // die Klasse für die Listenelement
    // jetzt auch mit Methoden

    class Listenelement
    {
        string daten;
        Listenelement naechster;

        // die Methode zum Setzen der Daten
        public void SetDaten(string datenNeu)
        {
            // die Zeichenkette setzen
            daten = datenNeu;

            // das Ende markieren
            naechster = null;

        }

        // die Methode zum Anhängen eines neuen Elements
        // sie ruft sich rekursiv auf, bis das Ende erreicht ist
        // Zurücklieferung des Endes der Liste
        public Listenelement Anhaengen(string datenNeu)
        {
            // wenn das Ende erreicht ist, ein neues Element erzeugen
            if (naechster == null)
            {
                naechster = new Listenelement();
                naechster.SetDaten(datenNeu);
                // naechster ist das lezte Elemente und wird zurückgeliefert
            }
            // sonst ruft sich die Methode selbst wieder auf
            // jetzt passiert es nur, falls Anhaengen nicht von listenEnde aufgeruft wird,
            // wie z.B. listenAnfang.Anhaengen(...)
            else
            {
                naechster.Anhaengen(datenNeu);
            }

            // zur Veranschaulichung der Rekursion
            Console.WriteLine("Daten {0} wurden eingefügt.", datenNeu);
            return naechster;
        }


        // die Methode zur Ausgabe der Liste
        // sie ruft sich ebenfalls rekursiv auf, bis das Ende erreicht ist
        public void Ausgeben()
        {
            Console.WriteLine(this.daten);
            if (naechster != null)
                naechster.Ausgeben();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // ein neues Listenelement erzeugen
            Listenelement listenAnfang = new Listenelement();
            Listenelement listenEnde = new Listenelement();

            // die Daten im ersten Listenelement setzen
            listenAnfang.SetDaten("Element 1");
            // jetzt sind Ende und Anfang gleich
            listenEnde = listenAnfang;

            // weitere Elemente in einer Schleife anfügen
            for (int element = 2; element < 4; element++)
            {
                // neue Elemente werden direkt am Ende der Liste angehängt
                listenEnde = listenEnde.Anhaengen("Element " + element);
            }

            listenAnfang.Ausgeben();
        }
    }
}
