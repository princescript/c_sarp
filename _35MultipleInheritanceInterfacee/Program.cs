using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hi");
        AB ab = new AB();
        ab.AMethod();
        ab.BMethod();
        
    }
}
interface IA
{
    void AMethod();
}
class A : IA
{
    public void AMethod()
    {
        Console.WriteLine("A");
    }
}
interface IB
{
    void BMethod();
}
class B : IB
{
    public void BMethod()
    {
        Console.WriteLine("B");
    }
}
class AB :IA,IB
{
    //composition in C#
    //AB is just forwarding the calls instead of defining them again.
    A a = new A();
    B b = new B();
    public void AMethod() {
        a.AMethod();
    }
    public void BMethod() {
        b.BMethod();
    }


}
