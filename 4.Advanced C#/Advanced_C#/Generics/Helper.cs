using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Helper // <T01> where T01 : notnull , IComparer<T01> , IComparable , ICloneable , new() // --> this Constraint only with Class
    {
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y; y = temp;
        }
        public static void Swap(ref double x, ref double y)
        {
            double temp = x;
            x = y; y = temp;
        }
        public static void Swap(ref Point x, ref Point y)
        {

            Point temp = x;
            x = y; y = temp;

        }
        // Generic
        public static void Swap<T>(ref T X, ref T Y)
        {
            T temp = X;
            X = Y; Y = temp;
        }
        public static void Swap<T>(T X, T Y)
        {
            T temp = X;
            X = Y; Y = temp;
        }
        //public static void Swap<T1,T2>(ref T1 X, ref T2 Y)
        //{
        //    T1 temp = X;
        //  //  X = Y; Y = temp;
        //}
        public static int LinearSearch<T>(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value)) return i;

            }
            return -1;
        }

        public static int LinearSearch<T>(T[] array, T value , IEqualityComparer<T> equalityComparer) // use Built-in Interface to compare spesific member 
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (equalityComparer.Equals(array[i],value)) return i;

            }
            return -1;
        }

        // T : Must Be Type Which Implement The IComparable Interface
        public static void BubbleSort<T>(T[] arr) where T : IComparable<T>
        {
            if (arr?.Length != 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        if (arr[j].CompareTo(arr[j + 1]) > 0)
                            Swap(ref arr[j], ref arr[j + 1]);

                    }
                }
            }
        }

        public static void BubbleSort<T>(T[] arr,IComparer<T> comparer) where T : IComparable<T>
        {
            if (arr?.Length != 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        if (comparer.Compare(arr[j], arr[j+1]) > 0)
                            Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
    }
}
