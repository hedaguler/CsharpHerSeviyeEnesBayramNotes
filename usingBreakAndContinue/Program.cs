using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingBreakAndContinue
{
    internal class Program
    {

        // break 7 olduğu an çık bir daha ardına bakmadan :)
        //static void Main(string[] args)
        //{
        //  for (int a =1; a<=10; a++)
        //    {
        //        if (a==7)
        //        {
        //            break;
        //        }
        //        Console.WriteLine("a nın değeri :" + a);
        //    }
        //  Console.ReadLine();
        //}


        // continue de 7 ye eşitse atla 

        static void Main(string[] args)
        {
            for (int a = 1; a <= 10; a++)
            {
                if (a == 7)
                {
                    continue;
                }
                Console.WriteLine("a nın değeri :" + a);
            }
            Console.ReadLine();
        }

    }
}
