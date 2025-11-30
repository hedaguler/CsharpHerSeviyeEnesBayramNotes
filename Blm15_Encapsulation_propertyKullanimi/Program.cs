using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blm15_Encapsulation_propertyKullanimi
{
     class Program
    {
        static void Main(string[] args)
        {
            /*
            Musteri musteri1 = new Musteri();

            musteri1.KİLO = 70;  // değer atama yapılıyor set blokları çalışır
            
            
            Console.WriteLine(musteri1.KİLO);
            //eğer değer ataması yapmasaydım o zaman get blokları çalışırdı
            */


            Musteri m1 = new Musteri();
            m1.kilo1 = 85;
            m1.kilo2 = 87;

            Console.WriteLine("PROPERTY  olan kilo : " + m1.kilo1); //ingiziliz anahtarı yani property olan :)
            Console.WriteLine("DEGİŞKEN  olan kilo :  " + m1.kilo2); //külçe altın yani değişken olan :

            Console.ReadLine();
        }
    }
}
