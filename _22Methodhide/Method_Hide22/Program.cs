using System;
/*Method Hiding (new keyword): PartTimeEmployee has a PrintAll() method that hides
 the base class method but still calls it using base.PrintAll().

 Method Hiding in C# happens when a derived class defines a method with the same name 
 as a method in the base class, but does not override it. Instead, it hides the base class
 method using the new keyword.
*/
public class Employee
{
    public string Fname;
    public string Lname;
    public string Email;
    public void PrintAll()
    {
        Console.WriteLine(Fname + " " + Lname);
       
    }
}

public class FullTimeEmployee : Employee
{
    
}
public class PartTimeEmployee : Employee
{
    public new void PrintAll()
    {
        //Console.WriteLine(Fname + " " + Lname + "- contract");
        base.PrintAll();
    }
}
public class Program
    {
    static void Main(string[] args)
    {
       FullTimeEmployee fullTime = new FullTimeEmployee();
        fullTime.Fname = "aadarsh";
        fullTime.Lname = "singh";
        fullTime.PrintAll() ;

        Employee partTime = new PartTimeEmployee();
        partTime.Fname = "Prince";
        partTime.Lname = "Raj";
        partTime.PrintAll();    
        //((Employee)partTime).PrintAll();
    }
}

