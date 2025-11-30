using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blm13_Methods_methodOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greetings();
            writeYourName();
            Greetings();

        }

        static void Greetings()
        {
            Console.WriteLine("Hallo ");
        }

        static void writeYourName()
        {
            Console.WriteLine(" Heda :) ");
        }
    }
}
