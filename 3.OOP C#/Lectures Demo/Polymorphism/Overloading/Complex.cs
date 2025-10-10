using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Overloading
{
    // 2 + 5i
    internal class Complex
    {
        #region Properties
        public int Real { get; set; }
        public int Img { get; set; } 
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Real}+{Img}i";
        }
        #endregion

        #region Operator Overloading

        #region Binary Operator
        //public static Complex operator + (Complex left, Complex right )
        //{
        //    Complex result = new Complex();
        //    result.Real= left.Real + right.Real;
        //    result.Img= left.Img + right.Img;
        //    return result ;
        //}


        /// Another Way

        // '+' Operator
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0 + right?.Real) ?? 0, // if left.Real is null --> put in it 0
                                                               // if left.Real is null --> put in it 0

                // Operator '+' Get Evaluated before The null coalescing Operator '??'

                Img = left?.Img ?? 0 + right?.Img ?? 0,    // if left.Real is null --> put in it 0
                                                           // if left.Real is null --> put in it 0
            };
        }

        // '-' Operator
        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0), // if left.Real is null --> put in it 0
                                                               // if left.Real is null --> put in it 0

                // Operator '+' Get Evaluated before The null coalescing Operator '??'

                Img = (left?.Img ?? 0) - (right?.Img ?? 0),    // if left.Real is null --> put in it 0
                                                               // if left.Real is null --> put in it 0
            };
        }

        // '*' Operator
        public static Complex operator *(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) * (right?.Real ?? 0),

                Img = (left?.Img ?? 0) * (right?.Img ?? 0),
            };
        }

        // '/' Operator
        public static Complex operator /(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) / (right?.Real ?? 1), // if left.Real is null --> put in it 0
                                                               // if left.Real is null --> put in it 0

                // Operator '+' Get Evaluated before The null coalescing Operator '??'

                Img = (left?.Img ?? 0) / (right?.Img ?? 1),    // if left.Real is null --> put in it 0
                                                               // if left.Real is null --> put in it 0
            };
        }

        // '%' Operator
        public static Complex operator %(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) % (right?.Real ?? 1), // if left.Real is null --> put in it 0
                                                               // if left.Real is null --> put in it 0

                // Operator '+' Get Evaluated before The null coalescing Operator '??'

                Img = (left?.Img ?? 0) % (right?.Img ?? 1),    // if left.Real is null --> put in it 0
                                                               // if left.Real is null --> put in it 0
            };
        }

        #endregion

        #region Unary Operator
        public static Complex operator ++(Complex C)
        {
            return new Complex()
            {
                Real= ( C?.Real ?? 0 ) +1,
                Img=  C?.Img ?? 0 
            };
        }
        public static Complex operator --(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) - 1,
                Img = C?.Img ?? 0
            };
        }
        #endregion

        #region Relational Operators
        public static bool operator >(Complex left, Complex right)
        {
            // left.Real > right.Real => True
            // left.Real < right.Real => false
            // left.Real == right.Real 
            // left.Ima > right.Img => True
            // left.Ima > right.Ima => False
            if(left?.Real == right?.Real)
                return left?.Img > right?.Img;
            else 
                return left?.Real > right?.Real ;
        }
        public static bool operator <(Complex left, Complex right)
        {
            // left.Real < right.Real => True
            // left.Real > right.Real => false
            // left.Real == right.Real 
            // left.Ima < right.Img => True
            // left.Ima > right.Ima => False
            if (left?.Real == right?.Real)
                return left?.Img < right?.Img;
            else
                return left?.Real < right?.Real;
        }
        public static bool operator ==(Complex left, Complex right)
        {

            if (left?.Real == right?.Real)
                return left?.Img == right?.Img;
            else
                return false;
        }
        public static bool operator !=(Complex left, Complex right)
        {

            if (left?.Real != right?.Real)
                return left?.Img != right?.Img;
            else
                return false;
        }
        #endregion

        #region Casting Overloading

        public static explicit operator int (Complex C)
        {
            return C?.Real ?? 0;
        }

        public static implicit operator string(Complex C)
        {
            return C?.ToString() ?? string.Empty ;
        }

        #endregion

        #endregion
    }
}
