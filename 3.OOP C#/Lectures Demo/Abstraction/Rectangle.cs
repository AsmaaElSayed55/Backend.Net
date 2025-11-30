using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Rectangle : Shape // Rectangle class Inherit and Implement Shape class
    {
        public override double Perimeter
        {
            get
            {
                return (Dim1 + Dim2)*2;
            }
        }
        public override double GetArea()
        {
            return Dim1 * Dim2;
        }
    }
}
