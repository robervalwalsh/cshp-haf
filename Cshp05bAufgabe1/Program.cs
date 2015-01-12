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
            // muss mindestens einmal eingeschaltet werden, also fangen wir mit
            // dem Fernserher ausgeschaltet an
            eingeschaltet = false; 
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

        // Programm ändern - von 1 bis 1000 (realistische Begrenzung)
        public void Programm()
        {
            if (eingeschaltet)
            {
                int neuesProgramm;
                Console.Write("\n\tGeben Sie das neue Programm ein, zwischen 1 und 1000: ");
                // 
                neuesProgramm = Convert.ToInt32(Console.ReadLine());
                if (neuesProgramm > 0 && neuesProgramm <= 1000)
                    programm = neuesProgramm;
                // sonst, keine Veränderung
            }
        }

        // Lautstärke - von 0 bis 100 (realistische Begrenzung) 
        public void Lautstaerke()
        {
            if (eingeschaltet)
            {
                int neueLautstaerke;
                Console.Write("\n\tGeben Sie die neue Lautstaerke ein, zwischen 0 und 100: ");
                // 
                neueLautstaerke = Convert.ToInt32(Console.ReadLine());
                if (neueLautstaerke >= 0 && neueLautstaerke <= 100)
                    lautstaerke = neueLautstaerke;
                // sonst, keine Veränderung
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
                Console.Write("\n\n");
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

            // Ende des Programmes; muss ausgeschaltet werden
            bool ende;

            ende = false;
            while (!ende)
            {
                int menuWahl;

                // Eingeschaltetmenu
                while (fernseher.Eingeschaltet())
                {
                    Console.Clear();
                    fernseher.Zustand();
                    Console.WriteLine("\n\tMenu");
                    Console.WriteLine("\t====");
                    Console.WriteLine("\tSie haben folgende Auswahl:");
                    Console.WriteLine("\t1 Ausschalten");
                    Console.WriteLine("\t2 Ändern die Lautstärke");
                    Console.WriteLine("\t3 Ändern das Programm");
                    Console.Write("\tWas möchten Sie tun? ");
                    menuWahl = Convert.ToInt32(Console.ReadLine());
                    // die Menuwahl
                    switch (menuWahl)
                    {
                        case 1:
                            fernseher.Ausschalten();
                            break;
                        case 2:
                            fernseher.Lautstaerke();
                            break;
                        case 3:
                            fernseher.Programm();
                            break;
                        default:
                            break;
                    }
                }

                // Ausgeschaltetmenu
                while (!fernseher.Eingeschaltet() && !ende)
                {
                    Console.Clear();
                    fernseher.Zustand();
                    Console.WriteLine("\n\tMenu");
                    Console.WriteLine("\t====");
                    Console.WriteLine("\tSie haben folgende Auswahl:");
                    Console.WriteLine("\t1 Einschalten");
                    Console.WriteLine("\t2 Ende");
                    Console.Write("\tWas möchten Sie tun? ");
                    menuWahl = Convert.ToInt32(Console.ReadLine());
                    // die Menuwahl
                    switch (menuWahl)
                    {
                        case 1:
                            fernseher.Einschalten();
                            break;
                        case 2:
                            ende = true;
                            break;
                        default:
                            break;
                    }

                }


            }
            Console.WriteLine();

        }
    }
}
