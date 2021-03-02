using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>//T -> type'ın T si (değişken) MyList'te T ile çalışıcaz
    {
        T[] items;// T tipinde array oluşturuyoruz
        public MyList() // constructor ( class'ı bir yerde newlersek constructor otomatik çalışır)
        {
           items = new T[0]; // Array'in newlenme zorunluluğu vardır. Bundan dolayı class'ı newlediğimiz zaman array 0 elemanlı olarak başlar

        }
        public void Add(T item) // kullanıcı class'a hangi veri tipini verirse eklemede o veri tipi kullanılır
        {
            T[] tempArray = items; // gecici dizi 
            items = new T[items.Length + 1]; // değişken newlendiği için referans numarası gider ve değerde gider bundan dolayı bir üstte geçiçi dizi kullanılır
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // array gecici diziden emanet değerlerini geri aldı.
            }
            items[items.Length - 1] = item; // gelen eleman eklendi
        }
    }
}
