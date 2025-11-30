using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 ÖDEV: Personelimizin TC kimlik numarasını alacağız ve şu kontrollerin yapılmasını istiyoruz.

SET ŞARTLARI

TC KİMLİK NO’su 11 karakter olmalı

Tüm karakterleri sayısal karakter olmalı

GET ŞARTI

TC kimlik numarasının ilk 5 karakterini alacağız, hepsini değil.
*/

namespace Blm15_Encapsulation_odev
{
    public class Personel
    {
        private string tckimlikno;
        public string TCKİMLİKNO  //this is a PROPERTY
        {
            get
            { //ilk 5 karakteri alcağız
                return tckimlikno.Substring(0,5);
            }

            set
            {
                bool kontrol = false;
                if(value.Length==11)
                {
                    for(int i=0 ; i < value.Length; i++)
                    {
                        //userın girmiş olduğu i. indekse değer number mı isNumber
                       bool sayiMi = char.IsNumber(value[i]);//1233567
                        if(sayiMi )
                        {
                            //yapmam gerekn bir şey yok 
                        }
                        else
                        {
                            kontrol = true;
                            break; //sayı dışında bir değer geldiğinde direk döngüden çık
                        }
                    }
                    if (kontrol)
                    {
                        Console.WriteLine("lütfen tc kimlik no içinde sadece sayı kullanınız");
                    }
                    else
                    {
                        tckimlikno = value;
                    }
                }
                else
                {
                    Console.WriteLine("girdiğiniz tc no 11 karakter değil");
                }
            }
         } 
    }
}
