using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blm12_Arrays_forEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Enes", "Heda", "Kerem", "Hüma" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //ondalikli versiyon

            double[] ondalikli = { 1.2,3.4,6,7,5.6 };

            foreach (double x in ondalikli)
            {
                Console.WriteLine(x);
            }

        }
    }
}
