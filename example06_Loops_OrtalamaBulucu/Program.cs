using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example06_Loops_OrtalamaBulucu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // userdan bir sayı alacağız 0 dan  başlayıp aşdığımız sayıya kadar toplayacağız 
            //ve girdiği sayıyı bölecceğiz eğer ortalama 50 den büyükse ort 50 den büyüktür
            // değilse ort 50 den küçüktür yazdırsın


            Console.Write("Kaç sayı gireceksiniz: ");
            int adet = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;

            for (int i = 0; i < adet; i++)
            {
                Console.Write($"{i + 1}. sayıyı girin: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                
                toplam = toplam + sayi;  //toplam += sayi; de olabilirdi bu satır
            }

            float ortalama = (float)toplam / adet;

            Console.WriteLine("Ortalama: " + ortalama);

            if (ortalama > 50)
            {
                Console.WriteLine("Ort. 50'den büyüktür.");
            }
            else
            {
                Console.WriteLine("Ort. 50'den küçüktür.");
            }

            Console.ReadLine();

        }
    }
}
