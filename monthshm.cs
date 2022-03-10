using System;

namespace task7

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($" months : ");
            int months = Convert.ToInt32(Console.ReadLine());
            switch (months)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("qisdir");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("yazdir");
                   break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaydir");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("payizdir");
                    break;


            }
            





        }

    }
}
