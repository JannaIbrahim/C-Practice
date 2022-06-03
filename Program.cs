using Day_03_Demo.Operator_Overloading;
using System;

namespace Day_03_Demo
{
    internal class Program
    {
        public static void DoSomeCode()
        {
            int X = 0, Y = 0, Z;
            try
            {
                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());
                Z = X / Y;
                int[] Arr = new int[2];
                Arr[4] = 32;
                if (X > 0)
                    throw new CustomException();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Release Resources
                Console.WriteLine("Finally");
            }
        }
        public static void DoSomeProtectiveCode()
        {
            int X = 0, Y = 0, Z;
            do
            {
                Console.Write("Please Enter The First Number");
            } while (!int.TryParse(Console.ReadLine(), out X));
            do
            {
                Console.Write("Please Enter The First Number");
            } while (!int.TryParse(Console.ReadLine(), out Y) || Y == 0);

            Z = X / Y;
            int[] Arr = new int[2];
            if (Arr?.Length > 4)
                Arr[4] = 32;

        }
        static void Main(string[] args)
        {
            #region Operator Overloading

            Complex C1 = new Complex() { Real = 3, Imag = 4 };
            Complex C2 = new Complex() { Real = 2, Imag = 5 };

            Complex C3 = default, C4 = default;

            C3 = C1 + C2;
            C1 += C2;
            C4 = C2 + 3;
            C4 = ++C2;
            C4 = C2++;

            if (C1 > C2)
                Console.WriteLine("C1 is Greater than C2");
            else
                Console.WriteLine("C2 is Greater than C1");

            int Num = C1; // Implicit Casting
            string Str = (string)C2; // Eplicit Casting

            Console.WriteLine(C1);
            Console.WriteLine(C2);
            Console.WriteLine(C3);
            Console.WriteLine(C4);


            #endregion

            #region Casting Operators Overloading

            //Employee employee = new Employee()
            //{
            //    Id = 33,
            //    Name = "Ahmed Nasr",
            //    Salary = 3333
            //};

            //Person person = (Person)employee;

            //Console.WriteLine(person); // Ahmed Nasr

            #endregion

            #region Static
            Console.WriteLine(Utility.CalcCircleArea(40));

            //Utility U01 = new Utility(2, 3);
            //Utility U02 = new Utility(5, 6); // Object State => Date Of Object [X,Y]

            //Console.WriteLine(U01.Cm2Inch(10));
            //Console.WriteLine(U02.Cm2Inch(10));

            Console.WriteLine(Utility.Cm2Inch(10));
            Console.WriteLine(Utility.CalcCircleArea(40));
            #endregion

            #region Abstract
            Rect rect = new Rect() { Dim01 = 20, Dim02 = 12 };
            Console.WriteLine(rect.CalcArea());

            Circle circle = new Circle(21);
            Console.WriteLine(circle.CalcArea());
            #endregion

            #region Partial Class

            Car car = new Car() { Model = "BMW", Speed = 300 };

            #endregion

            #region Exception Handling

            DoSomeCode();

            try
            {
                DoSomeProtectiveCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion

            #region Generics

            #region Non Generic SWAP
            //int A = 3, B = 4;
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Helper.SWAP(ref A, ref B);
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //double K = 3.1, L = 2.5;
            //Console.WriteLine($"A = {K}");
            //Console.WriteLine($"B = {L}");
            //Helper.SWAP(ref A, ref B);
            //Console.WriteLine($"A = {K}");
            //Console.WriteLine($"B = {L}");

            //string str1 = "Ahmed", str2 = "Ali";
            //Console.WriteLine($"A = {str1}");
            //Console.WriteLine($"B = {str2}");
            //Helper.SWAP(ref A, ref B);
            //Console.WriteLine($"A = {str1}");
            //Console.WriteLine($"B = {str2}");

            //Point P01 = new Point(1, 2);
            //Point P02 = new Point(3, 4);
            //Console.WriteLine(P01);
            //Console.WriteLine(P02);
            //Helper.SWAP(ref P01, ref P02);
            //Console.WriteLine(P01);
            //Console.WriteLine(P02); 
            #endregion

            #region Generic SWAP

            int A = 3, B = 4;
            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");
            /// In Case Of Generic Method [Not Generic Class/Struct/Interface]
            /// Compiler Can Detect The Type Of T From Input Parameters Type
            Helper<int>.SWAP(ref A, ref B);
            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");

            double K = 3.1, L = 2.5;
            Console.WriteLine($"A = {K}");
            Console.WriteLine($"B = {L}");
            Helper<double>.SWAP(ref K, ref L);
            Console.WriteLine($"A = {K}");
            Console.WriteLine($"B = {L}");

            string str1 = "Ahmed", str2 = "Ali";
            Console.WriteLine($"A = {str1}");
            Console.WriteLine($"B = {str2}");
            Helper<string>.SWAP(ref str1, ref str2);
            Console.WriteLine($"A = {str1}");
            Console.WriteLine($"B = {str2}");

            Point P01 = new Point(1, 2);
            Point P02 = new Point(3, 4);
            Console.WriteLine(P01);
            Console.WriteLine(P02);
            Helper<Point>.SWAP(ref P01, ref P02);
            Console.WriteLine(P01);
            Console.WriteLine(P02);

            #endregion

            #region Search
            Employee E01 = new Employee() { Id = 10, Name = "Ahmed" };
            Employee E02 = new Employee() { Id = 20, Name = "Ali" };
            if (E01 == E02)
                Console.WriteLine("EQUAL");

            Employee[] employees = { E01, E02 };
            int Position = Helper<Employee>.SearchArray(employees, new Employee() { Id = 30, Name = "Hamda" });
            Console.WriteLine(Position);
            #endregion

            #region Sort
            Point[] points =
               {
                new Point(11, 2),
                new Point(3, 4),
                new Point(42, 76)
            };
            Helper<Point>.BubbleSort(points);
            foreach (var item in points)
                Console.WriteLine(item); 
            #endregion

            #endregion
        }
    }
}
