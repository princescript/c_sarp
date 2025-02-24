using System;
class Program
{
    public static void Main(string[] args)
    {
        //you can assign a child class object to a parent class variable
        /* Polymorphism allows a base class reference to call a derived class method
        at runtime.    This is possible through method overriding using the virtual
        keyword in the base class and the override keyword in the derived class.*/


        /* Employee[] employees = new Employee[4];
        employees[0] = new Employee();
        employees[1] = new PartTimeEmployee();
        employees[2] = new FullTimeEmployee();
        employees[3] = new TemporaryEmployee();

       foreach(Employee employee in employees)
        {
            employee.PrintFullName(); 
        }*/

        Employee[] employees = { 
            new Employee(), 
            new PartTimeEmployee(),
            new FullTimeEmployee(), 
            new TemporaryEmployee()
        };
        foreach (Employee e in employees)
        {
            Console.WriteLine(e);
        }
    }  
}
class Employee {

    public string FirstName = "FN";
    public string LastName = "LN";
    public string UserName = "prince@123";
    public virtual void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
}

class PartTimeEmployee: Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName} - PartTime");
    }
}
class FullTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName} - FullTime");
    }
}

class TemporaryEmployee: Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName}  - Temporary");
        
    }
}