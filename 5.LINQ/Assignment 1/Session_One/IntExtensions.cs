using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_One
{
    internal static class IntExtensions
    {
        // Extension Method must be added to static class and noon generic class
        
        public static string ToString(this int x)
        {
            return $"Hello From My ToString";
        }
        public static int ReverseNum(this int num)
        {
            int reminder = 0, reversedNum = 0;
            while(num!=0)
            {
                reminder = num % 10; // 12345
                reversedNum = reversedNum * 10 + reminder;
                num = num / 10;
            }
            return reversedNum;
        }

        public static long ReverseNum(this long num)
        {
            long reminder = 0, reversedNum = 0;
            while (num != 0)
            {
                reminder = num % 10; // 12345
                reversedNum = reversedNum * 10 + reminder;
                num = num / 10;
            }
            return reversedNum;
        }


    }
}
