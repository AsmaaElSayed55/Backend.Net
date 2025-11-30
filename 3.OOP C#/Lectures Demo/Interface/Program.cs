using Interface.Built_in_Interface;
using Interface.Interface_VS_Multi_Inheritance;
using Type = Interface.Type;

namespace Interface
{
    internal class Program
    {
        static void Print10Number(SeriesByTwo series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(series.Current + " ");
                series.Next();
            }
            Console.WriteLine();
        }
        static void Print10Number(SeriesByThree series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(series.Current + " ");
                series.Next();
            }
            Console.WriteLine();
        }
        static void Print10Number(SeriesByFour series)
        {
            for (int i = 0; i < 10; i++)
            {

                Console.Write(series.Current + " ");
                series.Next();
            }
            Console.WriteLine();
            
        }

        static void PrintNumberByISeries(ISeries series)
        {
            series.Reset();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(series.Current + " ");
                series.Next();
            }
            Console.WriteLine();
            series.Reset();
        }

        static void Main(string[] args)
        {

            #region Notes

            // Interface Can Be Implemented By Class , Struct and Record
            // Interface Has 3 Members : 
            //                         : 1. Signature For Properties
            //                         : 2. Signature For Methods
            //                         : 3. Default Implemented Method

            #endregion

            #region Interface

            IType refType; // Declare For Reference From type 'IType'
            // CLR Will Allocate 4 Bytes At Heap 
            // 'refType' Can Refer To An Object From Any Type That Implement Interface 'IType'

            refType = new Type();

            refType.MyProperty = 50;
            refType.MyMethod();
            refType.Print(); // Because We Have Reference Form Basic Interface That This Class That Called 'Type' Implemented it

            Type typeObj = new Type();

            typeObj.MyProperty = 50;
            typeObj.MyMethod();
            // typeObj.Print(); // That Is Invalid

            #endregion

            #region ISeries Interface

            // Series By Two

            SeriesByTwo seriesByTwo = new SeriesByTwo();
            Print10Number(seriesByTwo);

            // Series By Three
            SeriesByThree seriesByThree = new SeriesByThree();
            Print10Number(seriesByThree);

            // Series By Four
            SeriesByFour seriesByFour = new SeriesByFour();
            Print10Number(seriesByFour);

            // Series By ISeries Interface
            Console.WriteLine("Using ISeries Interface");
            // By Four
            PrintNumberByISeries(seriesByFour);
            // By Three
            PrintNumberByISeries(seriesByThree);
            // By Two
            PrintNumberByISeries(seriesByTwo);

            #endregion

            #region Built-in Interface

            #region ICompareable Interface

            Console.WriteLine("Using ICompareable Interface");

            Employee[] employees = new Employee[3]
            {
               
                new Employee(){ Id =2 , Name="Amany", Age=22 , Salary=13000},
                 new Employee(){ Id =1 , Name="Asmaa", Age=21 , Salary=12000},
                new Employee(){ Id =3 , Name="Aseel", Age=23 , Salary=14000}
            };

            Array.Sort(employees);
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }

            #endregion

            #region ICloneable Interface

            Employee Emp1 = new Employee() { Id = 10, Name = "Ahmed", Age = 24, Salary = 10000 };
            Employee Emp2 = new Employee() { Id = 20, Name = "Ali", Age = 26, Salary = 20000 };

            Console.WriteLine("Before Using ICloneable Interface");

            Console.WriteLine(Emp1.GetHashCode());
            Console.WriteLine(Emp2.GetHashCode());
            Console.WriteLine(Emp1);
            Console.WriteLine(Emp2);

            Emp2 =(Employee) Emp1.Clone(); // Deep Copy
                                           // You Should Cast Returned Data To The Same DataType of Object

            Console.WriteLine("After Using ICloneable Interface");

            Console.WriteLine(Emp1.GetHashCode());
            Console.WriteLine(Emp2.GetHashCode());
            Console.WriteLine( Emp1);
            Console.WriteLine(Emp2);
            #endregion

            #region IComparer Interface (Used To Sorting)

            Console.WriteLine("Using IComparer Interface");

            Employee[] Employees = new Employee[3]
            {

                new Employee(){ Id =2 , Name="Amany", Age=22 , Salary=13000},
                 new Employee(){ Id =1 , Name="Asmaa", Age=21 , Salary=17000},
                new Employee(){ Id =3 , Name="Aseel", Age=23 , Salary=14000}
            };

            Array.Sort(Employees,new EmployeeComparerSalary());
            foreach (Employee Emp in Employees)
            {
                Console.WriteLine(Emp.ToString());
            }


            #endregion

            #region IEnumerable<T> Interface



            #endregion

            #region ICollection<T> Interface



            #endregion

            #region IList<T> Interface

            #endregion

            #region IDisposable Interface

            #endregion

            #region IEqualityComparer<T>

            #endregion

            #region IReadOnlyCollection<T>

            #endregion

            #endregion

            #region Interface VS Multi Inheritance 

            Car car = new Car();
            car.Speed = 500;
            car.Forward(); // Move Car Forward
            car.Backward(); // Move Car Backward
            car.Left();   // Move Car Left
            car.Right();  // Move Car Right


            Airplane airplane = new Airplane();
            airplane.Speed = 500;
            airplane.Forward(); // Move Car Forward
            //airplane.Backward(); // Invalid [Implemented Explicitly]
            //airplane.Left();   // Invalid [Implemented Explicitly]
            //airplane.Right();  // Invalid [Implemented Explicitly]

            IMoveOnAir moveAirplaneOnAir= new Airplane();

            //moveAirplaneOnAir.Speed = 500; // Invalid --> it is there in Airplane [Inherited from Vehicle] --> Can't Get It By Reference From IMoveOnAir

            moveAirplaneOnAir.Forward(); // Airplane Move Forward Implement Implicitly.
            moveAirplaneOnAir.Backward(); // Airplane Move Backward On Air

            //moveAirplaneOnAir.Left(); // Valid 
            //moveAirplaneOnAir.Right(); // Valid


            IMoveOnGround moveAirplaneOnGround = new Airplane();

            //  moveAirplaneOnGround.Speed = 500; // Invalid --> it is there in Airplane [Inherited from Vehicle] --> Can't Get It By Reference From IMoveOnGround

            moveAirplaneOnGround.Forward(); // Airplane Move Forward Implement Implicitly.
            moveAirplaneOnGround.Backward(); // Airplane Move Backward On Ground

            //moveAirplaneOnGround.Left(); // Valid 
            //moveAirplaneOnGround.Right(); // Valid
            #endregion

            #region Shallow Copy And Deep Copy

            #region Array Of Value Type
            int[] Arr1 = [1, 2, 3];
            int[] Arr2 = new int[3]; // { 0,0,0 }

            Console.WriteLine($" HashCode Of Arr1 = {Arr1.GetHashCode()}"); // 35342034
            Console.WriteLine($" HashCode Of Arr2 = {Arr2.GetHashCode()}"); // 56793269

            #region Shallow Copy

            Arr2 = Arr1; // Shallow Copy
                         // Copy Value Of Arr1 To Arr2
                         // Address
                         // Copy Happened In Stack
                         // [ Arr1 , Arr2 ] => Has Same Value [Address] 
                         // [ Arr1 , Arr2 ] => Refer To The Same Object
                         // the Place of Arr1 => Became Having 2 References 
                         // The Place of Arr2 => Became Unreachable Address
                         // The Two Reference Refer To The Same Place

            Console.WriteLine("Shallow Copy");
            Console.WriteLine($" HashCode Of Arr1 = {Arr1.GetHashCode()}"); // 35342034
            Console.WriteLine($" HashCode Of Arr2 = {Arr2.GetHashCode()}"); // 35342034

            Arr1[0] = 100;
            Console.WriteLine($"Arr1[0] = {Arr1[0]}"); // arr1[0] = 100
            Console.WriteLine($"Arr2[0] = {Arr2[0]}"); // arr2[0] = 100

            #endregion

            #region Deep Copy

            Arr2 = (int[]) Arr2.Clone(); // Deep Copy 
                                         // Return Object
                                         // Happened In Heap
            // Create New Object With Different And New Identity and Return it
            // The New Object Will Have The Same Object State[Data] Of Caller 'Arr1'
            
            // Clone --> Make a new array which is shallow copy of the original array 

            Console.WriteLine("After Deep Copy");
            Console.WriteLine($" HashCode Of Arr1 = {Arr1.GetHashCode()}"); // 35342034
            Console.WriteLine($" HashCode Of Arr2 = {Arr2.GetHashCode()}"); // 115000

            Arr1[0] = 200;
            Console.WriteLine($"Arr1[0] = {Arr1[0]}"); // arr1[0] = 200
            Console.WriteLine($"Arr2[0] = {Arr2[0]}"); // arr2[0] = 100

            #endregion


            #endregion

            #region Array Of Reference Type

            #region Immutable Reference Type [String]

            string[] Names1 = { "Omar", "Amr" };
            string[] Names2 = new string[2];

            Console.WriteLine($"HashCode  ");


            #endregion

            #region Mutable Type

            #endregion


            #endregion


            #endregion


        }
    }
}
