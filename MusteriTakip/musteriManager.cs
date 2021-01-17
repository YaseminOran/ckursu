using System;
namespace MusteriTakip
{
    class musteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri ADI EKLENDİ : " + musteri.MusteriAdi);
            Console.WriteLine("MÜŞTERİ SOYADI EKLENDİ : " + musteri.MusteriSoyadi);
            


        } 
     
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri ADI SİLİNDİ : " + musteri.MusteriAdi);
            Console.WriteLine("Müşteri SOYADI SİLİNDİ : " + musteri.MusteriSoyadi);

        }

        public void Listele (Musteri musteri)
        {

            Console.WriteLine("Müşteri ID'si Listelendi: " + musteri.Id);

        }
        
    }
}
