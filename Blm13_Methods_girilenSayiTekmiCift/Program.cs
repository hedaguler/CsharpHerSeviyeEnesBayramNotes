using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blm13_Methods_girilenSayiTekmiCift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int girilenSayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("girdiğiniz sayi" + girilenSayi);

            tekmiCiftmi(girilenSayi);

            Console.ReadLine();
        }

        static void tekmiCiftmi(int sayi)
        {
            if(sayi%2== 0)
            {
                Console.WriteLine("sayi çift");

            }
            else
            {
                Console.WriteLine("sayi tek");
            }
        }
    }
}
