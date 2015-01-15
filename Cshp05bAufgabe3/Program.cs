using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cshp05bAufgabe3
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
        public void Anhaengen(string datenNeu)
        {
            // wenn das Ende erreicht ist, ein neues Element erzeugen
            if (naechster == null)
            {
                naechster = new Listenelement();
                naechster.SetDaten(datenNeu);
            }
            // sonst ruft sich die Methode selbst wieder auf
            else
                naechster.Anhaengen(datenNeu);

            // zur Veranschaulichung der Rekursion
            Console.WriteLine("Daten {0} wurden eingefügt.", datenNeu);

        }

        // die Methode zur Ausgabe der Liste
        // sie ruft sich ebenfalls rekursiv auf, bis das Ende erreicht ist
        public void Ausgeben()
        {
            Console.WriteLine(daten);
            if (naechster != null)
                naechster.Ausgeben();
        }
        // die Methode zur Ausgabe der Liste Rückwärts
        // sie ruft sich ebenfalls rekursiv auf, bis das Ende erreicht ist
        public void AusgebenRueckwaerts()
        {
            if (naechster != null)
                naechster.AusgebenRueckwaerts();
            Console.WriteLine(daten);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // ein neues Listenelement erzeugen
            Listenelement listenAnfang = new Listenelement();

            // die Daten im ersten Listenelement setzen
            listenAnfang.SetDaten("Element 1");

            // weitere Elemente in einer Schleife anfügen
            for (int element = 2; element < 4; element++)
            {
                listenAnfang.Anhaengen("Element " + element);
            }

            // die Liste ausgeben
            listenAnfang.AusgebenRueckwaerts();

        }
    }
}
