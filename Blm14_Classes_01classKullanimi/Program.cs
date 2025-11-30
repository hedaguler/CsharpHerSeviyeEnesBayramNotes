using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blm14_Classes_01classKullanimi
{
     class Program
    {
        static void Main(string[] args)
        {
            /*
            int kapiSayisi = 4;
            string arabaModeli = "M5";
            string arabaRengi = "black";
            */


            Araba araba1 = new Araba(4,"M5","BLACK");  // burdaki araba1 bizim referansımızın ismi

            Console.WriteLine("Color of car : " + araba1.arabaRengi);
            Console.WriteLine("Model of the car : " + araba1.arabaModel);
            Console.WriteLine("Number of car doors" + araba1.kapiSayisi);

            /*
            //Araba classındaki değişkenlere değer atadık aşağıda 
            araba1.kapiSayisi = 4;f
            araba1.arabaRengi = "mavi";
            araba1.arabaModel = "BMW";
            */


            araba1.kapilariKilitle();
            araba1.motorCalistir();

            /*
            Console.WriteLine("Arabanın Kapi Sayisi : " + araba1.kapiSayisi);
            Console.WriteLine("Cars color is " + araba1.arabaRengi);
            Console.WriteLine("Arabanın modeli : " + araba1.arabaModel);
            */

            Console.ReadLine();

        }
    }
}
