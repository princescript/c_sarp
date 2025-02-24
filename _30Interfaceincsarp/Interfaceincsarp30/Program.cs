using System;

public class Program 
{
    static void Main(string[] args)
    {
        //interface
        Customer customer = new Customer();
        //customer.Print1();
        //customer.Print2();
         
        //ICustomer1 cus1 = new ICustomer1(); // can not create instance of An Interface

        ICustomer1 icustomer = new Customer();
        icustomer.Print1();
        //icustomer.Print2(); Can not be Done
    }
}

interface ICustomer1
{
    void Print1();
    //void GetCoffee(int id);
    
}
interface ICustomer2 :ICustomer1
{
    void Print2();
}


public class Customer : ICustomer2
{   
    public void Print1()
    {
        Console.WriteLine("This is Print 1 Method From  ICustomer 1");

    }
    public void Print2()
    {
        Console.WriteLine("This is Print 2 Method From  ICustomer 2");
    }

}
