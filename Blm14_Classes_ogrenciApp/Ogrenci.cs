using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blm14_Classes_ogrenciApp
{
    public class Ogrenci
    {
        private int ogrenciNo;
        private string isim;
        private string soyisim;

        private int vize1;
        private int vize2;
        private int final;

        private string okulIsmi;

        public Ogrenci(int _ogrenciNo,string _isim,string _soyisim,int _vize1,int _vize2,int _final,string _okulIsmi)
        {
            ogrenciNo = _ogrenciNo; 
            isim = _isim;   //tanımlamış olduğumuz ismi parametre olarak gelen isme ata
            soyisim = _soyisim;

            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulIsmi = _okulIsmi;

        }

        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("öğrenci number :" + ogrenciNo);
            Console.WriteLine("öğrenci isim : " + isim);
            Console.WriteLine("öğrenci soyisim : " + soyisim);
            Console.WriteLine("öğrenci vize1  : " + vize1);
            Console.WriteLine("öğrenci vize2  : " + vize2);
            Console.WriteLine("öğrenci  fianl: " + final);
            Console.WriteLine("öğrenci  okul ismi : " + okulIsmi);
        }

        public double ogrenciNotBul()
        {
          double ortalama =  vize1*0.2+vize2*0.2 + final*0.6;
            return ortalama;
        }

        public void okulGetir()
        {
            Console.WriteLine("Öğrencinin okul ismi :" + okulIsmi);
        }
    }
}
