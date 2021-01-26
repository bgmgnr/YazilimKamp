using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 2;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;

                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;

                default:
                    break;





            }
        }
    }
}
