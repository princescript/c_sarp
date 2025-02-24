using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Methods16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EvenNumbers();
            Program p = new Program();
            p.EvenNumbers(50);
            Console.WriteLine("Breakpoint");

            Console.WriteLine(p.AddNumbers(20, 54));
        }
        public int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
        public /*static*/ void EvenNumbers(int Target)
        {
            int Start = 0;
            while (Start <= Target)
            {
                Console.WriteLine(Start);
                Start += 2;
            }
        }

    }
}
