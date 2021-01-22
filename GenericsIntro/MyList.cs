using System;
namespace GenericsIntro
{
    public class MyList<T> //ben mylisttimde T ile çalışacağım demek.Type demek ve ne dersek onu kullanmada özgürlük
    {
        T[] items;

        //constructor
        public MyList()
        {
            items = new T[0];


        }

        public void Add(T item)
        {
            T[] tempArray = items; // elemanları başka birine geçici olarak emanet ettim.
            //şimdi bir artırabilirim.//dizi sayısı arttıkça bir önce eklenen kaybolmasın diye
            items = new T[items.Length + 1];// eleman sayısı 0'dı. sayıyı bir artırdım
            for (int i = 0; i < tempArray.Length; i++)//emanet verdiklerimizi geri almak istiyoruz
            {
                items[i] = tempArray[i];

            }

            items[items.Length - 1] = item; //son dizi numarasına eleman ekleme. -1 son elemanı göstermek için


        }
        public int Length
        {
            get

            {
                return items.Length;

            }

        }
    }
}