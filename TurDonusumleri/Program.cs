using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region int -> byte
            /*
            int a = 5;

            byte b =(byte)a;    // int tipteki a yı byte tipine çevir 

            Console.WriteLine("type is " + b.GetType());      // GetType ile b nin türünü yazdıralım
            Console.WriteLine(b);
            Console.ReadLine();
            */

            #endregion


            #region string -> int

            /*
             * bunun çıktısı 12 olur çünkü 2 string i toplamak demek yan yana yazmak demektir
            string sayi1 = "1";
            string sayi2 = "2";

            Console.WriteLine(sayi1 + sayi2);
            Console.ReadLine();
            */


            /*
             * çıktısı 3 tür
            string sayi1 = "1";
            string sayi2 = "2";

            int a = int.Parse(sayi1);  //sayi1 değişkenimi al int a  ya  dönüştür parse ile
            int b = int.Parse(sayi2);  //sayi2 değişkenimi al int b ye  dönüştür parse ile

            Console.WriteLine( a + b);
            Console.ReadLine();
            */



            #endregion


            #region string -> int Convert ToInt32 ile
            /*
             string sayi1 = "1";
             string sayi2 = "2";


             int a = Convert.ToInt32(sayi1);
             int b = Convert.ToInt32(sayi2);

             Console.WriteLine(a + b);
             Console.ReadLine();
            */
            #endregion

            #region int -> string 
            /*
            //çoktı 510 olur
            int sayi1 = 5;
            int sayi2 = 10;


            string a = sayi1.ToString();
            string b  = sayi2.ToString();

            Console.WriteLine(a + b);
            Console.ReadLine();
            */
            #endregion

            #region double -> int 

            /*
            // çıktı
            // 5
            //System.Double   
            // olur

            double sayi = 5.22;

            int a = Convert.ToInt32(sayi);

            Console.WriteLine(a);
            Console.WriteLine(sayi.GetType());
            Console.ReadLine();
            */

            #endregion


            #region KULLANICIDAN ALINAN DEĞERLER STRİNG TÜRDE OLUR 

            /*
            // yani userın girdiği değerle işlem yapmak istiyorsak onu string olmaktan bi kurtarmamız lazım :)

            Console.WriteLine("Lütfen yaşınızı giriniz.");
            string kullanici_yas = Console.ReadLine();

            int kullanici_yasInt = int.Parse(kullanici_yas);   //inte dönüştürmenin 1. yolu
            int kullanici_yasInt2 = Convert.ToInt32(kullanici_yas);          //inte dönüştürmenin 2. yolu

            Console.WriteLine(kullanici_yasInt);
            Console.WriteLine(kullanici_yasInt2 +  "  yaşındasın");
            Console.ReadLine();
            */

            #endregion

            #region userdan 2 tane sayı alan ve ikisinin toplamını yazdıran program 
            /*
            Console.WriteLine("Birinci sayıyı giriniz");
            string sayi1 = Console.ReadLine();

            Console.WriteLine("İkinci sayıyı girniz");
            string sayi2 = Console.ReadLine();

            int sayiInt = int.Parse(sayi1);
            int sayiInt2 = int.Parse(sayi2);

            Console.WriteLine("iki sayının toplamı :" + (sayiInt + sayiInt2));
            Console.ReadLine();
            */
            #endregion

        }
    }
}
