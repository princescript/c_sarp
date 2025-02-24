using System;
using System.Diagnostics.CodeAnalysis;


namespace Methods17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 04;
            //SimpleMethod(ref i);
            //Console.WriteLine(i);

            //int Sum;
            //Calculate(12, 25, out Sum);
            //Console.WriteLine(Sum);

           int total = AcceptAll(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Console.WriteLine(total);
        }

        //public static void SimpleMethod(ref int j)
        //{
        //    j = 800;
        //}

        //public static void Calculate(int p1 ,int p2 , out int Sum)
        //{
        //    Sum = p1 + p2;
        //}

        public static int AcceptAll(params int[] numbers)
        {
            int sum =0;
            foreach (int item in numbers)
            {
               sum = sum+ item; 
            }
            return sum;
        }
    }
}
