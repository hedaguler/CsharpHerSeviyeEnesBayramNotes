using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blm15_Encapsulation
{
    public class Ogrenci
    {
        //publicte alayından erişilebiliyor
        //public string isim = "heda";

        private string isim;
        public void setIsim(string _isim)
        {
            isim = _isim;
        }

        public string getIsim()
        {
            return isim;
        }

    }
}
