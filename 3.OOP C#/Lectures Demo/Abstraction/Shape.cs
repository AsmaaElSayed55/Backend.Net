using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    // Abstract Class : Partial class [Not Fully Implemented Class]
    // Concert class : Fully Implemented Class
    internal abstract class Shape
    {
        // Abstract class has at least one abstract member[method or property]
        public double Dim1 { get; set; }
        public double Dim2 { get; set; }

        // Abstract Method : Like Virtual method Without Implementation
        // in class that implement it , i implement it as override but in abstract class it dosen't contain a body , but in Concert class it has body
        public abstract double GetArea();
        public abstract double Perimeter { get; }
        
        // How to Calculate Area 

        
        // Make this method Abstract
    }
}
