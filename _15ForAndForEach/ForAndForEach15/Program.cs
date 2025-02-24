using System;


namespace ForAndForEach15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[4];
            Numbers[0] = 100;
            Numbers[1] = 200;
            Numbers[2] = 300;
            Numbers[3] = 400;
            int[] Ages = { 10, 20, 54, 87 };

            for (int i = 0; i < Numbers.Length; i++) { 
                if(Numbers[i] == 300) break;
                Console.WriteLine(Numbers[i]);
            }

            Console.WriteLine("Lol");

            foreach(int k in Numbers)
            {
                if (k == 300) continue;
                Console.WriteLine(k);
            }
        }
    }
}
