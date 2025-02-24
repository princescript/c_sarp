using System;
using System.Text;


namespace ConditionalStatement10
{
    internal class Program
    {
        static void Main()
        {
            //Console.WriteLine("Please Enter The Number:");
            //int Number = int.Parse(Console.ReadLine());

            //if (Number == 1)
            //{
            //    Console.WriteLine("You Enterd : 1");
            //}
            //if (Number == 2)
            //{
            //    Console.WriteLine("You Enterd : 2");
            //}
            //else if(Number == 3)
            //{
            //    Console.WriteLine("You Enterd : 3");
            //}
            //else
            //{
            //    Console.WriteLine("You Enterd {0}", Number);

            //}

            //if (Number != 1 && Number != 2 && Number != 3)
            //{
            //    Console.WriteLine("You Entered not 1 ,2, 3");
            //}
            //if (Number == 10 || Number == 1)
            //{
            //    Console.WriteLine("You Enterd 10 or 1");
            //}

            //switch case statement
            //Console.WriteLine("Enter day name:");
            //int day  = int.Parse(Console.ReadLine());
            ////Console.WriteLine(day);
            //switch (day)
            //{
            //    //case 1:
            //    //    Console.WriteLine("Monday");
            //    //    break;

            //    //case 2:
            //    //    Console.WriteLine("TuesDay");
            //    //    break;
            //    case 1:
            //    case 2:
            //        Console.WriteLine("This is Day {0}",day);
            //         break;
            //    default:
            //        Console.WriteLine("Not Found");
            //    break;
            //}

            //coffe program

            int TotalCoffeCoste = 0;

            Start:
            Console.WriteLine("1 for small , 2 for medium, 3 for large");
            int userChoise =int.Parse(Console.ReadLine());
            switch (userChoise)
            {
                case 1:
                    TotalCoffeCoste += 1;
                    break;
                case 2:
                    TotalCoffeCoste += 2;
                    break;
                case 3:
                    TotalCoffeCoste += 3;
                    break;
                default:
                    Console.WriteLine("Please Select Valid Coffe Code {0}",userChoise);
                    goto Start;
            }

            if(TotalCoffeCoste != 0)
            {
            Decide:
                Console.WriteLine("Do you want to buy another Cofee -Yes or No");
                string UserDecision = Console.ReadLine().ToUpper();
                switch (UserDecision)
                {
                    case "YES":
                        goto Start;
                    case "NO":
                        break;
                    default:
                        Console.WriteLine("Your Choice is invalid please try leter!");
                        goto Decide;

                }

            }

            if (TotalCoffeCoste != 0)
            {
                Console.WriteLine("Thank you shoping with us!");
                Console.WriteLine("Total Bill for Your Coffe is = {0} Doller!", TotalCoffeCoste);
            }
        }
    }
}
