using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLM14_Classes02_Public_Private
{
    public class Musteri
    {
        public string isim;
        public string soyisim;
        public string maasDegeri;
        public string cinsiyet;

        private string yas;

        public Musteri()
        {
            Console.WriteLine("müşteri classının constructorı çalıştı ");
        }

        public void musteriBilgilerGoster()
        {
            Console.WriteLine("ismi:" + isim);
            Console.WriteLine("surname : " +  soyisim);
            Console.WriteLine("salary :" + maasDegeri);
            Console.WriteLine("male / female :" +  cinsiyet);
            Console.WriteLine("age : " + yas);
        }

        //method or değişkeniniz private ise 
        //bunlara sadece tanımlanmış olduğu class scope u içinen erişebiliriz
        //burdaki örnekte mesela "yas" değişkenine ve "IsimSoyisimYazdır" metoduna sadece Musteri classı içinden erişilebilir mesela


        private void IsimSoyisimYazdır(string musterIisim, string musteriSoyisim)
        {
            Console.WriteLine("Müşteri isim ve soyisim:" + musterIisim + " " + musteriSoyisim);
        }
    }
}
