using System;
using System.Media;
public class Program
{   //call by value and call by refrence
    public static void Main(string[] args)
    {
        int i = 10;
        int k = i;
        k = k + 1;
        Console.WriteLine($"i = {i} and k = {k}");

        Customer c1 = new Customer();
        c1.Name = "Prince Singh Kushwaha";
        Customer c2 = c1;
        c2.Name = "Aadarsh Singh";
        Console.WriteLine(c1.Name);
        Console.WriteLine(c2.Name);
        
    }
}
public struct Customer
{
    public Customer() { 
       
    }
    public int ID { get; set; }
    public string Name { get; set; }
}