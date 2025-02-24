using System;


namespace Loops13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while loop
            //Console.WriteLine("Enter The Target Value:");
            //int Number = int.Parse(Console.ReadLine());

            //int EvenNum = 2;
            //while (EvenNum <= Number)
            //{
            //    Console.WriteLine("Even numn {0}",EvenNum);
            //    EvenNum += 2; 
            //}
            //int Start = 2;       
            //while (Start <= Number)
            //{               
            //    Console.WriteLine(Start);
            //    Start++;
            //}

            //do while loop
            string UserChoice;
            do {
                Console.WriteLine("Enter Your Target:");
                int UserTarget = int.Parse(Console.ReadLine());

                int Start = 0;
                while (Start <= UserTarget)
                {
                    Console.WriteLine(Start + " ");
                    Start += 2;
                }
               
                do
                {
                    Console.WriteLine("Do you want to continue - Yes Or No?");
                    UserChoice = Console.ReadLine().ToUpper();
                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid Choice , Please say Yes Or No");
                    }


                } while (UserChoice != "YES" && UserChoice != "NO");

            }while (UserChoice =="YES");
            
        }
    }
}
