using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety-tip güvenliği
            //do not repeat yourself -kendin tekrarlama

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            //double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("sabit"); 
            }
            //if (sistemeGirisYapmisMi == true)
            //{
            //    Console.WriteLine("kullanıcı ayarları butonu ");
            //}
            //else
            //{
            //    Console.WriteLine("giriş yap butonu");
            //}
            //Console.WriteLine(kategoriEtiketi);

            
        }
    }
}
