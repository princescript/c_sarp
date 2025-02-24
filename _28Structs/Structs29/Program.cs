using System;
public class Program
{
    public static void Main(string[] args)
    {
        Customer c1 = new Customer(20,"Prince");
        c1.PrintInfo();

        Customer c2 = new Customer();
        c2.ID = 101;
        c2.NAME = "Aadarsh";
        c2.PrintInfo();

        //object initlizer , class , struct
        Customer c3 = new Customer
        {
            ID = 103,
            NAME = "Raju",
        };
        c3.PrintInfo();
    }
}
public struct Customer
{
    private int _Id;
    private string _Name;

    public int ID { 
        get { return this._Id; }
        set { this._Id = value; }
    }

    public String NAME
    {
        get { return this._Name; }
        set { this._Name = value; }
    }


    public Customer (int id, string name)
    {
        this._Id = id;
        this._Name = name;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Id :{this._Id} & Name :{this._Name} ");
    }
}
