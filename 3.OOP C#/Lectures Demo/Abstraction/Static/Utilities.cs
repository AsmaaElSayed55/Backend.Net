using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Static
{
    internal class Utilities
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }
        public static double PI
        {
            get
            {
                return 3.14;
            }
        }
    }
}
