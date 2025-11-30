using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayıIstatistikleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç tane sayı gireceksiniz? : ");
            int adet = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[adet];

            // Kullanıcıdan sayıları alma
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write((i + 1) + ". sayıyı girin: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Başlangıç değerleri
            int toplam = 0;
            int min = sayilar[0];
            int max = sayilar[0];

            // İstatistikleri hesaplama
            for (int i = 0; i < sayilar.Length; i++)
            {
                int deger = sayilar[i];

                toplam += deger;          // toplamı güncelle

                if (deger < min)          // en küçük güncelle
                {
                    min = deger;
                }

                if (deger > max)          // en büyük güncelle
                {
                    max = deger;
                }
            }

            double ortalama = (double)toplam / sayilar.Length;

            Console.WriteLine();
            Console.WriteLine("----- İstatistikler -----");
            Console.WriteLine("Toplam     : " + toplam);
            Console.WriteLine("Ortalama   : " + ortalama);
            Console.WriteLine("En küçük   : " + min);
            Console.WriteLine("En büyük   : " + max);

            Console.ReadLine();
        }
    }
}
