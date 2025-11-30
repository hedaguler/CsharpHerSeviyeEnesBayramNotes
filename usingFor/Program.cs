using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //iç içe for kullanımı

            for (int i =0; i<=10; i++)
            {
                for (int j =1; j<=i; j++)
                {
                    Console.Write(j);
                }   
                Console.WriteLine(" ");
            }



            /*
            for(int i = 0; i <=10; i++) 
            {
              Console.WriteLine(i);
            }

            Console.WriteLine("*********************");

            for(int j = 0;j <=10 ;j=j+2)
            {
               Console.WriteLine(j);
            }
            */

            Console.ReadLine();
        }
    }
}
