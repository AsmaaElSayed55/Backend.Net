using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Sealed
{
    internal sealed class TypeC : TypeB
    {
        public int C {  get; set; }
        // public sealed override int A { get => base.A; set => base.A = value; }
        // Can't override on sealed property
    }
}
