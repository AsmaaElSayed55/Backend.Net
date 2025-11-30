using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Sealed
{
    internal class TypeA
    {
        public virtual int A {  get; set; }
        public virtual void MyFun()
        {
            Console.WriteLine("My Fun From Type A ");
        }
    }
}
