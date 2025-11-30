using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blm15_Encapsulation_propertyKullanimi
{
    public class Musteri
    {
        /*
        public int kilo;  //this is a field , variable 
        public int kilo2 { get; set; }
        //this is a property - wrench  get set açık halde yazılmadıysa field gibi davranır bu da
        */

        private int kilo; // kilo isminde değişkne tanımladık


        //prop tab tabla da oluşturalbilir :)
        // public int MyProperty { get; set; } bu şekilde kapalı hali , değişekn gibi davranan hali


        /*  //propertynin açık bir şekilde kullanımı 
        public int KİLO
        {
            get
            {
                return kilo;
            }
            set
            {
                //userın girmiş olduğu değeri value anhtar kelimesiyle yakalayacağım 
               
                    kilo = value;

            }
           
        }
        */

       
        //********************************************************************
       

        //porpertynin daha derli toplu ,kapalı kullanımı
        public int kilo1 { get; set; }
        public int kilo2;

    }
}
