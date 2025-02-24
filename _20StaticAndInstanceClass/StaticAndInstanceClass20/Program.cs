using System;
using System.Runtime.Remoting.Contexts;
using System.Security.AccessControl;

/*Feature	Static Method	Instance Method
 
Belongs To	Class itself	Instance of the class
Accessed By	Class name (ClassName.Method())	Object (obj.Method())
Can Access	Only static members	Both static and instance members
Memory Allocation	Allocated once for the class	Allocated per instance
Use Case	General utility, does not rely on object data	Works with instance-specific data*/

/*public → Can be accessed anywhere.
private → Cannot be accessed outside the class (used in Singleton).
protected → Accessible only in derived classes.
internal → Accessible within the same assembly.
protected internal → Accessible in derived classes and within the same assembly.
private protected → Accessible only in derived classes within the same assembly*/
class Circle
{
    ///satic vs instance static do not create awlays in  obj creation cuz its static 
    public static float _PI;
    int _Radius;

    static Circle ()
    {
        Console.WriteLine("Static cunstructor created");
        Circle._PI = 3.14f;
    }   
    //canstructor function can be only public and private
    public Circle(int Radius1)
    {
        
        this._Radius = Radius1;
    }
    public static void Print() { }
    public float CalculateArea()
    {
        return _PI * this._Radius *this._Radius;
    }
}
class Program
{
    static void Main(string[] args)
        {
        Circle c = new Circle(2);
        Console.WriteLine(c.CalculateArea());

        //instance calling
        Circle c2 = new Circle(45);
        //static method calling
        Circle.Print();
        Console.WriteLine(c2.CalculateArea());

        Console.WriteLine(Circle._PI);
    }
}
