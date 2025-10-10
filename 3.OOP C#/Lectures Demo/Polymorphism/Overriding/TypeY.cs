using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Overriding
{
    internal class TypeY:TypeX
    {
        #region Properties
        public int Y { get; set; }

        #endregion

        #region Constructors
        public TypeY(int x,int y) :base(x)
        {
            Y = y;
        }

        #endregion

        #region Methods

        // Using "New" To Hiding Inherited Member TypeX.MyFun1() [New Version - Masking]
        new public void MyFun1() // Static Polymorphism [Compile-Time] -> Calling Function Based On Object Type
        {
            Console.WriteLine("This Is MyFun1 From Derived [Child]");
        }

        // Using Keyword "Override" To Inherited Member TypeX.MyFun2()
        // TypeX.MyFun2() Must Be Marked As Virtual Method and Non-Private In Its First Appearance

        // 
        public override void MyFun2() // Dynamic Polymorphism [Run-Time] -> Calling Function Based On Object Type 
        {
            Console.WriteLine($"This Is MyFun2 From Derived TypeY : X : {X}, Y : {Y}");
        }
        #endregion

    }
}
