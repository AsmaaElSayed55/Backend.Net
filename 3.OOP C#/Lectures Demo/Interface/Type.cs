using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Type :IType // Implement
    {
        public int MyProperty { get; set; }
        
        public void MyMethod()
        {
            Console.WriteLine("Hello From Class Type");
        }
    }
}
