namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array
            // Array is Zero Base
            // Array in C# is Reference Type
            // object from Array Class
            // 

            #region 1D Array
            // Declare Array

            #region Declared by Programmer
            int[] arr; // Call Built in Class is Called Array
            // Is Declared in Stack And Point to Reference in Heap

            arr = new int[3]; // is turn from as Reference to be Object
                              // arr is sized to 3 Placed in Heap by 12 byte ( 3 (Places) * 4 byte (size of each place) )
                              // is declared by default 0
            int[] arr1 = { 1, 2, 4 };
            int[] arr2 = [1, 2, 4, 5];
            int[] arr3 = new int[] { 1, 2, 4 };
            int[] arr4 = new int[4] { 1, 2, 4, 9 };

            #endregion

            #region Intered By User
            int.TryParse(Console.ReadLine(), out int size);

            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            #endregion

            #region Output Its Elements
            // To print its elements
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);

            // By Foreach Loop
            foreach (int i in arr)
                Console.WriteLine(i);

            // By For Loop
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            // By While Loop
            int temp = 0;
            while (temp < arr.Length)
            {
                Console.WriteLine(arr[temp]);
                temp++;
            }
            #endregion

            #endregion

            #region 2D Array

            #region Array Declareation

            #region Intered By User
            int row = int.Parse(Console.ReadLine()), col = int.Parse(Console.ReadLine());
            int[,] Grades = new int[row, col];
            // CLR --> Will Allocate 60 Bytes At Heap
            // Initialized With The Default Value =0  

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Grades[i, j] = int.Parse(Console.ReadLine());
                }
            }
            #endregion

            #endregion

            #region Output Its Elements
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(Grades[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion

            #endregion

            #region Jugged Array
            // Multi Demintion Array
            // is like to vector of vector in C++

            #region اجتهاد شخصي

            //int.TryParse(Console.ReadLine(), out int rows);
            //object[] Marks = new object[rows];
            //for (int i = 0; i < rows; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out int cols);
            //    int[] temp = new int[cols];
            //    for (int j = 0; j < cols; j++)
            //    {
            //        temp[j] = int.Parse(Console.ReadLine());
            //    }
            //    Marks[i] = temp;
            //}
            //foreach (int[] i in Marks)
            //{
            //    for (int j = 0; j < i.Length; j++)
            //        Console.Write(i[j] + " ");
            //    Console.WriteLine();
            //}

            #endregion 



            #region Base Way
            int.TryParse(Console.ReadLine(), out int rows);
            int[][] Marks = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                int.TryParse(Console.ReadLine(), out int cols);
                Marks[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    Marks[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < Marks[i].Length; j++)
                    Console.Write(Marks[i][j] + " ");
                Console.WriteLine();
            }
            #endregion

            #endregion

            #region Ranges and Indices

            var Cities = new string[]
            {
                "Cairo", // 0 - 6
                "Gaza",  // 1 - 5
                "Alexandria", // 2 - 4
                "Krakow",  // 3 - 3
                "London",  // 4 - 2
                "Ram Allah"  // 5 - 1
            };

            Console.WriteLine(Cities[2]); // Second Element from Left

            Console.WriteLine(Cities[^2]); // Second Element from Right 

            var Copy1_Cities = Cities;
            foreach (var city in Copy1_Cities)
            {
                Console.WriteLine(city);
            }

            var Copy2_Cities = Cities[0..2]; // Copy Elements from 0 to 2-1 from Left
            foreach(var city in Copy2_Cities)
            {
                Console.WriteLine(city); 
            }

            var Copy3_Cities= Cities[^5..^2];// Copy Elements from 0 to 2-1 from Right
            foreach (var city in Copy3_Cities)
            {
                Console.WriteLine(city);
            }

            #endregion

            #region Array Methods

            int[] Arr1 = [1, 2, 3, 4, 5, 6];
            int.TryParse(Console.ReadLine(), out int Size);
            int[] Arr2 = new int[Size];
            for (int i = 0; i < Arr2.Length; i++)
                int.TryParse(Console.ReadLine(), out Arr2[i]);

            #region Class Mamber Methods

            // Copy
            int[] temp1 = new int[Arr1.Length];
            Array.Copy(Arr1, temp1, 3); // what i copy , where i copy , number of numbers i want copy
            foreach (int i in temp1)
                Console.Write(i + " ");
            Console.WriteLine();

            // Index Of
            Console.WriteLine(Array.IndexOf(Arr1, 4)); // return First index of value 4 from Left // Index 0 Base

            //Last Index 
            Console.WriteLine(Array.LastIndexOf(Arr2, 4)); // return First index of value 4 from Right // Index 0 Base

            #endregion

            #region Object Member Method

            // Copy To
            Arr2.CopyTo(Arr1, 0); // Copt Arr2 To Arr1 From Index 0

            // Size of Array
            Console.WriteLine(Arr1.Length);

            // Dimension of Array
            Console.WriteLine(Arr2.Rank);

            #endregion

            #region Sort Array

            #region Bubble Sort
            int[] array = { 9, 1, 8, 7, 2, 4, 5, 3, 7, 8 };

            Console.WriteLine("Before Sorting");
            foreach (int i in array)
                Console.Write(i + " ");

            Console.WriteLine();

            Console.WriteLine("Starting Sort Process");
            for (int i = 0; i < array.Length - 1; i++)
            {
                int swap = 0;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        swap = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = swap;
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("After Sorting");
            foreach (int i in array)
                Console.Write(i + " ");

            #endregion

            // Sort

            #region Sort Built-in Function

            Array.Sort(Arr2);
            foreach (int i in Arr2)
                Console.Write(i + " ");
            Console.WriteLine(); 

            #endregion

            #endregion

            #endregion

            #endregion



        }
    }
}
