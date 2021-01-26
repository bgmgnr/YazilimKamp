using System;

namespace DegerVeReferansTips
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; //sayilar birin pointerı sayilar2 ye gitti. sayi2 nin 0.elemanı 999 sa 
                                 //sayi1 in 0. elemanı da 999 olur. adresler aynı.
            sayilar2[0] = 999; //sayilar1[0] = 999


        }
    }
}
