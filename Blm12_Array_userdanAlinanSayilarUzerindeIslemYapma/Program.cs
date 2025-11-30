using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blm12_Array_userdanAlinanSayilarUzerindeIslemYapma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 10 tane int değer alan ve şunları yapan programı kodlayınız...
            // 1- Kaç adet tek , çift eleman olduğunu
            // 2- Çift değerlerin toplamını , Tek değerlerin toplamını
            // 3- Son olarak kontrol yapsın çift değerlerin toplamı tek değerlerden büyükse çift değerlerin toplamı büyüktür yazdırsın.
            // eğer teklerin toplamı büyükse => tek değerlerin toplamı büyüktür yazdırsın ...


            int ciftSayisi = 0;
            int tekSayisi = 0;

            int tekToplam = 0;
            int ciftToplam = 0;



            for (int i = 0; i < 10; i++)
            {
                Console.Write((i+0) +". indekse sayi giriniz  : ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi % 2 == 0)
                {
                    ciftSayisi++;
                    ciftToplam += sayi;

                }
                else
                {
                    tekSayisi++;
                    tekToplam += sayi;
                
                }
            }
             


            
            

            if (ciftToplam > tekToplam)
            {
                Console.WriteLine("cift toplam büyüktür......");
            }
            else
            {
                Console.WriteLine("tek toplam büyüktür.");
            }

            Console.WriteLine("Toplam çift sayısı   : " + ciftSayisi);
            Console.WriteLine("Toplam tek sayısı    : " + tekSayisi);
            Console.WriteLine("Çift sayıların toplamı: " + ciftToplam);
            Console.WriteLine("Tek sayıların toplamı : " + tekToplam);


        }
    }
}


