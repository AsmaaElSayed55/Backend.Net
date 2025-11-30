using Abstraction.Partial;
using Abstraction.Static;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstraction
            // Abstraction :
            // Abstract : C# Keyword (Class , Method , Properties )
            // abstract class
            // abstract method 
            // abstract property

            // 2D Shape
            // Shape shape = new Shape();
            // Can't create object from abstract class

            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle.Perimeter);
            Console.WriteLine(rectangle.GetArea());

            // Interface Vs Abstract Class
            // 

            #endregion


            #region Static

            // Static : C# Keyword [class, method, property, constructors, attributes]
            // static class 
            // static method
            // static property
            // static constructor
            // static attribute

            Utilities U1 = new Utilities();
            Utilities U2 = new Utilities();
            Utilities U3 = new Utilities();

            //Console.WriteLine(U1.CmToInch(254)); //100
            //Console.WriteLine(U2.CmToInch(254));//100
            //Console.WriteLine(U3.CmToInch(254));//100

            // CmToInch doesn't change based on object --> so that make it static
            // when you want to call it --> call by class name ont object
            Console.WriteLine(Utilities.CmToInch(254)); //100

            // Static Property 
            Console.WriteLine(Utilities.PI);

            // Static Class 
            // All Members in it is static until constructor
            // can't create an object from it


            // Built in static class
            // Static proprties in it
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Tau);

            // Static Methods
            Console.WriteLine(Math.Min(2,6));
            Console.WriteLine(Math.Abs(5-7));


            // Constuctor in static class --> Is called only one time , when  the class is called first time


            #endregion


            #region Sealed

            // Sealed : C# Keyword [Class, Method, Property]
            // can't inherit from sealed class
            // Can't override on sealed property
            // Can't override on sealed method

            #endregion

            #region Pertial
            // The same class has implementation in more places 

            Employee employee = new Employee();
            Console.WriteLine(employee.Id);
            Console.WriteLine(employee.Name);

            #endregion
        }
    }
}
