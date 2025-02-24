using System;
public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("Parent Class Constructor");
    }
    public ParentClass(string name)
    {
        Console.WriteLine(name);
    }
}
public class ChildClass : ParentClass
{
    public ChildClass() :base("Prince sinhgh") {
        Console.WriteLine("Child Class Constructor");
    }
}
public class Program
{
    public static void Main()
    {
        ChildClass cc = new ChildClass();
    }
}