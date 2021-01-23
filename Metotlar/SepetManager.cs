using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax- yazım şekilleri
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Sepete Eklendi!");
            Console.WriteLine("tebrikler.sepete eklendi : " + urun.Adi);
          
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokadedi)
        {
            Console.WriteLine("tebrikler sepete eklendi : " + urunAdi);
        }
    }
}
