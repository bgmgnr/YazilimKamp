using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Ali", "Ayşe", "Ceren","Zeynep" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //5.elemanı getiremeyiz array in sınırı 4 elemanlık.

            //isimler = new string[5] 5 elemanllı yeni string yaptık.
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]); ilkeri verir ama Console.WriteLine(isimler[0]);-->boş olur


            List<string> isimler2 = new List<string> { "Ayşe","Veli", "Ceren"};
            //isimler2.Add("ayşe"); 
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);



        }
    }
}
