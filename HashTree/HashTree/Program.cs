using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();
            List<Node> Nodes = new List<Node>();
            string line;
            int count = 0;
            string[] tmp = null;
            // Read the file and display it line by line.
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"input1.csv");
            while ((line = file.ReadLine()) != null)
            {
                tmp = line.Split(',');
                Students.Add(new Student(tmp[0], tmp[1], tmp[2], tmp[3], tmp[4]));
                Nodes.Add(new Node(Students[count].ToString()));

                count++;
            }
            file.Close();
            if (count % 2 != 0)
            {
                Console.WriteLine("one added ungerade");
                Students.Add(new Student(tmp[0], tmp[1], tmp[2], tmp[3], tmp[4]));
                Nodes.Add(new Node(Students[count].ToString()));
            }
            CreateBulk(Nodes);
            Console.ReadKey();
        }

        public static void CreateBulk(List<Node> Nodes)
        {
            Console.WriteLine("---------------------------------------------------------------");
            string hash1 = "", hash2 = "";
            bool preventdupli = false;
            int currentrow = 0, count = 0, totalhashed = 0;
            currentrow = Nodes.Count;
            Node newnode = null;
            for (int i = 0; i < Nodes.Count; i++)
            {
                count++;
                totalhashed++;
                if(i % 2 != 0)
                {
                    hash2 = Nodes[i].hash;
                    newnode = new Node(hash1 + hash2);
                    Nodes[i].parent = newnode;
                    Nodes[i - 1].parent = newnode;
                    Nodes.Add(newnode);
                }
                else
                {
                    hash1 = Nodes[i].hash;
                }
                if (!preventdupli)
                {
                    if (currentrow == count)
                    {
                        
                        currentrow = Nodes.Count - totalhashed;
                        
                        if (currentrow % 2 != 0)
                        {
                            Console.WriteLine("one added ungerade");
                            Nodes.Add(newnode);
                            currentrow++;
                            count = 0;
                            Console.WriteLine("---------------------------------------------------------------");
                        }
                        else
                        {
                            count = 0;
                            Console.WriteLine("---------------------------------------------------------------");
                        }
                        if (currentrow == 4)
                            preventdupli = true;
                    }
                }
            }
        }
    }
}
