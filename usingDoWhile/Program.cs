using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // do + TAB TAB kendi otomatik tamamlar 

            //do while da while daki koşul hiç sağlanmasa bile en az bir kere do ya girmiş olur 
            // yani do en az bir kere çalışır deriz

            /*//1'den 10'a kadar olan sayıları ekrana yazdırınız. (do while ile)
            int a = 1;
            do
            {
                Console.WriteLine(a);
                a++;
            } 
            
            while (a<=10);
            */


            /*//1 den 100 e kadar olan sayılar
            int a = 1;  
            do
            {
                Console.WriteLine(a = a );
                a++;
            }
            
            while (a<=100);
            */

            /*// 1'den 100'e kadar olan sayıların toplamını ekrana yazdırınız. (do while ile);

            int a = 1;
            int toplam = 0;
            do
            {
                toplam += a;
                a++;

            }while (a<=100);
            Console.WriteLine("1 den 100 e kadar olan sayıların toplamı :" + toplam);
            */

            Console.ReadLine();
        }
    }
}
