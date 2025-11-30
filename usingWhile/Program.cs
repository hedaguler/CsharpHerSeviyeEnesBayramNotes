using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //1 den 10 a kadar olan sayılar
            int a = 1;
            while (a <= 10)
            {
                Console.WriteLine(a);
                a++;
            }
            */

            // 100 den sıfıra kadar olan sayıların çift olanlarını büyükten küçüğe yazdır

            int b = 100;

            while(b >=0 )
            {
                Console.WriteLine(b);
                b=b-2;
                //b -=2;  de aynı şey üst satırdakiyle
            }

            Console.ReadLine();
        }
    }
}
