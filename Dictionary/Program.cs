using System;
using System.Collections.Generic;

namespace Dictionary
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(134, "Yasemin ARSLAN");
            Ogrenci.Add(158, "Tayfun ARSLAN");
            Ogrenci.Add(115, "Bitter");
            Ogrenci.Add(174, "Persi");
            Console.Write("Öğrenci No Giriniz:");
            int No = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Ogrenci[No]);
            }
            catch
            {
                Console.WriteLine("Öğrenci Bulunamadı.");
            }


        }
    }
}
