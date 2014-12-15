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
  
        //
        static void TasteDruecken()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nDrücken Sie eine beliebige Taste zum Hauptmenu...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        // Titel
        static void Title(string msg)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("\t"+msg);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        // das Hauptmenu
        static int HauptMenu()
        {
            Console.Clear();

            Title("Hauptmenu");

            int menuWahl;

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
            Title("Liste der Kisten im Lager");

            int nReihe;

            // Kopf
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\tKiste");
            Console.Write("\tHöhe");
            Console.Write("\tLänge");
            Console.Write("\tBreite");
            Console.Write("\tVolumen");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;

            nReihe = 0;
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
                    ++nReihe;
                }
            }
            if (nReihe == 0)
            {
                Console.WriteLine("\tEs gibt keine Kiste auf Lager.");
            }
            TasteDruecken();
        }
        
        // die Methode zum Einlesen
        static void Einlesen(Kiste[] aKiste)
        {
            Title("Eingabe einer neuen Kiste");

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
                if ( aKiste[index].Nummer == 0 )
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
                        Console.WriteLine("\n\tMindestens eine Seite der Kiste ist Null oder Negative.\n\tDie Kiste wird nicht gespeichert.");
                    }
                    else
                    {
                        aKiste[index].Nummer = index + 1;
                        aKiste[index].Hoehe = hoehe;
                        aKiste[index].Breite = breite;
                        aKiste[index].Laenge = laenge;
                    }
                }
                else
                {
                    Console.WriteLine("\n\tDie Kiste Nummer {0} ist schon benutzt.",nummer);
                }
            }
            else
            {
                Console.WriteLine("\n\tDie eingegebene Nummer der Kiste ist nicht gültig.");
            }
            TasteDruecken();
 
        }

        // die Methode zum Ändern
        static void Aendern(Kiste[] aKiste)
        {
            Title("Ändern der Daten einer Kiste");

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
                if ( aKiste[index].Nummer != 0 )
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
                        Console.WriteLine("\n\tMindestens eine Seite ist Null oder Negative.\n\tDie Daten wird nicht geämdert.");
                    }
                    else
                    {
                        aKiste[index].Nummer = index + 1;
                        aKiste[index].Hoehe = hoehe;
                        aKiste[index].Breite = breite;
                        aKiste[index].Laenge = laenge;
                    }
                }
                else
                {
                    Console.WriteLine("\n\tDie Kiste Nummer {0} ist nicht benutzt.\n\tKeine Daten zum Ändern.",nummer);
                }
            }
            else
            {
                Console.WriteLine("\n\tDie eingegebene Nummer der Kiste ist nicht gültig.");
            }
            TasteDruecken();

        }


        // die Methode eine Kiste zu Löschen
        static void Loeschen(Kiste[] aKiste)
        {
            Title("Löschen der Daten einer Kiste");

            int index;
            int nummer;

            Console.Write("\tGeben Sie die Nummer der Kiste ein, zwischen 1 und 50: ");
            nummer = Convert.ToInt32(Console.ReadLine());
            index = nummer - 1;

            // Kiste ist gültig zu Löschen
            if (index >= 0 && index < 50)
            {
                if (aKiste[index].Nummer != 0)
                {
                    Console.WriteLine("\n\tDie Kiste mit dem Nummer {0} wird gelöscht.", nummer);
                    aKiste[index].Nummer = 0;
                }
                else
                {
                    Console.WriteLine("\n\tEs gibt keine Kiste mit dem Nummer {0}.", nummer);
                }
            }
            else
            {
                Console.WriteLine("\n\tDer eingegebene Nummer der Kiste ist nicht gültig.");
            }
            TasteDruecken();

         }

        // die Methode zum Berechnen des Volumens
        static int Volumen(Kiste aKiste)
        {
            int volWert;
            volWert = aKiste.Breite * aKiste.Laenge * aKiste.Hoehe;

            return volWert;
        }

        // die Methode Main
        static void Main(string[] args)
        {
            // Vereinbarung der Variablen
            Kiste[] kisten = new Kiste[50];
            int hauptWahl;

            // Console 
            Console.Title = "Lagerverwaltung";
            Console.ForegroundColor = ConsoleColor.White;

            
            // Initialiesierung der Kistennummern
            for (int index = 0; index < 50; ++index)
                kisten[index].Nummer = 0;

            //  while-Schleife des HauptMenus
            do
            {
                hauptWahl = HauptMenu();
                switch (hauptWahl)
                {
                    case 1:
                        Einlesen(kisten);
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
                        Listenfunktion(kisten);
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
