using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_03_Demo
{
    internal class Point:IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int _X, int _Y)
        {
            X = _X; 
            Y = _Y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public int CompareTo(object obj)
        {
            //Point Right = (Point) obj; // Explicit Casting (Unsafe Casting), Will Throw Exception

            #region is Conditional Operator
            // is Conditional Operator
            // return False if Obj is not Point or Class Inheriting from Point [Point3D]
            //if (obj is Point Right)
            //{
            //    if (Right == null) return 1;
            //    if(this.X == Right.X) 
            //        return this.Y.CompareTo(Right.Y);
            //    else
            //        return this.X.CompareTo(Right.X);
            //}
            //return -1; 
            #endregion

            #region as Casting Operator
            // As Casting Operator
            // if Casting Failed, Will return Null (Zero Exceptions will be Thrown)
            Point Right = obj as Point;
            if (Right == null) return 1;
            if (this.X == Right.X)
                return this.Y.CompareTo(Right.Y);
            else
                return this.X.CompareTo(Right.X); 
            #endregion
        }

        public int CompareTo(Point other)
        {
            if(other == null) return 1;
            if(this.X == other.X)
                return Y.CompareTo(other.Y);
            else
                return X.CompareTo(other.X);
        }
    }
}
