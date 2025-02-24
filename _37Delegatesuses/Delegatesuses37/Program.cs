using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Uses OF Delegates in realLife");

        List<Employee> empList = new List<Employee>();
        empList.Add(new Employee() { ID = 101, Name = "Prince", Salary = 50000, Experience = 5 });
        empList.Add(new Employee() { ID = 102, Name = "Rahul", Salary = 20000, Experience = 2 });
        empList.Add(new Employee() { ID = 103, Name = "Rohit", Salary = 70000, Experience = 7 });
        empList.Add(new Employee() { ID = 104, Name = "Raj", Salary = 40000, Experience = 4 });

        Employee.PromoteEmployee(empList); 
    }
    
} 
class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> employeesList)
    {
        foreach (Employee employee in employeesList)
        {
            if (employee.Experience >= 5)
            {
                Console.WriteLine(employee.Name + " is Promoted");
            }
        }
    }
}