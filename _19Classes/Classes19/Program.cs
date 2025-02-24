using System;

class Customer
{
    string _FirstName;
    string _LastName;
    public Customer()
        : this("NoFirstName", "NoLastName")
    {
    }

    public Customer(string Fname, string Lname)
    {
        // _FirstName = Fname;
        this._FirstName = Fname;
        this._LastName = Lname;

    }
    public void PrintFullName()
    {
        Console.WriteLine("Full Name Mr.{0}", this._FirstName + " " + this._LastName);
    }
    ~Customer()
    {
        //clean up code;
        this._FirstName = null;
        this._LastName = null;

    }
}
 class Program
    {
        static void Main(string[] args)
        {
        //Customer c1 = new Customer("Prince","Singh");
        //c1.PrintFullName();

        Customer c1 = new Customer();
        c1 .PrintFullName();
        Customer c2 = new Customer("Prince", "Singh");
        c2.PrintFullName();
;       }
}


