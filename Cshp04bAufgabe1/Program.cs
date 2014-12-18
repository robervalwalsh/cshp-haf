/* ######################################################
Einsendeaufgabe 4
###################################################### */
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
  
        // die Methode zum Berechnen des Volumens
        static int Volumen(Kiste aKiste)
        {
            int volWert;
            volWert = aKiste.Breite * aKiste.Laenge * aKiste.Hoehe;

            return volWert;
        }

        // die Methode zum Einlesen
        static void Eingeben(Kiste[] aKisten)
        {
            Console.Clear();
            Console.WriteLine("\n\tEingeben\n");

            int nummer;

            Console.Write("\tGeben Sie die Nummer der Kiste ein, zwischen 1 und 50: ");
            // die nummer ist index + 1
            nummer = Convert.ToInt32(Console.ReadLine());
            
            // Nummer ist gültig
            if (nummer >= 1 && nummer <= 50)
            {
                //
                if (aKisten[nummer-1].Nummer == 0)
                {
                    int hoehe, breite, laenge;

                    Console.Write("\tGeben Sie die Höhe der Kiste #{0} ein  : ", nummer);
                    hoehe = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\tGeben Sie die Länge der Kiste #{0} ein : ", nummer);
                    laenge = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\tGeben Sie die Breite der Kiste #{0} ein: ", nummer);
                    breite = Convert.ToInt32(Console.ReadLine());

                    if (hoehe <= 0 || breite <= 0 || laenge <= 0)
                    {
                        Console.WriteLine("\n\tMindestens eine Seite der Kiste ist Null oder Negative.");
                        Console.WriteLine("\tDie Kiste wird nicht gespeichert.");
                    }
                    else
                    {
                        aKisten[nummer-1].Nummer = nummer;
                        aKisten[nummer-1].Hoehe = hoehe;
                        aKisten[nummer-1].Breite = breite;
                        aKisten[nummer-1].Laenge = laenge;
                    }
                }
                else
                {
                    Console.WriteLine("\n\tDie Nummer {0} ist schon benutzt.", nummer);
                }
            }
            else
            {
                Console.WriteLine("\n\tDie eingegebene Nummer ist nicht gültig.");
            }

            // zurück zum Hauptmenu
            Console.Write("\nDrücken Sie eine beliebige Taste zum Hauptmenu...");
            Console.ReadKey();

        }      
 
        // die Methode eine Kiste zu Löschen
        static void Loeschen(Kiste[] aKisten)
        {
            Console.Clear();
            Console.WriteLine("\n\tLöschen\n");

            int nummer;

            Console.Write("\tGeben Sie die Nummer der Kiste ein, zwischen 1 und 50: ");
            nummer = Convert.ToInt32(Console.ReadLine());
           
            // Kiste ist gültig zu Löschen
            if ( nummer >= 1 && nummer <= 50)
            {
                if (aKisten[nummer-1].Nummer != 0)
                {
                    Console.WriteLine("\n\tDie Kiste mit der Nummer {0} wird gelöscht.", nummer);
                    aKisten[nummer-1].Nummer = 0;
                }
                else
                {
                    Console.WriteLine("\n\tEs gibt keine Kiste mit der Nummer {0} auf Lager.", nummer);
                }
            }
            else
            {
                Console.WriteLine("\n\tDer eingegebene Nummer ist nicht gültig.");
            }

            // zurück zum Hauptmenu
            Console.Write("\nDrücken Sie eine beliebige Taste zum Hauptmenu...");
            Console.ReadKey();

         }

        // die Methode zum Ändern
        static void Aendern(Kiste[] aKisten)
        {
            Console.Clear();
            Console.WriteLine("\n\tÄndern\n");

            int index;
            int nummer;

            Console.Write("\tGeben Sie die Nummer der Kiste ein, zwischen 1 und 50: ");
            // die nummer ist index + 1
            nummer = Convert.ToInt32(Console.ReadLine());
            index = nummer - 1;

            // Nummer ist gültig
            if (index >= 0 && index < 50)
            {
                //
                if (aKisten[index].Nummer != 0)
                {
                    int hoehe, breite, laenge;

                    Console.Write("\tGeben Sie die Höhe der Kiste #{0} ein  : ", index + 1);
                    hoehe = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\tGeben Sie die Länge der Kiste #{0} ein : ", index + 1);
                    laenge = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\tGeben Sie die Breite der Kiste #{0} ein: ", index + 1);
                    breite = Convert.ToInt32(Console.ReadLine());

                    if (hoehe <= 0 || breite <= 0 || laenge <= 0)
                    {
                        Console.WriteLine("\n\tMindestens eine Seite ist Null oder Negative.");
                        Console.WriteLine("\tDie Daten wird nicht geändert.");
                    }
                    else
                    {
                        aKisten[index].Nummer = index + 1;
                        aKisten[index].Hoehe = hoehe;
                        aKisten[index].Breite = breite;
                        aKisten[index].Laenge = laenge;
                    }
                }
                else
                {
                    Console.WriteLine("\n\tEs gibt keine Kiste mit der Nummer {0} auf Lager.", nummer);
                }
            }
            else
            {
                Console.WriteLine("\n\tDie eingegebene Nummer ist nicht gültig.");
            }

            // zurück zum Hauptmenu
            Console.Write("\nDrücken Sie eine beliebige Taste zum Hauptmenu...");
            Console.ReadKey();

        }

        // die Methode zum Anzeigen eine Kiste
        static void Anzeigen(Kiste[] aKisten)
        {
            Console.Clear();
            Console.WriteLine("\n\tAnzeigen\n");

            int nummer;

            Console.Write("\tGeben Sie die Nummer der Kiste ein, zwischen 1 und 50: ");
            // die nummer ist index + 1
            nummer = Convert.ToInt32(Console.ReadLine());

            // Nummer ist gültig
            if (nummer >= 1 && nummer <= 50)
            {
                //
                if (aKisten[nummer-1].Nummer != 0)
                {
                    // Kopf
                    Console.WriteLine();

                    Console.Write("\tKiste\n");
                    Console.Write("\tNummer");
                    Console.Write("\tHöhe");
                    Console.Write("\tLänge");
                    Console.Write("\tBreite");
                    Console.Write("\tVolumen");
                    Console.WriteLine("\n");

                    Console.Write("\t" + aKisten[nummer-1].Nummer);
                    Console.Write("\t" + aKisten[nummer-1].Hoehe);
                    Console.Write("\t" + aKisten[nummer-1].Laenge);
                    Console.Write("\t" + aKisten[nummer-1].Breite);
                    Console.Write("\t" + Volumen(aKisten[nummer-1]));
                    Console.WriteLine();
 
                }
                else
                {
                    Console.WriteLine("\n\tEs gibt keine Kiste mit der Nummer {0} auf Lager.", nummer);
                }
            }
            else
            {
                Console.WriteLine("\n\tDie eingegebene Nummer ist nicht gültig.");
            }

            // zurück zum Hauptmenu
            Console.Write("\nDrücken Sie eine beliebige Taste zum Hauptmenu...");
            Console.ReadKey();
        }

        // Listenfunktion
        static void Auflisten(Kiste[] aKisten)
        {
            Console.Clear();
            Console.WriteLine("\n\tAuflisten\n");

            int nReihe;

            Console.WriteLine();

            Console.Write("\tKiste\n");
            Console.Write("\tNummer");
            Console.Write("\tHöhe");
            Console.Write("\tLänge");
            Console.Write("\tBreite");
            Console.Write("\tVolumen");
            Console.WriteLine("\n");

            nReihe = 0;
            for (int index = 0; index < 50; ++index)
            {
                if (aKisten[index].Nummer != 0)
                {
                    Console.Write("\t" + aKisten[index].Nummer);
                    Console.Write("\t" + aKisten[index].Hoehe);
                    Console.Write("\t" + aKisten[index].Laenge);
                    Console.Write("\t" + aKisten[index].Breite);
                    Console.Write("\t" + Volumen(aKisten[index]));
                    Console.WriteLine();
                    ++nReihe;
                }
            }
            if (nReihe == 0)
            {
                Console.WriteLine("\tEs gibt keine Kiste auf Lager.");
            }

            // zurück zum Hauptmenu
            Console.Write("\nDrücken Sie eine beliebige Taste zum Hauptmenu...");
            Console.ReadKey();
        }
  
        // die Methode Main
        static void Main(string[] args)
        {
            // Console      
            Console.Title = "Lagerverwaltung";
            Console.ForegroundColor = ConsoleColor.White;

            // Vereinbarung der Variablen
            Kiste[] kisten = new Kiste[50];
         
            // Initialiesierung der Kistennummern
            for (int index = 0; index < 50; ++index)
                kisten[index].Nummer = 0;

            int menuWahl;
            //  while-Schleife des HauptMenus
            do
            {
                // das Menu
                Console.Clear();
                Console.WriteLine("\n\tHauptmenu\n");
                Console.WriteLine("\tSie haben folgende Auswahl:");
                Console.WriteLine("\t   1  Eingeben einer neuen Kiste");
                Console.WriteLine("\t   2  Löschen der Daten einer Kiste");
                Console.WriteLine("\t   3  Ändern der Daten einer Kiste");
                Console.WriteLine("\t   4  Anzeigen der Daten einer Kiste");
                Console.WriteLine("\t   5  Auflisten die Daten aller Kisten");
                Console.WriteLine("\t   6  Ende");
                Console.Write("\tWas möchten Sie tun? ");
                menuWahl = Convert.ToInt32(Console.ReadLine());
 
                switch (menuWahl)
                {
                    case 1:
                        Eingeben(kisten);
                        break;
                    case 2:
                        Loeschen(kisten);
                        break;
                    case 3:
                        Aendern(kisten);
                        break;
                    case 4:
                        Anzeigen(kisten);
                        break;
                    case 5:
                        Auflisten(kisten);
                        break;
                    default:
                        break;
                }
            } while (menuWahl != 6);

 
        }

    }
}
