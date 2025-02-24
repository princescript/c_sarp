using System;
public delegate void HelloFunctionDelegate(string msg);
class Program
{
    public static void Main()
    {
        //A Delegates is Type Safe Function Pointer
        Hello("Prince"); //// Direct function call

        // Creating a delegate instance and passing the method reference
        HelloFunctionDelegate del = new HelloFunctionDelegate (Hello);
        del("calling form delegates");
        
    }
    public static void Hello(string str)
    {
        Console.WriteLine("Hello, {0}!", str);
    }
}


/* USE of Delegates in c#

Method Callback: Pass a method as a parameter to another method.
Event Handling: Used as the basis for events and event handlers in .NET.
Encapsulation of Method Pointers: Store references to methods and invoke them dynamically.
Multicasting: Invoke multiple methods using a single delegate instance.
Asynchronous Programming: Used in asynchronous operations, like BeginInvoke and EndInvoke.*/