using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bm16_01staticMetodKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //staic kullanılmayan verse de isimSoyisimYazdiri çağırmak için nesen oluşturmamız gerekiyordu
            //bu metodu kullanmak istediğimizde

            Personel P1 = new Personel();
            P1.isimSoyisimYazdir();
        }
    }
}
