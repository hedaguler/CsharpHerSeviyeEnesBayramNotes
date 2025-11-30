using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blm12_Arrays_DigerVeriTipleriyleTanımlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Enes", "Yasin", "Heda", "Kerem", "Hüma" };


            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[4]);

            Console.WriteLine();
            Console.WriteLine("------- alayını yazdırmak istersem -----------");
            Console.WriteLine();

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);  
            }


            Console.WriteLine();
            Console.WriteLine("------- ONDALIKLI ARRAY -----------");
            Console.WriteLine();

            double[] ondalikli_sayilar = { 1.44, 7.66, 8.34, 6.34 };
            for (int j = 0; j < ondalikli_sayilar.Length; j++)
            {
                Console.WriteLine(ondalikli_sayilar[j]);
            }

            Console.ReadLine();
        }
    }
}
