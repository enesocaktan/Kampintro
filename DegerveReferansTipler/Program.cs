using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1??
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]
            Console.WriteLine(sayilar1[0]);

            //sayısal veri tipleri : int,decimal,float,double,bool =bunlar değer tipdir.
            //array,class,interface bunlar referenstipdir.

            //bellekte 
            // ---stack----                                     ---heap---- olarak iki yer var.
            //değer tip olanlar stackda gerçekleşiyo            
            //Örn:sayi1=10
            //say2=30


            // ---stack----                                     ---heap---- olarak iki yer var.
            // 101/sayilar1                                       101/[10,20,30]
            //102/sayilar2                                        102/[100,200,300] 
            //sayılar1'in referans numarasını sayilar2'ye atar o yüzden cevap 999.


        }
    }
}
