using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Point :IComparable<Point>
    {
        public int X { get; set; } 
        public int Y { get; set; }
        public Point(int x,int y)
        {
            X = x;  
            Y = y;
        }
        public override string ToString()
        {
            return $"{X}:{Y}";
        }

        //public int CompareTo(object? obj)
        //{
        //    if (obj is not null)
        //    {
        //        Point P = (Point)obj;
        //        if (X == P.X)
        //            return Y.CompareTo(P.Y);
        //        else return X.CompareTo(P.X);
        //    }
        //    return 1;
        //}
        public int CompareTo(object? obj)
        {
            // there are two operators i used them to casting
            // 1. is conditional operator 
            // 2. as casting operator 
            if (obj is not null)
            {
              //  Point P = obj as Point; // 2. as casting operator
                if (obj is Point P)  // 1. is conditional operator
                {
                    // Point P = (Point)obj;
                    if (X == P.X)
                        return Y.CompareTo(P.Y);
                    else return X.CompareTo(P.X);
                }
                return 1;
            }
            return 1;
        }

        public int CompareTo(Point? other)  // make parameter as Point like to class that implement this interface
        {
            if (other is not null)
            {
                if (X == other.X)
                    return Y.CompareTo(other.Y);
                else return X.CompareTo(other.X);
            }
            return 1;
        }
    }
}
