using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blm15_Encapsulation_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel p1 = new Personel();

            p1.TCKİMLİKNO = "12345678985";

            Console.WriteLine("tc kimlik numaranız : "+p1.TCKİMLİKNO + "***********");

            Console.ReadLine();

        }
    }
}
