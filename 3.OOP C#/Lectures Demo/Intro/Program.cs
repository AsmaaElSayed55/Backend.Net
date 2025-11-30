
using Common;
using System.Drawing;
namespace Intro
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            Point p1;
            // Declare For Variable | Object From Type "Point"
            // CLR Will Allocate 8 Unitintialized Bytes At Stack
            p1 = new Point();
            // new ==> Is Just For Constructor Selection That Will Used to Initialized P1 Attribute
            Point P2 = new(30); // Syntax Suger

            #region Example 1
            Console.WriteLine($"P1.X =  {p1.X}"); // 0
            Console.WriteLine($"P1.Y = {p1.Y}"); // 0

            p1 = new Point(10, 20);
            p1 = new(10, 20); // Syntax Suger
            Console.WriteLine($"P1.X =  {p1.X}"); // 10
            Console.WriteLine($"P1.Y = {p1.Y}"); // 20

            Console.WriteLine($"P1.X =  {p1.X}"); // 30
            Console.WriteLine($"P1.Y = {p1.Y}"); // 30

            Console.WriteLine(p1); // (10,20)
            Console.WriteLine(P2.ToString());
            #endregion

            #region Example 2
            P2 = p1;
            Console.WriteLine(p1); // (10,20)
            Console.WriteLine(P2); // (10,20)

            p1.X = 400;
            p1.Y = 300;
            Console.WriteLine(p1); // (400,300)
            Console.WriteLine(P2); // (10,20) 
            #endregion

            #endregion

            #region OOP Definition
            // Encapsulation
            // Inheritance
            // Polymorphism
            // Abstraction

            #endregion

            #region Classes & Objects

            Car c1;
            // Declare For Special Variable | Reference From Type "Car"
            // car Is Reference Referencing To Default Value Of Reference Type => NULL 
            // This Reference "car" Can Refer To An Instance From Type "Car"
            // Or Any Datatype Inherit From Class "Car"
            // CLR Will Allocate 4 Bytes At Stack For Reference "car"

            c1 = new Car();
            // Create Object | Instance From Class Car
            // 1. Allocate Required Bytes At Heap [28 Bytes ] From Object
            // 2. Initialize Allocated Bytes At Heap With Default Values Of Its Datatypes [Id=0] 
            // 3. Call User Defined Constructor [ If Exists ] 
            // 4. Assign Address Of Allocated Object To Reference "car"
            Console.WriteLine(c1);

            Car car = new Car(10, "BMW", 250, 2000000, "12345");
            #endregion

            #region Relationship Between Classes
            // Inheritance  is_a : FullTimeEmployee : Employee --> Full Time Employee is a Employee
            //                   : Employee : Person --> Employee is a Person 

            // Association  use_a : one to one -->
            //                    : one to many --> 
            //                    : many to many -->

            // Composition And Aggregation  has_a

            #endregion

        }
    }
}
