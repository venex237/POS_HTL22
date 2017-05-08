using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkplatz
{
    class Program
    {
        public static int time = 0, timediff = 0, counter = 0, tmpcounter = 0;
        public static Auto auto;
        public static Auto[] Parkplätze = new Auto[30];
        public static bool[] frei = new bool[30]; 
        public static Queue Schlange = new Queue();
        static void Main(string[] args)
        {
            //setzte alle Parkplätze auf frei
            for (int i = 0; i < frei.Length; i++)
            {
                frei[i] = true;
            }
            Console.WriteLine("Parkplatz öffnet");
            while(time < 180)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Minute: " + time);
                //erste stunde -> autos kommen zum schranken
                
                if (time < 60)
                    Anstellen();
                //zweite Stunde -> autos kommen zum schranken
                if(time > 60)
                {
                    timediff++;
                    if (timediff == 10)
                        Anstellen();
                }
                //dritte stunde -> autos kommen zum schranken
                if(time > 120)
                {
                    timediff++;
                    if (timediff == 30)
                        Anstellen();
                }
                //Check ob Auto Ausparkt
                for (int i = 0; i < Parkplätze.Length; i++)
                {
                    if (Parkplätze[i] != null)
                    {
                        if (Parkplätze[i].endZeit < time)
                        {
                            tmpcounter++;
                            Ausfahren(i);
                        }
                    }
                }

                //Wenn auto in der Schlange und ein Parkplatzfrei dann Einfahren()
                if (Schlange.Count > 0)
                {
                    for (int x = 0; x < Schlange.Count; x++)
                    {
                        for (int i = 0; i < frei.Length; i++)
                        {
                            if (frei[i])
                            {
                                Einfahren(i);
                                frei[i] = false;
                                break;
                            }
                        }
                    }
                    
                }

                
                
                //alle 10 minuten ausgeben
                if(counter == 10)
                {
                    Console.WriteLine("Länge der Schlange: " + Schlange.Count);
                    Console.WriteLine("Anzahl der freien Parkplätze: " + countfreeplätze());
                    counter = 0;
                }
                //next minute
                counter++;
                time++;
            }
            Console.WriteLine("Parkplatz geschlossen");
            Console.ReadKey();
        }

        static void Anstellen()
        {
            Console.WriteLine("Auto stellt sich an bei Schlange");
            Schlange.Enqueue(new Auto(time));
        }
        static void Einfahren(int parkplatznummer)
        {
            Console.WriteLine("Auto fährt in den Parkplatz ein");
            Parkplätze[parkplatznummer] = (Auto)Schlange.Dequeue();
        }

        static void Ausfahren(int parkplatznummer)
        {
            Console.WriteLine("Auto verlässt den Parkplatz");
            Parkplätze[parkplatznummer] = null;
            frei[parkplatznummer] = true;
        }

        static int countfreeplätze()
        {
            int _frei = 0;
            foreach (bool parkplatz in frei)
            {
                if (parkplatz == true)
                    _frei++;
            }
            return _frei;
        }
    }
}
