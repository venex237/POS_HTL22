using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashTree
{
    class Node
    {
        public string hash;
        public string childhash;
        public Node parent = null;

        public Node(string Studentinfo)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                childhash = Studentinfo;
                hash = GetMd5Hash(md5Hash, childhash);
                Console.WriteLine("Hash: " + hash);
                Console.WriteLine("Childhash: " + childhash);
                Console.WriteLine();
            }
        }

        public Node()
        { }
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
