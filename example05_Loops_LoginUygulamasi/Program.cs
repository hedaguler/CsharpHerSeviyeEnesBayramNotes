using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example05_Loops_LoginUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctUser = "heda";
            string correctPass = "1234";

            int hak = 3;

            bool girisBasarili = false;

            while(hak > 0 && girisBasarili == false) 
            {
                Console.WriteLine("username giriniz : ");
                string user = Console.ReadLine();

                Console.WriteLine("şifrenizi giriniz  : ");
                string pass = Console.ReadLine();

                if (user == correctUser && pass == correctPass)
                {
                    Console.WriteLine("Welcome " + user);
                    girisBasarili=true;
                }

                else
                {
                    hak--;
                    Console.WriteLine("Hatalı Giriş ! " + " " + hak + "Hakkın kaldı");
                }
            }

            if(girisBasarili == false)
            {
                Console.WriteLine("Hakkınız doldu, giriş başarısız!");
            }

            Console.ReadLine();
        }
    }
}
