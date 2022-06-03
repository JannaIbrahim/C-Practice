using Day_02_Demo.Binding;
using Day_02_Demo.Interface;
using System;

namespace Day_02_Demo
{
    
    internal class Program
    {
        #region Polymorphism => 1. Function Overloading

        public static int Sum(int X, int Y)
        {
            return X + Y;
        }
        public static int Sum(int X, int Y, int Z)
        {
            return X + Y + Z;
        }
        public static double Sum(int X, double Y)
        {
            return X + Y;
        }
        public static double Sum(double X, int Y)
        {
            return X + Y;
        }
        #endregion

        #region Interface Example 02

        //public static void ProccessSeries(SeriesByTwo series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current} , ");
        //        series.GetNext();
        //    }
        //    series.Reset();
        //    Console.WriteLine();
        //}
        //public static void ProccessSeries(SeriesByThree series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current} , ");
        //        series.GetNext();
        //    }
        //    series.Reset();
        //    Console.WriteLine();
        //}

        public static void ProccessSeries(ISeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{series.Current} , ");
                series.GetNext();
            }
            series.Reset();
            Console.WriteLine();
        }
        #endregion

        static void Main(string[] args)
        {
            #region Polymorphism => 1. Function Overloading

            //int A = 3, B = 2;
            //int Result = Sum(A, B);
            //Console.WriteLine(Result);

            //Result = Sum(A, B, 4);
            //Console.WriteLine(Result);

            //double Result2 = Sum(3.3, 3);
            //Console.WriteLine(Result2);

            //Result2 = Sum(2, 2.3);
            //Console.WriteLine(Result2);

            #endregion

            #region Polymorphism => 2. Function Overriding (Binding)

            TypeA typeA = new TypeA(1);
            typeA.A = 2;
            typeA.StaticBindedShow(); // I am Base (Parent)

            TypeB typeB = new TypeB(1, 2);
            typeB.A = 30;
            typeB.B = 31;
            typeB.StaticBindedShow(); // I am Derived (Child)

            /// Binding
            /// Base Reference = Child Object 
            TypeA BaseRef = new TypeB(3, 4);
            BaseRef.A = 5;
            BaseRef.StaticBindedShow(); // I am Base (Parent)
                                        //// 1. Static Binding (Early Binding) => Compiler Will Bind Function Call Based On Reference Type 
                                        ////                                   Not Object Type at Compilation Time.

            BaseRef.DynamicBindedShow(); // TypeB 5, 4
            //// 2. Dynamic Binding (Late Binding) => CLR Will Bind Function Call Based On Object Type 
            ////                                   Not Reference Type at Run Time.

            typeA = new TypeC(9, 7, 4);
            typeA.DynamicBindedShow(); // TypeC 9 7 4
            typeB = new TypeC(5, 6, 3);
            typeB.DynamicBindedShow(); // TypeC 5 6 3

            typeA = new TypeD(9, 7, 4, 3);
            typeA.DynamicBindedShow(); // TypeC 9 7 4
            typeB = new TypeD(5, 6, 3, 2);
            typeB.DynamicBindedShow(); // TypeC 5 6 3
            TypeD typeD = new TypeD(9, 6, 3, 1);
            typeD.DynamicBindedShow();// TypeD 9 6 3 1


            #endregion

            #region Interface Example 02

            SeriesByTwo series01 = new SeriesByTwo();
            ProccessSeries(series01);

            SeriesByThree series02 = new SeriesByThree();
            ProccessSeries(series02);

            #endregion

            #region Interface Exmaple 03

            //Employee employee01 = new Employee();
            //employee01.Id = 1;
            //employee01.Name = "Ahmed";
            //employee01.Salary = 3000;

            Employee Emp01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 3000 }; // Object Initializer

            Employee Emp02 = new Employee() { Id = 2, Name = "Ali", Salary = 4000 };

            Console.WriteLine(Emp01);
            Console.WriteLine(Emp02);

            //Emp01 = Emp02; // Shallow Copy
            // Emp01 referes to the same object that Emp02 refering, So That This Object Have 2 References (اسمين دلع)

            Emp01 = new Employee(Emp02); // Deep Copy Using Copy Constructor
            Emp01 = (Employee)Emp02.Clone(); // Deep Copy Using Clone Method Existed In Clonable Interface
            // Emp01 is a new allocated object with new identity, but with the same state (data) of Emp02

            Console.WriteLine(Emp01);
            Console.WriteLine(Emp02);


            /*===========================================================================================*/

            Employee[] Emps = new Employee[]
            {
                new Employee(1, "Ahmed", 3000),
                new Employee(2, "Mohamed", 4000),
                new Employee(3, "Aya", 2000)
            };

            Array.Sort(Emps);
            foreach (var item in Emps)
                Console.WriteLine(item);

            #endregion


        }
    }
}
