using System;
class Program
{
    static void Main(string[] args)
    {
        //Property with a Getter and Setter (Encapsulated Property) in C#
        Student s1 = new Student();
        s1.Id = 10;
        Console.WriteLine(s1.Id);
        s1.Name = "Prince";
        Console.WriteLine(s1.Name);
        Console.WriteLine(s1.PassMark);
        s1.Email = "prince@gmail.com";
        Console.WriteLine(s1.Email);
        s1.City = "Patna";
        Console.WriteLine(s1.City);
    }
}
public class Student
{
    private int _Id;
    private string _Name;
    private int _PassMark = 35;

    
    public int Id
    {
        get { return this._Id; }       
        set
        {
            if(value <= 0)
            {
                throw new Exception("Student id can not be negative");
            }
            this._Id = value;
        }
        
    }

    public string Name
    {
        get { return this._Name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Name cannot be empty or null");
            }
            this._Name = value;
        }
    }
    public int PassMark
    {
        get { return this._PassMark; }
    }

    //automatically get & set
    public string City { get; set; }
    public string Email { get; set; }
}
