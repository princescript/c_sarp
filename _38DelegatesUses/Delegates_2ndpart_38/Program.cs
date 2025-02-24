using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee() { ID = 101, Name = "Mark", Salary = 5000, Experience = 5 });
        employees.Add(new Employee() { ID = 102, Name = "John", Salary = 6000, Experience = 2 });
        employees.Add(new Employee() { ID = 103, Name = "Mary", Salary = 7000, Experience = 7 });
        employees.Add(new Employee() { ID = 104, Name = "Todd", Salary = 8000, Experience = 1 });

        // Correct delegate instance
        IsPromotable isPromotable = new IsPromotable(Promote);

        // Pass the delegate instance to PromoteEmployee method
        Employee.PromoteEmployee(employees, isPromotable);

        // Prevent console from closing immediately
        Console.ReadLine();
    }

    // Delegate function
    public static bool Promote(Employee emp)
    {
        return emp.Experience >= 5;
    }
}

// Corrected delegate declaration (Fixed parameter name)
public delegate bool IsPromotable(Employee emp);

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    // Static method to promote employees based on delegate condition
    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable isPromotable)
    {
        foreach (Employee emp in employeeList)
        {
            if (isPromotable(emp)) // Correct function call
            {
                Console.WriteLine(emp.Name + " is Promoted");
            }
        }
    }
}
