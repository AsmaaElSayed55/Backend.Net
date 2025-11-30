namespace Boxing_And_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boxing & UnBoxing

            object ob = new object();
            ob = new string("Asmaa");

            #region Boxing
            // Casting From Value Type Data Type TO Reference Type Data Type
            ob = (object)5; // Boxing
            ob = (object)10.478;
            ob = (object)'A';

            #endregion

            #region UnBoxing
            // Casting From Reference Type Data Type TO Value Type Data Type
            int Number = (int)ob; // UnBoxing
            // Casting From Object (Reference Type) Data Type TO int (Value Type) Data Type
            #endregion

            // if ok To Turn it into int , do it 
            // else put it 0
            Number = (ob.GetType() == typeof(int)) ? (int)ob : 0;
            Number = (ob is int) ? (int)ob : 0;

            #endregion

            #region Is & Has Relationship

            object X = "Asmaa"; // Inheritance : Is A

            #endregion

            #region Nullable Value Type
            // int age = null; // Wrong 
            Nullable<int> Age; // Base Syntax
            int? age = null; // Syntax Suger // ? --> Nullable Operator

            Nullable<int> nullable_variable = null;

            Console.WriteLine((age is not null) ? age : 0);
            Console.WriteLine((age.HasValue) ? age : 0);

            double? Salary; // Allow double values + Null

            double? num1 = 150;
            double? num2 = 200;
            double Total = (num1 + num2) ?? 0; // put 0 in total if sum of num1 and num2 is null

            int x = 10;
            int? y = x; // Okay // It Allow int Values + Null

            // x = y; // Wrong --> x is int Data Type --> Not Allow Null

            x = (int)y;  // Casting --> Y Turned into int Value 
                         // UnSafe Casting

            if (y is not null)
                x = (int)y;
            else y = 0;

            if (y.HasValue)
                x = (int)y;
            else
                x = 0;
            x = y.HasValue ? y.Value : 0;
            // Coalesing Operator 
            x = y ?? 0; // تحفة

            #endregion

            #region Nullable Reference Type

            string s = null;
            string str; str = null;
            string? s1 = null; // C# 8 // string nullable
            // Just For Compiler Enhancements
            string s2 = null!; // Null Forgiveness Operators
                               // is equal to string? s1 = null;

            string message = "Hi I'am Asmaa";
            string Resualt = message ?? "No New Message";

            #endregion

            #region Null Propagation Operator
            int[]? numbers = [1, 2, 3];

            #region Example 1

            numbers = null;
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            //--------------------------
            for (int i = 0; numbers is not null && i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            //--------------------------
            for (int i = 0; i < numbers?.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            #endregion
            #region Example 2

            int? Length;
            if (numbers is not null)
            {
                Length = numbers.Length;
                for (int i = 0; i < Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            else
                Console.WriteLine("No Data");
            //---------------------------------
            // (Numbers is not null) ? Numbers.Length : null;
            // Numbers?.Length;
            Length = numbers?.Length ?? 0;

            #endregion
            #region Example 3

            Employee employee = new Employee()
            {
                Id = 101,
                Name = "Asmaa El Sayed",
                Age = 20,
                Salary = 10_000,
                Department = new Department()
                {
                    Id = 20,
                    Name = "Dot Net"
                }
            };
            // employee = null;
            Console.WriteLine(employee?.Department?.Name ?? "No Data");
            Console.WriteLine(employee);
            #endregion

            #endregion

        }
    }
}
