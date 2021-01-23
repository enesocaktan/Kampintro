using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "enes";
            int yas = 36;

            kurs kurs1 = new kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Enes OCAKTAN";
            kurs1.İzlenmeOrani = 24;


            kurs kurs2 = new kurs();
            kurs2.KursAdi = "java";
            kurs2.KursunEgitmeni = "ahmet OCAKTAN";
            kurs2.İzlenmeOrani = 25;


            kurs kurs3 = new kurs();
            kurs3.KursAdi = "python";
            kurs3.KursunEgitmeni = "mehmet OCAKTAN";
            kurs3.İzlenmeOrani = 26;

            kurs [] kurslar = new kurs[] {kurs1, kurs2 ,kurs3};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursunEgitmeni);
            }

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursunEgitmeni);
            Console.WriteLine("Hello World!" );
        }
    }

    class kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int İzlenmeOrani { get; set; }



    }
}
