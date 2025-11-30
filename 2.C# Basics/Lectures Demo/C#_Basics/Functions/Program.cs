namespace Functions_And_Methods
{
    /*
     * Class
     * Struct
     * Enum
     * Interface
     */
    internal class Program
    {
        /*
         * Variable
         * Property
         * Method
         */
        #region Create Functions
        public static void Print_Shape()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("#_#");
            }

        }
        public static void Print_Shape(int count = 10, string shape = "#_#") // Passing by Default
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(shape);
            }

        }
        public static void Print_Shape(string shape) // passing by Defualt
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("#_#");
            }

        }
        public static void Swap(int x, int y)
        {
            int temp = x;
            x = y; y = temp;
        }
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y; y = temp;
        }
        public static int Sum_Of_Array1(int[] Array) // passing by value
        {
            int sum = 0;
            if (Array?.Length > 0) // check if it not null
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    sum += Array[i];
                }
            }
            Array[0] = 100;
            return sum;
        }
        public static int Sum_Of_Array2(ref int[] Array) // passing by reference
        {
            int sum = 0;
            if (Array?.Length > 0)
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    sum += Array[i];
                }
            }
            Array[0] = 100;
            return sum;
        }
        public static int Sum_Of_Array3(int[] Array) // passing by value with changing in the way i use reverence type i passed 
        {
            int sum = 0;
            Array = new int[] { 10, 20, 30, 40, 50 };
            if (Array?.Length > 0)
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    sum += Array[i];
                }
            }
            Array[0] = 100;
            return sum;
        }

        #endregion

        // Entry Point
        static void Main(string[] args)
        {
            int x = 5, y = 10;
            int[] arr = new int[] { 1, 3, 2, 5, 7 };
            #region Functions Prototypes

            #endregion

            #region Passing by Value [ Value Type ]

            #endregion

            #region Passing by Value [ Reference Type ]
            Console.WriteLine(Sum_Of_Array1(arr));
            Console.WriteLine(arr[0]); // changing in function has made in array 
                                       // Because it is reference Type

            #endregion

            #region Passing by Reference [ Value Type ]
            Console.WriteLine(Sum_Of_Array1(arr));
            Console.WriteLine(arr[0]);
            #endregion

            #region Passing by Reference [ Reference Type ]

            #endregion

            #region Passing by Out [ Reference Type ]

            #endregion

            #region Passing by Out [ Reference Type ]

            #endregion

            #region Passing by Param [ Reference Type ]

            #endregion

            #region Passing by Param [ Reference Type ]

            #endregion
        }
    }
}
