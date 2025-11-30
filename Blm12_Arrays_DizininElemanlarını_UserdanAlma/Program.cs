using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blm12_Arrays_DizininElemanlarını_UserdanAlma
{
    internal class Program
    {
        //Console.ReadLine ile userdan alınan değerler defaultta string olarak alınıyordu
        //userdan aldığım veriyi string dışında kullanılacaksa ya da atancaksa CASTING yapmak lazım

        static void Main(string[] args)
        {
            int[] sayilar = new int[4];

            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("Sayilar Dizisinin" + (i + 0) + ". index değerini giriniz : ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("************");

            for(int i = 0;i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadLine();
        }
    }
}
