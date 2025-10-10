using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Overriding
{
    internal class TypeX
    {
        #region Properties
        public int X { get; set; }

        #endregion

        #region Constructors
        public TypeX (int x)
        {
            X = x;
        }

        #endregion

        #region Methods

        // Non-Virtual Method
        public void MyFun1()
        {
            Console.WriteLine("This Is MyFun1 From Base And I Am Base");
        }

        // Virtual Method
        virtual public void MyFun2() 
        {
            Console.WriteLine($"This Is MyFun2 From Base And TypeX : {X}");
        }
        #endregion
    }
}
