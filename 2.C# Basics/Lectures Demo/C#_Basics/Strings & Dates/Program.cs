using System.Text;

namespace Strings_And_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region String Formating 
            /*
             * byte --> By default Unsigned data type
             * short --> By default signed data type
             * 
            */

            int i = 1000000;
            i = 0x_00_00_FA_12; // hexadecimal
            byte b = 0b_0101_1100; // Binary
            int x, y;
            int.TryParse(Console.ReadLine(), out x);
            int.TryParse(Console.ReadLine(), out y);

            // using +
            Console.WriteLine("Equation : " + x + " + " + y + " = " + (x + y));

            // 
            string msg = string.Format("Equation : {0} + {1} = {2} ", x, y, x + y); // until C#5
            Console.WriteLine(msg);

            // $ --> String Manipulation Operator
            string Msg = string.Format($"Equation : {x} + {y} = {x + y}"); // 
            Console.WriteLine(Msg);

            #endregion

            #region String
            // Is Built In Class ( Reference Data Type ) :Internally Is An Array Of Chars
            // Array Is Fixed Size 
            #region Part 1
            string Name;
            /*
             * Declare For Reference 'Name' Of Type String 
             * This Reference 'Name' Is Referencing To The Default Value Of The Reference Types = null
             * CLR Will Allocate 4 Bytes For THe Reference 'Name' in Stack
             * CLR Will Allocate 0 Bytes in Heap
            */
            Name = new string("Asmaa"); // is done by default
            Name = "Asmaa";// Syntax Suger  // CLR Will Allocate 10 Bytes Initialized With 'Asmaa'

            Name = "Ahmed"; // 
            #endregion

            #region Example 1

            string Name1 = "Asmaa";
            string Name2 = "Ahmed";
            Console.WriteLine($"Name 1: {Name1}");
            Console.WriteLine($"Name 2: {Name2}");
            Console.WriteLine($"------------------");
            Console.WriteLine($"Name 1: {Name1} , GetHashCode : {Name1.GetHashCode()} ");
            Console.WriteLine($"Name 2: {Name2} , GetHashCode : {Name2.GetHashCode()} ");

            #endregion

            #region Example 2

            string Name3 = "Asmaa";
            string Name4 = "Ahmed";
            Console.WriteLine($"Name 1: {Name3}");
            Console.WriteLine($"Name 2: {Name4}");
            Console.WriteLine($"------------------");
            Console.WriteLine($"Name 1: {Name3} , GetHashCode : {Name3.GetHashCode()} ");
            Console.WriteLine($"Name 2: {Name4} , GetHashCode : {Name4.GetHashCode()} ");

            Name3 = Name4;
            /*
             * Name 3 Has 2 References Name3 & Name4
             */

            Console.WriteLine($"Name 1: {Name3}");
            Console.WriteLine($"Name 2: {Name4}");
            Console.WriteLine($"------------------");
            Console.WriteLine($"Name 1: {Name3} , GetHashCode : {Name3.GetHashCode()} ");
            Console.WriteLine($"Name 2: {Name4} , GetHashCode : {Name4.GetHashCode()} ");

            Name3 = "Ali";
            /*
             * Name3 has changed to a new Reference 
             * Name4 did not Change 
             */
            Console.WriteLine($"Name 1: {Name3}");
            Console.WriteLine($"Name 2: {Name4}");
            Console.WriteLine($"------------------");
            Console.WriteLine($"Name 1: {Name3} , GetHashCode : {Name3.GetHashCode()} ");
            Console.WriteLine($"Name 2: {Name4} , GetHashCode : {Name4.GetHashCode()} ");

            #endregion

            #endregion

            #region String Builder

            // Is A Class Internally Is Linked List
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            Console.WriteLine(sb.ToString());
            Console.WriteLine($"sb.GetHashCode: {sb.GetHashCode()}");
            Console.WriteLine("Enter Your Name");
            string Name5 = Console.ReadLine();
            sb.Append($"{Name5}");
            Console.WriteLine("-------------------");
            Console.WriteLine(sb.ToString());
            Console.WriteLine($"sb.GetHashCode : {sb.GetHashCode()}");

            #endregion

            #region String Builder Methods
            StringBuilder sb1 = new StringBuilder("Hello");
            Console.WriteLine(sb1);

            // Append
            sb1.Append("Asmaa"); // Push (add) new string in the end to sb1
            Console.WriteLine(sb1.ToString());

            // AppendLine
            sb1.AppendLine("Ahmed");
            Console.WriteLine(sb1.ToString());

            // Append by a Format
            sb1.AppendFormat("{0}+{1}={3}{3}", 5, 8, 13, true);
            Console.WriteLine(sb1.ToString());

            // Append Join
            sb1.AppendJoin("Asmaa", "Nada");
            Console.WriteLine(sb1.ToString());

            // copyTo
            char[] Chars = new char[10];
            sb1.CopyTo(0, Chars, 0, 3);
            foreach (char c in Chars)
            {
                Console.WriteLine(c);
            }

            // Insert
            sb1.Insert(0, "Amany");
            Console.WriteLine(sb1.ToString());

            // Remove
            sb1.Remove(0, 3);
            Console.WriteLine(sb1.ToString());

            // Reblace
            sb1.Replace("l", ",");
            Console.WriteLine(sb1.ToString());

            #endregion


            #region DateTime

            DateTime myDate = DateTime.Now;
            Console.WriteLine(myDate);

            string FormatDate = string.Format("Date is {0:yyyy MMMM dddd }", myDate); // Date is 2025 October Tuesday
                                                                                      // yyyy --> Year 
                                                                                      // yy  --> last 2 digits in yaer
                                                                                      // MM  --> Number of month 
                                                                                      // MMMM  --> Name of Month
                                                                                      // dd --> Number of Day
                                                                                      // Name of Day
            Console.WriteLine(FormatDate);

            DateTime date = new DateTime(2025, 10, 14);

            Console.WriteLine(myDate.Year);
            Console.WriteLine(myDate.Month);
            Console.WriteLine(myDate.Day);
            Console.WriteLine(myDate.Hour);
            Console.WriteLine(myDate.Minute);
            Console.WriteLine(myDate.Second);
            Console.WriteLine(myDate.Millisecond);

            #endregion


            #region DateOnly & TimeOnly

            DateOnly dateOnly = new DateOnly(2025, 11, 04);
            Console.WriteLine(dateOnly);
            Console.WriteLine(dateOnly.Year);
            Console.WriteLine(dateOnly.Month);
            Console.WriteLine(dateOnly.Day);


            TimeOnly timeOnly = new TimeOnly(8, 30);
            Console.WriteLine(timeOnly);

            TimeOnly timeOnlyPM = new TimeOnly(20, 30);
            Console.WriteLine(timeOnlyPM);

            #endregion


            #region Task

            // 1. Take input from user and get day name of your birthday

            Console.WriteLine("Enter Date");
            DateOnly birthday = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine(birthday.DayOfWeek);

            // 2. display birthday in this format : Saturday of Month March Year 2022

            Console.WriteLine($"{birthday.DayOfWeek} of Month {birthday.Month} Year {birthday.Year}");

            #endregion
        }
    }
}
