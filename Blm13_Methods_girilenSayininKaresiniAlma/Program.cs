using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blm13_Methods_girilenSayininKaresiniAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //userdan aldığımız sayının karesini alalım 
            //karesi >  25
            //karesi < 25 yazdıralım

            Console.WriteLine("sayi giriniz");

            int sayi = Convert.ToInt32(Console.ReadLine());


            int kare = kareAl(sayi);

            if (kare > 25)
            {
                Console.WriteLine("karesi = " + kare +"  25 ten büyük ");
            }
            else
            {
                Console.WriteLine("karesi = " + kare + "    25 ten küçük ");

            }

            Console.ReadLine();
           
        }


        static int kareAl(int sayi)
        {
            int sonuc = sayi * sayi;
            return sonuc;
        }


        /*
         
        // işi metodun hallettiği hali :)

        static void Main(string[] args)
        {
            Console.Write("Sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            kareAl(sayi);

            Console.ReadLine();
        }

        static int kareAl(int sayi)
        {
            int sonuc = sayi * sayi;

            if (sonuc > 25)
                Console.WriteLine("karesi > 25");
            else
                Console.WriteLine("karesi < 25");

            return sonuc;
        }*/




    }
}
