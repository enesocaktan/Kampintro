using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Kamp";
            string kurs2 = "Programlamaya başlangıç temel kurs";
            string kurs3 = "Java";
            //array - dizi liste halinde olan birden fazla stringi tutmaya yarayan yer

            string[] kurslar = new string[] { "Yazılım Geliştirici Kamp" , 
                "Programlamaya başlangıç temel kurs","Java","fotoshop" };


            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            //foreach dizileri tek tek (kolay) dolaşmaya yarar
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu");
        }
    }
}
