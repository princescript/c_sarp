using System;
public class Program : AbstractClass
{
    public static void Main()
    {
        Console.WriteLine("Hello");
        Program program = new Program();
        program.Print();
    }
}

 public abstract class AbstractClass
{
    int id;
   public void Print()
    {
        Console.WriteLine("Primt");
    }
}

interface ICustomer
{
    void Print();

}