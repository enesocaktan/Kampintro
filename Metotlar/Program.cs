using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Program
    {
       static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Armut";
            urun1.Fiyati = 25;
            urun1.Aciklama = "bal elma";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 60;
            urun2.Aciklama = "Kelek karpuz";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("...............");
            }

            Console.WriteLine("..............Metotlar..................");
           

            SepetManager sepetManager = new SepetManager();
            //instance- örnek
            //encapsulation
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            //sepetManager.Ekle();
            //sepetManager.Ekle();
            //sepetManager.Ekle();
            //sepetManager.Ekle();

            sepetManager.Ekle2("Armut", "bal elma", 25,10);
            sepetManager.Ekle2("Elma", "Amasya Elması", 15,9);
            sepetManager.Ekle2("Karpuz", "Kelek karpuz", 60,8);


             



















        }
    }
}
