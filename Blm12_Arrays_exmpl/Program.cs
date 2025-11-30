using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blm12_Arrays_exmpl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcının girdiğ sayının diziinin içinde var mı ?
            //kontrol eden varsa kaç tane olduğunu söyleyen yoksa da yoktur diye uyaran programı yazınız

            int[] sayilar = { 1, 2, 4, 5, 3, 2, 5, 6, 8, 3, 2, 4, 4, 5, 7, 8, 9, 4, 12, 1, 3, 3, 4, 5, 5, 5, 5 };
            int adet = 0;
            int sayi;


            Console.Write("Lütfen bir sayı giirniz : ");

            sayi = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayi == sayilar[i])
                {
                    adet++;
                }
            }

            if (adet==0)
            {
                Console.WriteLine("Girdiğiniz değer dizide bulunamadı");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı dizide bulundu ... ");
                Console.WriteLine("Adet : " +  adet);

            }


            Console.ReadLine();
        }
    }
}
