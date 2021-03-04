using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ResidenceCreditManager : ICreditManager // yapmamızın sebebi konut kredide'de hesapla metot'u olmasını istememiz
    {
        // classlar interface'lerden iplementasyon edilmelidir.
        public void Calculate()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı Hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
