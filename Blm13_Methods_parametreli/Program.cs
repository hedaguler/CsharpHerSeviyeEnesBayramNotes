using System;

namespace Blm13_Methods_parametreli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3. sayıyı giriniz: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            // metodu çağır
            carpim(sayi1, sayi2, sayi3);


            ////////////////
            Console.WriteLine("******************");
            nameSurname("Heda" , " guler");
        }

        static void carpim(int sayi1, int sayi2, int sayi3)
        {
            Console.WriteLine("Üç sayının çarpımı = " + (sayi1 * sayi2 * sayi3));
        }
        //Console.Readline();

        static void nameSurname(string name, string surname)
        {
            Console.WriteLine("ich bin " + name + surname);
        }
    }
}
