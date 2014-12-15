/*
 Einsendeaufgabe 4
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cshp04bAufgabe1
{
    class Program
    {
        // die Vereinbarung der Struktur
        struct Kiste
        {
            public int Nummer;
            public int Hoehe;
            public int Breite;
            public int Laenge;

        }
  
        static void TasteDruecken()
        {
            Console.Write("\n\tDrücken Sie eine beliebige Taste zum Hauptmenu...");
            Console.ReadKey();
        }

        static void Meldung(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t" + msg);
            Console.ForegroundColor = ConsoleColor.White;
            TasteDruecken();

        }

        static void Hinweis(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\tHinweis: ");
            Console.WriteLine(msg+"\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        // das Hauptmenu
        static int HauptMenu()
        {
            Console.Clear();
            int menuWahl;

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tHauptmenu");
            Console.WriteLine("\t---------\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\tSie haben folgende Auswahl:");
            Console.WriteLine("\t   1. Eingeben einer neuen Kiste");
            Console.WriteLine("\t   2. Löschen der Daten einer Kiste");
            Console.WriteLine("\t   3. Ändern der Daten einer Kiste");
            Console.WriteLine("\t   4. Anzeigen der Daten einer Kiste");
            Console.WriteLine("\t   5. Auflisten die Daten aller Kisten");
            Console.WriteLine("\t   6. Ende");
            Console.Write("\tWas möchten Sie tun? ");
            menuWahl = Convert.ToInt32(Console.ReadLine());

            return menuWahl;
        }

        // Listenfunktion
        static void Listenfunktion(Kiste[] aKiste)
        {
            Console.Clear();

            // Titel
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tListe der Kisten im Lager");
            Console.WriteLine("\t-------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\tKiste");
            Console.Write("\tHöhe");
            Console.Write("\tLänge");
            Console.Write("\tBreite");
            Console.Write("\tVolumen");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;

            for (int index = 0; index < 50; ++index)
            {
                if (aKiste[index].Nummer != 0)
                {
                    Console.Write("\t" + aKiste[index].Nummer);
                    Console.Write("\t" + aKiste[index].Hoehe);
                    Console.Write("\t" + aKiste[index].Laenge);
                    Console.Write("\t" + aKiste[index].Breite);
                    Console.Write("\t" + Volumen(aKiste[index]));
                    Console.WriteLine();
                }
            }
            TasteDruecken();
        }
        
        // die Methode zum Einlesen
        static void Einlesen(Kiste[] aKiste)
        {
            int index;
            bool gueltig;

            Console.Clear();

            // Titel
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tEingabe einer neuen Kiste");
            Console.WriteLine("\t-------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\tGeben Sie die Nummer der Kiste ein, zwischen 1 und 50: ");
            // die nummer ist index + 1
            index = Convert.ToInt32(Console.ReadLine()) - 1;

            gueltig = false;
            // Nummer ist gültig
            if (index >= 0 && index < 50)
            {
                // Nummer ist noch nicht benutzt
                if (aKiste[index].Nummer == 0)
                    gueltig = true;
                else
                    Meldung("Nummer schon benutzt.");
            }
            else
            {
                Meldung("Die Nummer der Kiste ist nicht gültig.");
            }

           if (gueltig)
           {
                int hoehe, breite, laenge;

                Console.Write("\tGeben Sie die Höhe der Kiste #{0} ein  : ", index+1);
                hoehe = Convert.ToInt32(Console.ReadLine());

                Console.Write("\tGeben Sie die Länge der Kiste #{0} ein : ", index+1);
                laenge = Convert.ToInt32(Console.ReadLine());

                Console.Write("\tGeben Sie die Breite der Kiste #{0} ein: ", index+1);
                breite = Convert.ToInt32(Console.ReadLine());

                if (hoehe <= 0 || breite <= 0 || laenge <= 0)
                {
                    Meldung("Mindestens eine Seite ist Null oder Negative.\n\tDie Kiste wird nicht gespeichert.");
                }
                else
                {
                    aKiste[index].Nummer = index+1;
                    aKiste[index].Hoehe  = hoehe;
                    aKiste[index].Breite = breite;
                    aKiste[index].Laenge = laenge;
                }

            }
        }

        //
        static void Loeschen(Kiste[] aKiste)
        {
            int index;

            Console.Clear();

            // Titel
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tLöschen der Daten einer Kiste");
            Console.WriteLine("\t-----------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;

 
            Console.Write("\tGeben Sie die Nummer der Kiste ein, zwischen 1 und 50: ");
            index = Convert.ToInt32(Console.ReadLine())-1;

            // Kiste ist gültig zu Löschen
            if (index >= 0 && index < 50)
            {
                if (aKiste[index].Nummer != 0)
                    aKiste[index].Nummer = 0;
                else
                    Meldung("Die Kiste ist nich gespeichert. Nichts wird geändert.");
            }
            else
            {
                Meldung("Die Nummer der Kiste ist nicht gültig.");
            }

         }

        // die Methode zum Berechnen des Volumens
        static int Volumen(Kiste aKiste)
        {
            int volWert;
            volWert = aKiste.Breite * aKiste.Laenge * aKiste.Hoehe;

            return volWert;
        }

        static void Main(string[] args)
        {

            Console.Title = "Lagerverwaltung";
            Console.ForegroundColor = ConsoleColor.White;

            Kiste[] kiste = new Kiste[50];
            int hauptWahl;
            
            // Initialiesierung der Kistennummern
            for (int index = 0; index < 50; ++index)
                kiste[index].Nummer = 0;

            do
            {
                hauptWahl = HauptMenu();
                switch (hauptWahl)
                {
                    case 1:
                        Einlesen(kiste);
                        break;
                    case 2:
                        Loeschen(kiste);
                        break;
                    case 5:
                        Listenfunktion(kiste);
                        break;
                    default:
                        break;
                }
            } while (hauptWahl != 6);

            //// ein lokales Array kleineKiste für die
            //// Struktur Kiste
            //Kiste[] kleineKiste = new Kiste[3];

            //// das Einlesen der Daten über die Methode
            //// Einlesen()
            //for (int index = 0; index < 3; index++)
            //{
            //    kleineKiste[index] = Einlesen(index + 1);
            //}

            //// das BErechen über die Methode Volumen()
            //for (int index = 0; index < 3; index++)
            //{
            //    Console.WriteLine("Das Volumen von Kiste {0} ist: {1}", index + 1, Volumen(kleineKiste[index]));
            //}
        }

    }
}
