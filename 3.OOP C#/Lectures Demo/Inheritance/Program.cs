using Common;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Notes
            // C# Support 3 Types from Inheritance 
            // 1. Single Inheritance 
            // 2. Multilevel Inheritance 
            // 3. Hierarchical Inheritance

            // By Default Constructor Of Child Constructor Chaining Parent Parameter Constructor
            
            //      
            #endregion

            #region Example 1 [ Parent , Child]
            Parent P1 = new Parent(1, 2);

            P1.X = 10;
            P1.Y = 20;
            Console.WriteLine(P1); // X = 10 , Y = 20

            Console.WriteLine(P1.Product()); // 200

            P1.MyFun(); // I Am Parent 

            Child Ch1 = new Child(1,2,3);

            Ch1.X = 10;
            Ch1.Y = 20;
            Ch1.Z = 30;

            Console.WriteLine(Ch1);

            Console.WriteLine(Ch1.Product());

            Ch1.MyFun();

            #endregion

            #region Access Mofidiers 

            TypeA typeA = new TypeA();
            //typeA.A = 1; // Invalid [Private] 
            //typeA.B = 2; // Invalid [Internal] 
            typeA.C = 3; // Valid [Public]

            //typeA.X = 10; // Invalid [private protected]
            //typeA.Y = 20; // Invalid [protected]
            //typeA.Z = 30; // Invalid [Internal protected]


            TypeB typeB = new TypeB();
            //typeB.B = 2; // Invalid internal
            typeB.C = 3; // Valid Public  

            //typeB.X = 10; // Invalid Private 
            //typeB.Y = 20; // Invalid Private 
            //typeB.Z = 30; // Invalid internal


            TypeD typeD = new TypeD();
            //typeD.C = 3; // Valid [Public] 
            //typeD.Y = 20; // Invalid [Private] 
            //typeD.Z = 30; // Invalid [Private]

            #endregion


        }
    }
}
