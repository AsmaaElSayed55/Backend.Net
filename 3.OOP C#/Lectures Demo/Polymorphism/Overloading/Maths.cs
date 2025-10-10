using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Overloading
{
    public class Maths
    {
        public int N {  get; set; }
        #region Method Overloading
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, int b)
        {
            return a + b;
        }
        public double Add(double a, int b, float c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }
        public string Add(string a, string b)
        {
            return a + b;
        }
        public string Add(string a, string b, string c)
        {
            return a + b + c;
        }
        #endregion

        #region Operator Overloading
        public static Maths operator +(Maths a, Maths b) 
        {
            return new Maths()
            {
               // A = a.A + b.B,
               // B = a.B + b.B
            };
        }
        public static Maths operator -(Maths a, Maths b)
        {
            return new Maths()
            {
                //A = a.A - b.B,
                //B = a.B - b.B
            };
        }

        #endregion
        #region Methods
        public override string ToString()
        {
            return ToString();
        }
        #endregion
    }
}
