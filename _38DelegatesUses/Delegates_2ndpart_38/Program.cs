using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee() { ID = 101, Name = "Mark", Salary = 5000, Experience = 5 });
        employees.Add(new Employee() { ID = 102, Name = "John", Salary = 6000, Experience = 2 });
        employees.Add(new Employee() { ID = 103, Name = "Mary", Salary = 7000, Experience = 7 });
        employees.Add(new Employee() { ID = 104, Name = "Todd", Salary = 8000, Experience = 1 });


    }
    public delegate void IsPromotable(Employee emp);


    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        // Static method to promote employees based on delegate condition
        public static void PromoteEmployee(List<Employee> employeeList , IsPromotable isPromotable)
        {
            foreach (Employee emp in employeeList)
            {
                if(isPromotable(emp))
                {
                    Console.WriteLine(emp.Name  + " is promoted");
                }
            }
        }
    }


}