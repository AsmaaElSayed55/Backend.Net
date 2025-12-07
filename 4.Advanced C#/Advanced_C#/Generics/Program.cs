using System.Linq.Expressions;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generics --> C# Feature in 2005
            // Before 2005


            #region Swapping

            // Int
            int a = 4, b = 5;
            Console.WriteLine($" A : {a} ");
            Console.WriteLine($" B : {b}");

            Console.WriteLine("After Swapping");
            Helper.Swap(ref a, ref b);

            Console.WriteLine($" A : {a} ");
            Console.WriteLine($" B : {b}");


            // double
            double x = 5.33, y = 8182.4;
            Console.WriteLine($" X : {x} ");
            Console.WriteLine($" Y : {y}");

            Console.WriteLine("After Swapping");
            Helper.Swap(ref x, ref y);

            Console.WriteLine($" X : {x} ");
            Console.WriteLine($" Y : {y}");

            // Struct
            // Until you swap 2 reference type , you should pass by reference not by value
            Point P1 = new Point(2, 4);
            Point P2 = new Point(6, 5);

            Console.WriteLine($" P1.x : {P1.X} , P1.Y : {P1.X} ");
            Console.WriteLine($" P1.x : {P2.X} , P1.Y : {P2.Y} ");

            Console.WriteLine("After Swapping");
            Helper.Swap(ref P1, ref P2);

            Console.WriteLine($" P1.x : {P1.X} , P1.Y : {P1.X} ");
            Console.WriteLine($" P1.x : {P2.X} , P1.Y : {P2.Y} ");

            #endregion

            #region Generics

            // Int
            int A = 4, B = 5;
            Console.WriteLine($" A : {A} ");
            Console.WriteLine($" B : {B}");

            Console.WriteLine("After Swapping");
            Helper.Swap(ref A, ref B);

            Console.WriteLine($" A : {A} ");
            Console.WriteLine($" B : {B}");


            // double
            double X = 5.33, Y = 8182.4;
            Console.WriteLine($" X : {X} ");
            Console.WriteLine($" Y : {Y}");

            Console.WriteLine("After Swapping");
            Helper.Swap(ref X, ref Y);

            Console.WriteLine($" X : {X} ");
            Console.WriteLine($" Y : {Y}");

            // Float
            float F1 = 34.84f, F2 = 4387.598304f;
            Console.WriteLine($" F1 : {F1} ");
            Console.WriteLine($" F2 : {F2}");

            Console.WriteLine("After Swapping");
            Helper.Swap<float>(ref F1, ref F2);

            Console.WriteLine($" F1 : {F1}");
            Console.WriteLine($" F2 : {F2}");


            // Struct
            // Until you swap 2 reference type , you should pass by reference not by value
            Point p1 = new Point(2, 4);
            Point p2 = new Point(6, 5);

            Console.WriteLine($" P1.x : {p1.X} , P1.Y : {p1.X} ");
            Console.WriteLine($" P1.x : {p2.X} , P1.Y : {p2.Y} ");

            Console.WriteLine("After Swapping");
            Helper.Swap<Point>(ref p1, ref p2);

            Console.WriteLine($" P1.x : {p1.X} , P1.Y : {p1.X} ");
            Console.WriteLine($" P1.x : {p2.X} , P1.Y : {p2.Y} ");


            #endregion

            #region Linear Search

            int[] numbers = { 1, 3, 5, 2, 43, 723, 2, 5722, 21 };
            int value1 = 7,value2=5;
            Console.WriteLine(Helper.LinearSearch(numbers,value1));
            Console.WriteLine(Helper.LinearSearch(numbers, value2));

            Employee Emp1= new Employee() { Id=1 , Name="Asmaa", Age=21,Salary=12000};
            Employee Emp2 = new Employee() { Id = 2, Name = "Amany", Age = 22, Salary = 15000 };
            Employee Emp3 = new Employee() { Id = 3, Name = "Aseel", Age = 23, Salary = 18000 };
            Employee Emp4 = new Employee() { Id = 4, Name = "Aqura", Age = 25, Salary = 23000 };

            Employee[] employees = new Employee[] { Emp1, Emp2, Emp3, Emp4 };
            Console.WriteLine(Helper.LinearSearch( employees, Emp1));
            #endregion

            #region Equality in Class or Struct 

            // Both class and struct inherited Equals function from Object class
            // In Class --> Equal Compare Reference
            // In Struct --> Equals Compare Data
            // Note --> Struct Doesn't have Implementation For == Operator

            Employee emp1= new Employee() { Id = 1, Name = "Ahmed", Age = 24, Salary = 12345 };
            Employee emp2 = new Employee() { Id = 1, Name = "Ahmed", Age = 24, Salary = 12345 };

            Console.WriteLine($"Emp1 : {emp1.GetHashCode()}");
            Console.WriteLine($"Emp2 : {emp2.GetHashCode()}");

            if(emp1.Equals( emp2)) // Not Equal Because it is Two Deffirent References
                Console.WriteLine("Emp1 == Emp2");
            else
                Console.WriteLine("Emp1 != Emp2");

            EmployeeStruct Emp01= new EmployeeStruct() { Id = 1, Name = "Ahmed", Age = 24, Salary = 12345 };
            EmployeeStruct Emp02= new EmployeeStruct() { Id = 1, Name = "Ahmed", Age = 24, Salary = 12345 };

            if (Emp01==Emp02) // Not Equal Because it is Two Deffirent References
                Console.WriteLine("Emp01 == Emp02");
            else
                Console.WriteLine("Emp01 != Emp02");

            // if i changed the class to struct , it will give to that it is Equals 

            #endregion

            #region Bubble Sort

            // Loop on array n^2 
            // swap two adjacency elements if is not sorted 
            int[] arr = { 1, 8, 9, 2, 3, 10, 11, 4, 5, 6, 7 };

            Console.WriteLine("Before Sorting");
            foreach (var element in arr)
                Console.Write(element + " ");
            Console.WriteLine();

            Helper.BubbleSort(arr);

            Console.WriteLine("After Sortng");
            foreach (var element in  arr)
                Console.Write(element+" ");

            Point[] points = {
                new Point(4,5), 
                new Point(5,6), 
                new Point(1,2),
                new Point(3,2)
            };

            Console.WriteLine("Before Sorting");
            foreach (var element in points)
                Console.WriteLine(element.ToString());

            Helper.BubbleSort(points);  // Make class implement Generic IComparable

            Console.WriteLine("After Sortng");
            foreach (var element in points)
                Console.WriteLine(element.ToString());

            // Employee Class
            Employee[] Employees =
            {
                new Employee { Id = 3,Name="Mohamed",Age=45,Salary=12434 },
                new Employee { Id = 4,Name="ahmed",Age=26,Salary=58923 },
                new Employee { Id = 1, Name = "Ali", Age = 23 ,Salary=8342}
            };

            Console.WriteLine("Before Sorting");
            foreach (var element in Employees)
                Console.WriteLine(element.ToString());

            Helper.BubbleSort(Employees); // Make class implement Generic IComparable 

            Console.WriteLine("After Sortng");
            foreach (var element in Employees)
                Console.WriteLine(element.ToString());

            #endregion

            #region Is & As Casting Operation

            // there are two operators i used them to casting
            // 1. is conditional operator 
            // 2. as casting operator 

            Point[] Points = {
                new Point(4,5),
                new Point(5,6),
                new Point(1,2),
                new Point(3,2)
            };

            Console.WriteLine("Before Sorting");
            foreach (var element in Points)
                Console.WriteLine(element.ToString());

            Helper.BubbleSort(Points);

            Console.WriteLine("After Sortng");
            foreach (var element in Points)
                Console.WriteLine(element.ToString());

            #endregion

            #region Non Generic ICompareable Vs Generic ICompareable 

            // Make class implement Generic IComparable


            #endregion

            #region Built-in Interface Generic IEquatable


            Employee emp01 = new Employee() { Id = 1, Name = "Asmaa", Age = 21, Salary = 12000 };
            Employee emp02 = new Employee() { Id = 2, Name = "Amany", Age = 22, Salary = 15000 };
            Employee emp03 = new Employee() { Id = 3, Name = "Aseel", Age = 23, Salary = 18000 };
            Employee emp04 = new Employee() { Id = 4, Name = "Aqura", Age = 25, Salary = 23000 };

            Employee[] employeeS = new Employee[] { emp01, emp02, emp03, emp04 };
            Console.WriteLine(Helper.LinearSearch(employeeS, emp03));

            if (emp01.Equals(emp02))
                Console.WriteLine("emp01 == emp02");
            else Console.WriteLine("emp01 != emp02");

            // Built-in Interface Generic IEquatable 
            if (emp01.Equals(emp01))
                Console.WriteLine("emp01 == emp02");
            else Console.WriteLine("emp01 != emp02");


            #endregion

            #region Built-in Interface Generic IEqualityCompare

            // Built-in Interface Generic IEqualityComparer

            Employee employee1 = new Employee() { Id = 1, Name = "Asmaa", Age = 21, Salary = 12000 };
            Employee employee2 = new Employee() { Id = 2, Name = "Amany", Age = 22, Salary = 15000 };
            Employee employee3 = new Employee() { Id = 3, Name = "Aseel", Age = 23, Salary = 18000 };
            Employee employee4 = new Employee() { Id = 4, Name = "Aqura", Age = 25, Salary = 23000 };

            Employee[] EmployeeS = new Employee[] { employee1, employee2, employee3, employee4 };

            Console.WriteLine("Index Of Employee Called Amany ");
            // Search Only By name
            Console.WriteLine("Search Only By Name ");
            Console.WriteLine(Helper.LinearSearch(EmployeeS, new Employee() { Name = "Amany" }, new EmployeeEqualityComparerName()));

            Console.WriteLine("Search By All Parameters ");
            Console.WriteLine(Helper.LinearSearch(EmployeeS, new Employee() { Name = "Amany" }, new EmployeeEqualityComparerName()));


            #endregion

            #region IComparer With Bubble sort

            Employee employee01 = new Employee() { Id = 1, Name = "Asmaa", Age = 21, Salary = 12000 };
            Employee employee02 = new Employee() { Id = 2, Name = "Amany", Age = 22, Salary = 19000 };
            Employee employee03 = new Employee() { Id = 3, Name = "Aseel", Age = 23, Salary = 15000 };
            Employee employee04 = new Employee() { Id = 4, Name = "Aqura", Age = 25, Salary = 2000 };

            Employee[] EmployeeS_ = new Employee[] { employee01, employee02, employee03, employee04 };

            Console.WriteLine("Before Sorting");
            foreach (var element in EmployeeS_)
                Console.WriteLine(element.ToString()); 

            // Sort Based On Specific Element
            Helper.BubbleSort(EmployeeS_,new EmployeeComparerSalary()); // Make class implement Generic IComparable 


            Console.WriteLine("After Sortng");
            foreach (var element in EmployeeS_)
                Console.WriteLine(element.ToString());


            #endregion

            #region Generic Constraints

            // 1. Primary Constraint
            // 1.1 Class 
            // 1.2 Struct
            // 1.3 Special Type 'Point'
            // 1.4 Enum
            // 1.5 Not Null

            // 2. Secondary Constraint 
            // 2.1 T Implement Specific Interface

            // 3. Constructor Constraint


            #endregion

        }
    }
}
