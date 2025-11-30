using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blm14_Classes_ogrenciApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool kontrol = true;

            Ogrenci ogrenci1 = new Ogrenci(1,"heda","güler",89,100,67,"Selçuk Uni");

            Console.WriteLine("welcome to our application choose what you want to do ");
          

            while (kontrol) 
            {

                islemleriGoster();

                string secim = Console.ReadLine();


                //işlemleri göster string olduğu için case i de string olarak yazdık
                switch (secim)
                {
                    case "1":
                        ogrenci1.ogrenciBilgileriGoster();
                        break;

                    case "2":
                       double ogrenciOrtalama = ogrenci1.ogrenciNotBul();
                        Console.WriteLine("öğrenci ortalaması :" + ogrenciOrtalama);
                        break;

                    case "3":
                        ogrenci1.okulGetir();
                        break;

                    case "4":
                        Console.WriteLine("Programdan çıkılıyor...");

                        kontrol = false;
                        break;


                }
            }

            
        }

        static void islemleriGoster()
        {
            Console.WriteLine("1- öğrenci bilgilerini göster");
            Console.WriteLine("2- ort göster");
            Console.WriteLine("3- okulunu göster");
            Console.WriteLine("4- çıkış yap");
        }
    }
}
