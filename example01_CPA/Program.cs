using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example01_CPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 3 tane not alan ve bu notların ortalamasını bulan ve ortalaması
            // eğer 80-100 arasındaysa A+ yazdıran
            // 60-80 arasındaysa A yazdıran
            // 40-60 arasındaysa B+ yazdıran
            // 40'dan küçükse F yazdıran örneğin kod parçalarını yazınız.

            Console.WriteLine("lütfen 1. notunuuzu giriniz");
            int birinci_not = Convert.ToInt32(Console.ReadLine());
            int ikinci_not = Convert.ToInt32(Console.ReadLine());
            int ucuncu_not = Convert.ToInt32(Console.ReadLine());

            int sonuc = (birinci_not + ikinci_not + ucuncu_not) / 3;

            if (sonuc > 80)
            {
                Console.WriteLine(" A+");
            }

            else if (sonuc > 60)
            {
                Console.WriteLine("A");
            }
            else if (sonuc > 40)
            {
                Console.WriteLine("B+");
            }
            else
            {
                Console.WriteLine("YOU FAİLED  F");
            }

            Console.ReadLine();

        }
    }
}
