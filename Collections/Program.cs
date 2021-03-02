using System;
using System.Collections.Generic; // List kullanmak için eklenmelidir

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5]; // ve bu şekilde isimler array'inin referans numarası değişti. Artık üstte tanımlanan değerler kullanılamaz
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);// İlker
            //Console.WriteLine(isimler[0]);// Boş



            //List<string> isimler2 = new List<string>();
            //isimler2.Add("Engin");  
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            
        }
    }
}
