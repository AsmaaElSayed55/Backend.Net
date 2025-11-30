using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Square : Shape
    {
        public override double Perimeter
        {
            get
            {
                return Dim1 *4;
            }
        }

        public override double GetArea()
        {
            return Dim1 * Dim2;
        }
    }
}
