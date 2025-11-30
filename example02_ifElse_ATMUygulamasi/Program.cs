using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example02_ifElse_ATMUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1907;
            // Kullanıcıya soracağız nasıl bir işlem yapmak istediğini
            // 1- Bakiye Görüntüleme
            // 2- Para Çekme
            // 3- Para Yatırma
            // q ya basarsa çıkış yaptıracağız.

            Console.WriteLine("ATM ye hoşgeldiniz");
            Console.WriteLine("Yapmak istediğiniz işelmi seçiniz");
            String secim = Console.ReadLine(); // ReadLine defaultu string türdedir

            if (secim == "1")
            {
                Console.WriteLine("mevcut bakiyeniz : " + bakiye);

                Console.ReadLine();
            }
            
            else if(secim == "2")  // 22. satırda seçimi string türünden userdan aldığımız için burda da string 
            {
                Console.WriteLine("çekmek istediğiniz tutarı giriniz");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                if(cekilecek_tutar <= bakiye)
                {
                   Console.WriteLine("Kalan tutar = " + (bakiye - cekilecek_tutar));
                }

                else
                {
                    Console.WriteLine("bakiye aşıldı");
                }
               

                Console.ReadLine(); // hemen yukardaki if ve else in ortak readline ı :)

            }

            else if (secim == "3") 
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz :");
                int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yeni Bakiyeniz " + (bakiye +yatirilacak_tutar));

                Console.ReadLine();

            }

            else if (secim == "q")
            {
                Console.WriteLine("ATM den çıkış yapılıyor");
                Console.WriteLine("Çıkış yapıldı yine bekleriz");
                Console.ReadLine();

            }

            else
            {
                Console.WriteLine("geçerli değer giriniz");
                Console.ReadLine();

            }
        }
    }
}
