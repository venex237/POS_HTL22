using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball_Simulation
{
    class Program
    {
        public static int Grenzex = 1;
        public static int Grenzey = 1;
        public static Random randX = new Random();
        public static Random randY = new Random();
        public static int StartPosMin = 40;
        public static int StartPosMax = 60;
        public static int speedmin = -5;
        public static int speedmax = 5;
        public static int counter = 0;
        public static Dictionary<int, string> Bälle = new Dictionary<int, string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Anzahl der Bälle:");
            int azBälle = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < azBälle+1;i++)
            {
                string StartPos = Zufallszahl(StartPosMin, StartPosMax);
                string Speed = Zufallszahl(speedmin, speedmax);
                string build = StartPos+";"+Speed;
                Bälle.Add(i,build);
                counter++;
            }
            while(true)
            {
                for (int i = 1; i < counter; i++)
                {
                    Set(i,counter);
                }
            }
        }
        static string Zufallszahl(int min, int max)
        {
            string build = "";
            int x = randX.Next(min, max+1);
            int y = randX.Next(min, max+1);
            build = x + ";" + y;
            return build;
        }
        public static void Set(int key, int count)
        {
            string value = "";
            foreach (var s in Bälle)
            {
                if (s.Key == key) value = s.Value;
            }
            int speedx;
            int speedy;
            string builder = "";
            string[] split = value.Split(';');
            Grenzex = Convert.ToInt32(split[0]) + Convert.ToInt32(split[2]);
            Grenzey = Convert.ToInt32(split[1]) + Convert.ToInt32(split[3]);
            speedx = Convert.ToInt32(split[2]);
            speedy = Convert.ToInt32(split[3]);
            builder = Grenzex + ";" + Grenzey + ";" + speedx + ";" + speedy;
            if (Bälle.ContainsKey(key))
            {
                Bälle[key] = builder;
            }
            Check(Grenzex, key);
            Check(Grenzey, key);
        }
        static void Check(int prüfe, int key)
        {
            if (prüfe>=100 || prüfe <= 0)
            {
                foreach (var s in Bälle)
                {
                    string[] split = s.Value.Split(';');
                    Console.WriteLine(s.Key+". Ball: X=("+split[0]+") Y=("+split[1]+")");
                }
                foreach (var x in Bälle)
                {
                    if (x.Key == key)
                    {
                        Console.WriteLine("- - - - - BALL "+key+" HAT GEWONNEN - - - - -");
                        Console.ReadLine();
                    }
                }
            }
        }

    }
}
