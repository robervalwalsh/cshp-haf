using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cshp05bAufgabe1
{
    // die Vereinbarung der Klasse Fernseher
    class Fernseher
    {

        // die Vereinbarung der Eigenschaften
        bool eingeschaltet;
        int lautstaerke;
        int programm;

        // die Methoden
        // Initialisierung
        public void Init()
        {
            eingeschaltet = false;  // muss mindestens einmal eingeschaltet werden
            lautstaerke = 20;
            programm = 1;
        }

        // zur Ein-/Ausschaltung
        public void Einschalten()
        {
            eingeschaltet = true;
        }
        public void Ausschalten()
        {
            eingeschaltet = false;
        }
        // Zustand
        public bool Eingeschaltet()
        {
            return eingeschaltet;
        }

        // Programm ändern - von 1 bis 1000
        public void Programm(int neuProgramm)
        {
            if (eingeschaltet)
            {
                if ( neuProgramm > 0 && neuProgramm <= 1000 )
                    programm = neuProgramm;
            }
        }

        // Lautstärke - von 0 bis 100
        public void Lautstaerke(int neuLaut)
        {
            if (eingeschaltet)
            {
                if ( neuLaut >= 0 && neuLaut <= 100 )
                    lautstaerke = neuLaut;
            }
        }

        public void Zustand()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n");
            Console.Write("\tZustand\n");
            Console.WriteLine("\t=======");
 
            if (eingeschaltet)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\tEIN\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tLautstärke\t{0}\n",lautstaerke);
                Console.Write("\tProgramm\t{0}\n", programm);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\tAUS\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\n\n");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Console
            Console.Title = "Fernseher";
            Console.ForegroundColor = ConsoleColor.White;
            
            Fernseher fernseher = new Fernseher();
            fernseher.Init();  // Fernseher ist ausgeschaltet (default)

            Console.Clear();
            fernseher.Zustand();

            bool ende;

            ende = true;
            do
            {
                // Muss mindestens einmal eingeschaltet werden

                // Frage zur Einschaltung
                Console.Write("\tDrucken Sie eine beliebige Taste, um den Fernseher einzuschalten.");
                Console.ReadKey();
                fernseher.Einschalten();

                int einMenuWahl;
                while (fernseher.Eingeschaltet())
                {
                    do
                    {
                        Console.Clear();
                        fernseher.Zustand();
                        Console.WriteLine("\n\tMenu");
                        Console.WriteLine("\t====");
                        Console.WriteLine("\tSie haben folgende Auswahl:");
                        Console.WriteLine("\t 1 Ausschalten");
                        Console.WriteLine("\t 2 Ändern die Lautstärke");
                        Console.WriteLine("\t 3 Ändern das Programm");
                        Console.Write("\tWas möchten Sie tun? ");
                        einMenuWahl = Convert.ToInt32(Console.ReadLine());
                        // die Menuwahl
                        switch (einMenuWahl)
                        {
                            case 1:
                                fernseher.Ausschalten();
                                break;
                            case 2:
                                fernseher.Lautstaerke(10);
                                break;
                            case 3:
                                fernseher.Programm(10);
                                break;
                            default:
                                break;
                        }

                    } while (einMenuWahl != 1);
                }
            } while (!ende);

        }
    }
}
