using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // çarpım tablosu örneği 

            for (int i = 1; i <= 10; i++)  // 100 kere çalışır bu for döngüsü
            {
                for (int j=1; j<= 10; j++) //10*10 dan 100 kere çalışır 10 un 10 katı
                {
                    Console.WriteLine(i + "x" + j + "=" + (i * j));

                }

            }

            Console.ReadLine();

        }
    }
}
