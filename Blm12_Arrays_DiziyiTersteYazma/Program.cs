using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blm12_Arrays_DiziyiTersteYazma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 4, 5, 3, 2, 5, 6, 8, 3, 2, 4, 4, 5, 7, 8, 9, 4, 12, 1, 3, 3, 4, 5, 5, 5, 5 };

            Console.WriteLine("Dizinin çift elemanlarınınn tersten yazılışı: ");

            
            for (int i = sayilar.Length - 1; i >= 0 ; i--)
            {
                if (sayilar[i] %2 == 0)
                {
                    Console.Write(sayilar[i] + " ");

                }
            }

            Console.ReadLine();
        }
    }
}
