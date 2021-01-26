using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Kampı";
            string kurs2 = "Programlamaya BAşlangıç için Temel Kurs";
            string kurs3 = "Java Kursu";
            string kurs4 = "Python";

            //array
            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı", 
                "Programlamaya BAşlangıç için Temel Kurs", 
                "Java Kursu","Python Kursu", "c++ Kursu" };


            for (int i = 0; i <kurslar.Length; i++)//i+=2
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);//kurslarda kurs u yazdır dön.
            }
            Console.WriteLine("foreach bitti.");


            int k = 0;
            while (k < kurslar.Length)
            {
                Console.WriteLine(kurslar[k]);
                k++;
            }





            Console.WriteLine("sayfa sonu.");
        }
    }
}
