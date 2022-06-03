using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_03_Demo
{
    /// Static Class
    /// is a just Container For Static Members [Attribute, Property, Constructor, Method] 
    /// and Constants
    /// You Can't Create Object From This Class (Helper Class)
    /// No Inheritance for this Class
    internal static class Utility
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        //public Utility(int _X, int _Y)
        //{
        //    X = _X;
        //    Y = _Y;
        //    //pi = 3.14; // XXXX
        //    // Object Constructor is not the right place to initialize Static Attributes
        //}

        /// Static Constructor [Maximum Only One Static Constructor Per Class]
        /// Can't Specifiy Access Modifiers or Parameters for Static Constructor
        /// Will be Executed Just Only One Time Per Class Lifetime Before the firts Usage of Class
        /// Usages Of Class
        /// 1. Call Static Mehtod or Static Property
        /// 2. Create Object From This Class
        /// 3. Create Object From Another Class Inheriting From This Class
        static Utility()
        {
            // Static Constructor [Class Constructor] is the right place to initialize Static Attributes
            pi = 3.14;
        }

        // Static Method => is a class method [Called through the Class]
        public static double Cm2Inch(double Cm)
        {
            return Cm / 2.54;
        }

        // const double pi = 3.14; // Constant Attribute

        static double pi; // Static Attribute
        /// Any Static Attribute, Compiler Will Initialize it With Default Value of its DataType
        /// pi = 0

        // Static Property Must return Static Attribute or Constant Attribute
        public static double Pi { get { return pi; } } 

        public static double CalcCircleArea(double Radius)
        {
            //Utility utility1 = new Utility(1, 2);
            //Utility utility2 = new Utility(3, 4);

            return Utility.Pi * Radius * Radius;
        }
    }

}
