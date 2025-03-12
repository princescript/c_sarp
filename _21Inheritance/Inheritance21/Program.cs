using System;


public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;

    public static void PrintTTT()
    {
        Console.WriteLine("Static class");
    }
    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmployee : Employee
{
    public float YearlySalary;

}

//C# does not support multiple class inheritance (a class cannot inherit from more than one class).

public class PartTimeEmployee : Employee
{
    public float HourlyRate;
}

public class A : PartTimeEmployee
{
  public void  PrintAll()
    {
        Console.WriteLine(FirstName + LastName + Email + HourlyRate);
    }
}
public class Program
{
    static void Main(string[] args)
    {
        FullTimeEmployee FTE = new FullTimeEmployee();

        FTE.FirstName ="Prince";
        FTE.LastName ="Singh";
        FTE.Email = "email";       
        FTE.YearlySalary = 5000;
        FTE.PrintFullName();


        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "Raj";
        PTE.LastName = "raja";
        PTE.Email = "email5";
        PTE.HourlyRate = 400;
        PTE.PrintFullName();



        A a = new A
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
            HourlyRate = 200
        };
        a.PrintAll();

        A.PrintTTT();
    }
}