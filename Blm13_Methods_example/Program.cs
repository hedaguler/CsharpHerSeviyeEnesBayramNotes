using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blm13_Methods_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //userdan 2 tane sayi alalım hangi sayi büyükse o ekrana yazsın

            Console.Write("1.sayıyı girniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2.sayıyı girniz");
            int sayi2 =Convert.ToInt32(Console.ReadLine());

            kontrolEt(sayi1,sayi2);

            Console.ReadLine();


        }
        
        static void kontrolEt(int a,int b)
        {
            if(a > b)
            {
                Console.WriteLine("1. sayı 2. sayıdan büyüktür");
            }
            else if (a==b)
            {
                Console.WriteLine("1. sayi 2. sayıya eşittir");
            }
            else
            {
                Console.WriteLine("2. sayı 1. sayıdan büyüktür");

            }
        } 
    }
}
