using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
class Program
{
    public static void Main(string[] args)
    {
        //Test.Add(20, 10);
        //Test.Add(20,20,20);
        //Test.Add(22.2f, 10.2f);
        //Test.Add(20.2f, 10);
        int sum;
        Test.Add(10, 20, out sum);
        Console.WriteLine(sum);
    }
    
}
class Test
{
    //parameter and type change overloading
    public static void Add(int num1, int num2)
    {
        Console.WriteLine($"Sum = {num1 + num2}");
    }
    public static void Add(int num1, int num2, int num3)
    {
        Console.WriteLine($"Sum = {num1 + num2 + num3}");
    }
    public static void Add(float num1, float num2)
    {
        Console.WriteLine($"Sum = {num1 + num2}");
    }
    public static void Add(float num1, int num2)
    {
        Console.WriteLine($"Sum = {num1 + num2}");
    }

    // out parameter overloading
    public static void Add(int x , int y , out int sum)
    {
        sum = x + y;
    }
}