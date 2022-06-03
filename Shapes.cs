using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Day_03_Demo
{
    /// Abstract Class
    /// is a Partial Class
    /// You Can't Create Object from this Class because it is not Concrete Class
    internal abstract class Shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        // Abstract Method = Virtual Method + No Implementation
        public abstract double CalcArea();

        // Abstract Property
        public abstract double Permieter { get; }
        public void Print()
        {
            Console.WriteLine("Hello");
        }
    }

    abstract class RectBase : Shape
    {
        public override double CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
    class Rect : RectBase
    {
        public override double Permieter
        {
            get { return 2 * (Dim02 + Dim01); }
        }
    }
    class Square : RectBase
    {
        public override double Permieter
        {
            get
            {
                return Dim01 * 4;
            }
        }
    }
    class Circle : Shape
    {
        public override double Permieter
        {
            get
            {
                return 2 * Math.PI * Dim01;
            }
        }
        public Circle(double Radius)
        {
            Dim01 = Dim02 = Radius;
        }
        public override double CalcArea()
        {
            return  Math.PI * Dim01 * Dim02;
        }
    }
}
