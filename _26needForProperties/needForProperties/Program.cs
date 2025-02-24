using System;
using Microsoft.Win32;
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        /*s1.Id = -1;
        s1.Name = null;
        s1.PassMark = 0;
        Console.WriteLine($" ID : {s1.Id} , Name : {s1.Name}  and PassMark : {s1.PassMark}");*/

        //use getter and Seter custom method
        s1.SetId(20);
        s1.SetName("Prince");

        Console.WriteLine("ID :" + s1.GetId());
        Console.WriteLine("Name :" +s1.GetName());
        Console.WriteLine("PassMark :" + s1.GetPassMark());
    }
}
public class Student
{
    private int _Id;
    private string _Name;
    private int _PassMark =35;

    public int GetPassMark()
    {
        return this._PassMark;
    }
    public void SetName(string name)
    {
        if(string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException("Student name is not valid");
        }
        _Name = name;
    }
    public string GetName()
    {
        return string.IsNullOrEmpty(this._Name) ? "No name" : this._Name;      
    }

    public void SetId(int id)
    {
        if (id <= 0)
        {
            throw new Exception("Student id can not be negative");
        }
        _Id = id;
    }
    public int GetId()
    {
        return _Id;
    }
}
