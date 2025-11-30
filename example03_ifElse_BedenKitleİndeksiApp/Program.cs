using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example03_ifElse_BedenKitleEndeksiApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Beden Kitle İndeksi = Kilo / boy*boy
            // Beden kitle indeksi 18'e eşit veya düşükse ZAYIF
            // 18 ile 25 arasındaysa NORMAL
            // 25'ten büyükse OBEZ yazdıran program parçasını kodlayınız

            Console.WriteLine("Kilonuzu giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Plesade enter your height");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bke = kilo /( boy * boy);

            if (bke > 25 )
            {
                Console.WriteLine("obezsiniz bki niz  :  " + bke );
                Console.ReadLine();
            }

            else if (bke > 18 )
            {
                Console.WriteLine("normalsiniz bke niz :  " + bke);
                Console.ReadLine();

            }

            else if (bke <= 18)
            {
                Console.WriteLine("zayıfsınız bkeniz : " + bke);
                Console.ReadLine();

            }     

        }
    }
}
