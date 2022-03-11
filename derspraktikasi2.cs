using System;

namespace ders
{
    class Program
    {
        //https://youtu.be/GWxMTvRGIpc
        //jira haqqinda baxdigim videonun linki
        static void Main(string[] args)
        {
            //int qiymetler = SumMassiveElements(1, 2, 3, 4);
            //Console.WriteLine(qiymetler);
            //Console.WriteLine(Subtract(10));
            Console.WriteLine(Sum(5,6,3));
            
        }
        static int SumMassiveElements(params int[] arr)
        {
            int sum = 0;
            foreach( var item in arr)
            {
                sum += item;
            }
            return sum;
        }
        static int Subtract( int num1 , int num2=1)
        {
            return num1 - num2;
        }
        static int Sum( int num1)
        {
            return 1;
        }
        static int Sum( params int[] arr)
        {
            return 0;
        }
    }
}
