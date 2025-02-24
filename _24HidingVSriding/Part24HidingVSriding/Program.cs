using System;
using System.Configuration;
class Program
{
    //method hiding vs method riding
    public static void Main(string[] args)
    {
        BaseClass baseClass = new DerivedClass();
        baseClass.Print();
    }
}
class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("I am  a Base Class Print Method");
    }
}
class DerivedClass : BaseClass
{
    public new void Print()
    {
        Console.WriteLine("I am a DerivedClass Print Method");
    }
}