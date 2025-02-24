using System;
public  class Program : Customer
{ 
    //public override void Print()
    //{
    //    Console.WriteLine("H");
    //}
    public static void Main(string[] args)
    {
        Program customer = new Program();
        customer.Print();
    }

}

public abstract class Customer {
    public void Print()
    {
        Console.WriteLine("Hello");
    }
    //public abstract void Print()
    //{
    //    Console.WriteLine("Hello");
    //}
}