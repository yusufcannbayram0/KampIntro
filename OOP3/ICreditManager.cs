using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // interface'leri birbirinin alternatifi olan fakat kod içerikleri farklı olan durumlar için kullanırız
    // interface - şablon görevi görmektedir
    interface ICreditManager // metot diğer kredilerde aynı fakat içerik farklı olunca bu class interface olarak kullanılır
    {
        void Calculate();
        void DoSomething();
    }
}


//loglama - sistemde olan hareketleri döktüğümüz dökümdür
