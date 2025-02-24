using System;
namespace CommonOperators05
{
    class Program
    {
        static void Main()
        {
            int num1 = 10;
            int num2 = 20;

            //int result = num1 + num2;
            //Console.WriteLine("Addition of two numbers is: " + result);
            //int result1 = num1 - num2;
            //Console.WriteLine("Subtraction of two numbers is: " + result1);
            //int result2 = num1 * num2;
            //Console.WriteLine("Multiplication of two numbers is: " + result2);
            //decimal result3 = (decimal)num1 / num2;
            //Console.WriteLine("Division of two numbers is: " + result3);
            //int result4 = num1 % num2;
            //Console.WriteLine("Modulus of two numbers is: " + result4);

            //comparison operators😍

            //bool result5 = num1 == num2;
            //Console.WriteLine("Are two numbers equal: " + result5);
            //bool result6 = num1 != num2;
            //Console.WriteLine("Are two numbers not equal: " + result6);
            //bool result7 = num1 > num2;
            //Console.WriteLine("Is first number greater than second number: " + result7);
            //bool result8 = num1 < num2;
            //Console.WriteLine("Is first number less than second number: " + result8);
            //bool result9 = num1 >= num2;
            //Console.WriteLine("Is first number greater than or equal to second number: " + result9);
            //bool result10 = num1 <= num2;
            //Console.WriteLine("Is first number less than or equal to second number: " + result10);

            //Conditional operators
            //if (num1 == 10 && num2 == 40)
            //{
            //    Console.WriteLine("Both Condition true");
            //}
            //else
            //{
            //    Console.WriteLine("At least one condition is false");
            //}

            //if(num1 == 10 || num2 == 40)
            //{
            //    Console.WriteLine("At least one condition is true");
            //}
            //else
            //{
            //    Console.WriteLine("Both Condition false");
            //}

            //ternary operator
            Console.WriteLine(num1 > num2 ? "Big":"Notbig");
        }
    }
}
