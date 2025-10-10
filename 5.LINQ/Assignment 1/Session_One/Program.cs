using Session_One;

namespace LINQ_One
{
    internal class Progeam
    {
        static void Main(string[] args)
        {
            #region Implicitly Typed Local Variable [var - dynamic]
            #region Var
            string Data = "Asmaa";
            var data = "Asmaa";
            // Based On The Initial Value 
            // Compiler Will Detect The Datatype Of Variable A Compilation Time
            //var x; // Invalid
            //var x = null; // Invalid
            Data = null;

            //  data = 5; // You Can't Changr Variable Datatype After Initialization 

            #endregion
            #region Dynamic
            dynamic Name = "Asmaa";
            // CLR ==> Will Detect Datatype Of Variable At Runtime 
            // Based On It is Last Assigned Value
            dynamic y; // Valid
            dynamic Y = null;  // Valid

            Y = 5;
            Y = true;

            // After ntalzaton You Can Change Datatype Of Varable 

            #endregion
            #endregion

            #region Extention Methods
            
            // Question
            // How to Use it By I Number

            int x = 12345;
            int result=IntExtensions.ReverseNum(x);
            int result2= x.ReverseNum(); // Extension Method
            long A = 123456;
            long asn=A.ReverseNum(); // Extension Method
            Console.WriteLine(x.ToString());

            Console.WriteLine(IntExtensions.ToString(x));
                
            #endregion 

            #region Anonymous Type
            Employee employee1 = new Employee()
            {
                Id = 10,
                Name = "Asmaa",
                Salary = 20000
            };

            var employee2 = new
            {
                Id = 20,
                Name = "Rana",
                Salary = 1000
            };
            Console.WriteLine(employee2.GetType());

            // employee2.Salary = 40000; // Invalid

            // Way One  --> C# 9
            var employee02 = new
            {
                Id = employee2.Id,
                Name = employee2.Name,
                Salary = 2000
            };
            // Way Two  --> C# 10
            var employee002 = employee2 with { Salary = 2000 };

            var employee3 = new
            {
                Id = 30,
                Name = "Sara",
                Salary = 2000
            };

            Console.WriteLine(employee3.GetType());

            var employee4 = new
            {
                id = 30,
                Name = "Sara",
                Salary = 2000
            };

            Console.WriteLine(employee4.GetType());

            #endregion

            #region What Is Linq
            // LINQ : Language Integrated Query   -->  SQL => DQL ,C# => Functions
            //      : 40+ Extension Methods (LINQ Operators) Against Any Data [Data in Sequence]
            //      : Regardless Data Store
            //      : 13 Category
            //      : LINQ Operators Exists in Built-in Class "Enumerable"


            // Sequence : Object From Class Implement Interface "IEnumerable"
            // Local Sequence    : L2O , L2XML
            // Remote Sequence   : L2EF 


            // Input Sequence -> LINQ Operator -> Output Sequence 
            // Input Sequence -> LINQ Operator -> One Value
            //                -> LINQ Operator -> Output Sequence  

            List<int> Numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            var OddNumbers = Enumerable.Where(Numbers, X => X % 2 == 1); // return List

            foreach (var item in OddNumbers)
            {
                Console.WriteLine(item);
            }

            var EvenNumbers = Enumerable.Any(Numbers, X => X % 2 == 0); // return Bool Value
            Console.WriteLine(EvenNumbers);

            var Result = Enumerable.Range(0, 100); // return list contain this range 
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }


            #endregion

            #region Linq Syntax

            // 1. Fluent Syntax
            // Use LINQ Methods
            // 1.1. LINQ Operator as => Class Member Method Through Class "Enumerable"
            List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            var ResultNumbers = Enumerable.Where(Numbers, X => X % 2 == 0); // return List

            foreach (var item in ResultNumbers)
            {
                Console.WriteLine(item);
            }

            // 1.2. LINQ Operator as => Extension Method Through Sequence [Recommended]

            List<int> numbers2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var ResultNumbers2 = numbers2.Where(X => X % 2 == 0); // return List

            foreach (var item in ResultNumbers2)
            {
                Console.WriteLine(item);
            }

            // 2. Query Syntax [Query Expression] Like SQL Style
            // Start From 
            // end Select , group by

            List<int> numbers02 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var ResultNumbers02 = Enumerable.Where(numbers02,X => X % 2 == 0); // return List

            foreach (var item in ResultNumbers02)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Execution Ways

            #endregion

            #region Data Steup

            #endregion


        }
    }
}