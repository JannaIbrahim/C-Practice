using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_02_Demo.Binding
{
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int _A)
        {
            A = _A;
        }


        // Static Binded Method
        public void StaticBindedShow()
        {
            Console.WriteLine("I am Base (Parent)");
        }

        // Dynamic Binded Method
        // Must be non private virtual at First Apperance
        public virtual void DynamicBindedShow()
        {
            Console.WriteLine($"TypeA {A}");
        }
    }
    class TypeB: TypeA
    {
        public int B { get; set; }
        public TypeB(int _A, int _B):base(_A)
        {
            B = _B;
        }

        /// Overriding With New
        /// Static Binded Method
        public new void StaticBindedShow()
        {
            Console.WriteLine("I am Derived (Child)");
        }

        /// Overriding With Override
        ///
        public override void DynamicBindedShow()
        {
            Console.WriteLine($"TypeB {A} {B}");
        }
    }
    class TypeC:TypeB
    {
        public int C { get; set; }

        public TypeC(int _A, int _B, int _C):base(_A, _B)
        {
            C = _C;
        }

        public override void DynamicBindedShow()
        {
            Console.WriteLine($"TypeC {A} {B} {C}");
        }
    }

    class TypeD:TypeC
    {
        public int D { get; set; }
        public TypeD(int _A, int _B, int _C, int _D) : base(_A, _B, _C)
        {
            D = _D;
        }

        public new void DynamicBindedShow()
        {
            Console.WriteLine($"TypeD {A} {B} {C} {D}");
        }
    }
}
