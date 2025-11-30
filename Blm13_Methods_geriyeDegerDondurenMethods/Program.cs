using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blm13_Methods_geriyeDegerDondurenMethods
{
    internal class Program
    {
        /*
        static void Main(string[] args)
        {
            //parametre alan - geriye değer döndüren metot tanımlama
            //return anahtar kelimesi
            //metot sonu

            int donenDeger = toplamaYap(25, 35);

            if (donenDeger >10)
            {
                Console.WriteLine("10 dan büyük");
            }
            else
            {
                Console.WriteLine("10 dan küçüktür ");
            }
            Console.ReadLine();

        }

        static int toplamaYap(int sayi1 , int sayi2)
        {
            int sonuc = sayi1+ sayi2;

            return sonuc;
        }*/



        /// ///////////////////////////////////////////////////////////////////////

        static void Main(string[] args)
        {
            string GelenIsımSoyisimDegeri = isimSoyisimDondur("Heda", "  GÜLER");
            string GelenIsımSoyisimDegeri1 = isimSoyisimDondur("Hüma", "  GÜLER");
            Console.WriteLine(GelenIsımSoyisimDegeri);
            Console.WriteLine(GelenIsımSoyisimDegeri1);
            Console.ReadLine();
         
        }




        static int toplamaYap(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;

            return sonuc;
        }



        static string isimSoyisimDondur(string isim, string soyisiim)
        {
            return isim + soyisiim;
        }

    
    
 
    }
}
