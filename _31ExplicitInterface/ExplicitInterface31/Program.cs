using System;
public class Program :I1 ,I2 
{
    public void InterfaceMethod()
    {
        Console.WriteLine("This is I1");
    }
    void I2.InterfaceMethod()
    {
        Console.WriteLine("This is I2");

    }
    public static void Main(string[] args)
    {
        //Explicit Implementation 

        //Program p1 = new Program();
        //((I1)p1).InterfaceMethod();
        //((I2)p1).InterfaceMethod();

        //I1 i1 = new Program();
        //i1.InterfaceMethod();
        //I2 i2 = new Program();
        //i2.InterfaceMethod();

        //default Implementation  - Implicit + Explicit

        Program program = new Program();
        program.InterfaceMethod();
        ((I2)program).InterfaceMethod(); //Typecasting 

    }
}
interface I1
{
    void InterfaceMethod();
}
interface I2
{
    void InterfaceMethod();
}