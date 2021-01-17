using System;

namespace MusteriTakip
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Yasemin";
            musteri1.MusteriSoyadi = "ARSLAN";
            musteri1.Id = 1234567;


            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Tayfun";
            musteri2.MusteriSoyadi = "ARSLAN";
            musteri2.Id = 163284;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Öykü";
            musteri3.MusteriSoyadi = "ORAN";
            musteri3.Id = 31273;


            Musteri musteri4 = new Musteri();
            musteri4.MusteriAdi = "Bitter";
            musteri4.MusteriSoyadi = "ARSLAN";
            musteri4.Id = 136472364;

            Musteri musteri5 = new Musteri();
            musteri5.MusteriAdi = "Persi";
            musteri5.MusteriSoyadi = "ARSLAN";
            musteri5.Id = 6274824;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

            foreach (Musteri  musteri in musteriler)

            {
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriSoyadi);
                Console.WriteLine(musteri.Id);
                Console.WriteLine("----------------------------------");

            }

            Console.WriteLine("----------Metotlar---------");
            musteriManager musteriManager = new musteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri3);
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);
            musteriManager.Listele(musteri4);
            musteriManager.Listele(musteri5);





         




         }
    }
}
