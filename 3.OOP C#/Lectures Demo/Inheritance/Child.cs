using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Child : Parent
    {
        #region Properties
        //public int X { get; set; } // is inherited from Parent class
        //public int Y { get; set; } // is inherited from Parent class
        public int Z { get; set; }
        #endregion

        #region Constructors
        public Child(int x,int y,int z):base(x,y)
        {
            //X= x; Y = y; // this is parent class task 
            Z= z;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"X = {X} , Y = {Y} , Z = {Z}";
        }
        public override int Product()
        {
            return base.Product()*Z;
        }
        public override void MyFun()
        {
            Console.WriteLine("I Am Child.");
        }
        #endregion
    }
}
