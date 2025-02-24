using System;
class Program
{
    //Diamond Problem in C# multiple inheritance is not possible in C# using classes
    static void Main(string[] args)
    {
        Console.WriteLine("Heel");
    }
}
class A
{
    public virtual void Print()
    {
        Console.WriteLine("A Implmentation");
    }
}

class B : A
{
    public override void Print()
    {
        Console.WriteLine("B Implmentation");
    }
}

class C : A
{
    public override void Print()
    {
        Console.WriteLine("C Implmentation");
    }
}

class D : B, C
{ 
    public override void Print()
    {
        Console.WriteLine("D Implmentation");
    }
}
