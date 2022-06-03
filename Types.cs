using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_03_Demo
{
    // Sealed Class: You Can't Inherit From this Class
    internal sealed class TypeOne:TypeTwo
    {
    }
    class TypeTwo   //  :TypeOne    XXXX
    {

    }
    abstract class TypeThree
    {
        public abstract void MyFun();
    }
    class TypeFour : TypeThree
    {
        // Sealed Method: You Can't Override this Method
        public sealed override void MyFun()
        {
            Console.WriteLine("Hello TypeFour");
        }
    }
    class TypeFive : TypeFour
    {
        // Not Valid XXXXXXX
        //public sealed override void MyFun()
        //{
        //    Console.WriteLine("Hello  TypeFive");
        //}
    }
}
