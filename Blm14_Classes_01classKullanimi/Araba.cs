using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blm14_Classes_01classKullanimi
{
    public class Araba
    {
        public int kapiSayisi;
        public string arabaModel;
        public string arabaRengi;

        /* 
         //PARAMETRESİZ CONSTRUCTOR
        public Araba()
        {
            Console.WriteLine("araba sınıfının yapıcı metodu çalıştıı");
        }*/


        //PARAMETRELİ CONSTRUCTOR 
        public Araba(int _kapiSayisi,string _arabaModel ,string _arabaRengi)
        {
            kapiSayisi = _kapiSayisi;
            arabaModel = _arabaModel;
            arabaRengi = _arabaRengi;
        }


        public void motorCalistir()
        {
            Console.WriteLine("motor çalışıyor ");
        }

        public void kapilariKilitle()
        {
            Console.WriteLine("kapialr kilitleniiyor");
        }
    }
}
