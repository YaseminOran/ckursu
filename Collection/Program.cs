using System;
using System.Collections.Generic;

namespace Collection
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> names2 = new List<string> { "yas", "tay", "persi", "bitter" };

            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            //Console.WriteLine(names2[3]);
            names2.Add("öykü");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
        }
    }
}
