using System;

namespace Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1000000;
            i = 0x_00_00_FA_12; // hexadecimal
            byte b = 0b_0101_1100; // Binary
            int x, y;
            int.TryParse(Console.ReadLine(), out x);
            int.TryParse(Console.ReadLine(), out y);


            #region if else

            if (x >= 0)
                Console.WriteLine("Natural Number");
            else
                Console.WriteLine("Integer Number");

            if (x == 3)
                Console.WriteLine("x= ", 3);
            else if (y == 4)
                Console.WriteLine("x= ", 4);
            else if (y == 5)
                Console.WriteLine("x= ", 5);
            else if (y == 46)
                Console.WriteLine("x= ", 6);
            else
                Console.WriteLine("it is ", x);

            int.TryParse(Console.ReadLine(), out int Age);
            if (Age > 20)
                Console.WriteLine("Your Age Is Greater Than 20");
            else if (Age < 20)
                Console.WriteLine("Your Age Is Less Than 20");
            else
                Console.WriteLine("Your Age Equal 20");

            #endregion

            #region Switch

            #region Normal Switch
            switch (x)
            {
                case 0:
                    Console.WriteLine("X= ", false);
                    break;
                case 1:
                    Console.WriteLine("X= ", true);
                    break;
                case 2:
                    Console.WriteLine("X= ", x);
                    break;
                default:
                    break;
            }
            #endregion

            #region Switch With Many Cases
            switch (x)
            {
                case 0:
                    Console.WriteLine("X= ", false);
                    break;
                case 1:
                case 2:
                    Console.WriteLine("X= ", true);
                    break;
                case 3:
                case 4:  // I Can Collect many cases in one step if they have the same result in action 
                case 5:
                    Console.WriteLine("X= ", x);
                    break;
                default:
                    break;
            }
            #endregion

            #region Switch With GoTo
            string str = Console.ReadLine();
            switch (str)
            {
                case "Asmaa":
                    Console.WriteLine("The Str is ", str);
                    break;
                case "Amany":
                    Console.WriteLine("Your name is ", str);
                    goto case "Ahmed"; // if this case has the same action of another case + another action only for it  
                case "Ahmed":
                    Console.WriteLine("Your name is nice");
                    Console.WriteLine(str);
                    break;
                default:
                    Console.WriteLine("Not This ");
                    break;
            }
            #endregion

            #endregion

            #region Evolution Of Switch In C#

            #region C# 7
            // I Can Much Logic In One Case

            object obj1 = new object();
            obj1 = 10; // Boxing
            switch (obj1)
            {
                // This Checks If LoacalInput is of type Int
                case int LocalInput when LocalInput > 10 && LocalInput < 20:
                    Console.WriteLine("This Is Integer Input");
                    break;
                case double LocalInput:
                    Console.WriteLine("This Is Double Input");
                    break;
                case Person LocalInput:
                    Console.WriteLine("This Is Person Input");
                    break;
                default:
                    break;
            }

            #endregion

            #region C# 8
            // Improve In Switch Sentax

            Console.WriteLine("Enter Your Option");
            int.TryParse(Console.ReadLine(), out int option);
            string Message;
            #region Before
            switch (option)
            {
                case 1:
                    Console.WriteLine("Option 1");
                    break;
                case 2:
                    Console.WriteLine("Option 2");
                    break;
                case 3:
                    Console.WriteLine("Option 3");
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            #endregion

            #region After
            Message = option switch
            {
                1 => "Option 1",
                2 => "Option 2",     // Options
                3 => "Option 3",
                _ => "Invalid Option"  // defualt 
            };
            #endregion

            #endregion

            #region C# 9
            // 

            Person person = new Person() { Id = 10, Name = "Asmaa El Sayed" };
            string message = string.Empty;
            message = person switch
            {
                { Id: 10, Name: "Asmaa El Sayed", Age: > 20 and < 25 } => $"Hello {person.Name}, Your Age:{person.Age} ",
                { Id: 20, Age: 30 } => $"Hello Anonymous , Your Age is {person.Age}",
                _ => "UnKnown User"
            };

            #endregion

            #endregion


            #region Block Statment 

            // int j; --> this give error in declaration in next Scope
            //  Block Statment
            {
                int j = 0; // Block Scope
                j += 5;
                Console.WriteLine(j);
            } // End Of i Scope

            #endregion

            #region Task
            string s;
            s = Console.ReadLine();
            switch (s)
            {
                case "admin":
                    Console.WriteLine("Full Acces granted");
                    break;
                case "user":
                    Console.WriteLine("Limited Acces granted");
                    break;
                case "guest":
                    Console.WriteLine("View Only Acces");
                    break;
                default:
                    Console.WriteLine("Invalid role");
                    break;
            }
            if (s == "admin")
                Console.WriteLine("Full Acces granted");
            else if (s == "user")
                Console.WriteLine("Limited Acces granted");
            else if (s == "guest")
                Console.WriteLine("View Only Acces");
            else
                Console.WriteLine("Invalid role");

            //int number;
            int sum = 0, num = 0, amount = 0;
            int.TryParse(Console.ReadLine(), out int Number1);
            int.TryParse(Console.ReadLine(), out int Number2);
            int.TryParse(Console.ReadLine(), out int Number3);
            int[] arr = { Number1, Number2, Number3 };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            while (num < 3)
            {
                int.TryParse(Console.ReadLine(), out int Number);
                sum += Number;
                num++;
                if (Number % 2 == 1) amount++;
            }

            #endregion
        }
    }
}
