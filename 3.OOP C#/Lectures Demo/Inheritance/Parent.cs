using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Parent
    {
        
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Constructors
        public Parent(int x,int y)
        {
            X = x;
            Y = y;
        }

        #endregion

        #region Methods

        public virtual int Product() // to can override on it --> It must br virtual
        {
            return X*Y;
        }

        public override string ToString()
        {
            return $"X = {X} , Y = {Y} ";
        }
        public virtual void MyFun()
        {
            Console.WriteLine("I Am Parent");
        }
        #endregion
    }
}
