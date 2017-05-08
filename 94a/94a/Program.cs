//Markus Tröstler
//5AHIF
//22.03.2017
//2ter POS Test
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _94a
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Schüler> Schüler = new List<Schüler>();
            //2-dim array für zusammengehörige Ankunftszeiten und aussteigende Schüler
            int[,] S80 = new int[,] { { 632, 200 },{ 709, 300 }, { 732, 400 } };
            int Startzeit = 600, Endzeit = 800;
            int time = Startzeit;
            while(time < Endzeit)
            {
                //Nächste stunde beginnt
                if (time == 660)
                    time = 700;
                //Nächste Stunde beginnt
                if (time == 760)
                    time = 800;

                for (int i = 0; i < S80.Length / 2; i++)
                {
                    //Wenn die zeit mit der ankunftszeit übereinstimmt dann kommt ein Zug an
                    if (time == S80[i, 0])
                    {
                        //Console.WriteLine("S80 kommt an");
                        //S80 kommt an --> Schüler steigen aus
                        for (int x = 0; x < S80[i, 1]; x++)
                        {
                            //Schüler in die Liste hinzufügen
                            Schüler.Add(new Schüler());
                        }
                    }
                }
                //Schüler beginnen zu gehen
                {
                    foreach (var _schüler in Schüler)
                    {
                        //Ankunftszeit der Schüler veringert sich um eine Minute
                        _schüler.ankunft--;
                    }
                }

                //Wartende Schüler ermitteln --> Ankunftszeit < 1
                int warten = 0;
                for (int x = 0; x < Schüler.Count; x++)
                {
                    //Wenn die Ankunftszeit unter 1 Minute beträgt --> Bei Busstation
                        if (Schüler[x].ankunft < 1)
                        {
                        //Dieser Schüler Wartet bei der Busstation
                        warten++;

                        }
                }

                //Bus kommt erst ab 630
                if (time >= 630)
                {
                    int inbus = 0;
                    if (time % 6 == 0)
                    {
                        //Console.WriteLine("Bus kommt");
                        int anz = Schüler.Count - 1;
                        for (int x = anz; x > -1; x--)
                        {
                            if (inbus < 72)
                            {
                                if (Schüler[x].ankunft < 1)
                                {
                                    //Dieser Schüler Wartet bei der Bus Station
                                    //Schüler steigt in den Bus ein 
                                    inbus++;
                                    Schüler.RemoveAt(x);

                                }
                            }
                        }
                    }
                }
                //Ausgabe beginn bei 6.30
                if (time >= 630)
                {
                    //Ausgabe alle 10 Minuten
                    if (time % 10 == 0)
                    {
                        Console.WriteLine("Time: " + time + "  " + "Wartende Schüler bei der Busstation: " + warten);
                    }
                }
            time++;
            }
            Console.ReadKey();
        }
    }
}
