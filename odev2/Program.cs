using System;

namespace odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Evler Ev1 = new Evler();
            Ev1.EvAdi = "Ahmet Erdem";
            Ev1.EvNo = 20;

            Evler Ev2 = new Evler();
            Ev2.EvAdi = "Mehmet Ali";
            Ev2.EvNo = 7;


            Evler[] evler = new[] { Ev1, Ev2 };
            //int i = 0;
            //while (1 < evler.Length)
            //{
            //    Console.WriteLine(evler[i].EvAdi + " " + evler[i].EvNo); i++;

            //}
            for (int j = 0; j <evler. length; j++)
            {
                Console.WriteLine(evler);
            }



        }
    }
}
