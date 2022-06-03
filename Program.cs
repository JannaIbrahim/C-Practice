using System;

namespace Day_02_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Route");

            #region Value Type
            //int X;
            /////int : C# Keyword
            /////Allocation 4 UnInitialized Bytes in Stack

            //X = 5;

            //Int32 Y;
            /////Int32: .NET BCL 
            /////Allocation 4 UnInitialized Bytes in Stack

            //Y = X;
            //++X;

            //Console.WriteLine(X);
            //Console.WriteLine(Y); 
            #endregion

            #region Refernce Type
            //Point P1;
            //// Zero Bytes Allocated at Heap
            //P1 = new Point();
            ///// new
            ////// 1.Allocate Required Number of Bytes in Heap (Object Size + CLR Overhead Variables)
            ////// 2.Initialize (cross out ) Allocted Bytes With Default Value Of Its Datatype
            ////// 3.Call User-Defined Constructor if exists
            ////// 4.Assign The Reference to a allocated Object

            //Point P2 = new Point();

            //P2 = P1;

            //P1.X = 5;

            //Console.WriteLine(P1.X); // 5
            //Console.WriteLine(P2.X); // 5 
            #endregion

            #region Object

            //object O1 = new object();

            //object O2 = new object();

            //Console.WriteLine(O1.GetHashCode());
            //Console.WriteLine(O2.GetHashCode());

            //O2 = O1;
            //Console.WriteLine("After Assignment");

            //Console.WriteLine(O1.GetHashCode());
            //Console.WriteLine(O2.GetHashCode());

            #endregion

            #region Fractions and Discards
            // 7727383333
            //int X = 17;
            // 2.2
            //float MyVar = 15.3f;
            //double MyVar02 = 1456.321;
            //decimal MyV = 15.3M;

            //int X = 1_000_000; // _ : Discards
            #endregion

            #region Value Type Casting

            // 1. Implicit Casting (Safe Casting)
            //int X = 5;
            //long Y = X; 
            //Y = 73737373737;

            // 2. Explicit Casting (UnSafe Casting)
            //X = (int) Y; 
            //unchecked
            //{
            //    X = (int)Y; 
            //}
            //checked
            //{
            //    X = (int)Y;
            //}

            // 3. Parse (Convert From String To Any Datatype)
            //X = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please Enter Your Name:");
            //string Name = Console.ReadLine();
            //Console.WriteLine("Please Enter Your Age");
            //int Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Hello "+ Name);
            //Console.WriteLine("Your Age Is "+ Age);

            // 4. Convert (Convert From Any Datatype To Any Datatype)
            //Y = Convert.ToInt32(Console.ReadLine()); 
            //Console.WriteLine("Please Enter Your Name:");
            //string Name = Console.ReadLine();
            //Console.WriteLine("Please Enter Your Age");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Hello "+ Name);
            //Console.WriteLine("Your Age Is "+ Age);
            #endregion

            #region Operators

            #region Unary Operators
            //// Unary Operators => Works On One Operand (Variable)
            //int X = 10;
            //// PreFix [Increment and then Print]
            //Console.WriteLine(++X); // Print 11
            //// PostFix [Print and then Increment]
            //Console.WriteLine(X++); // Print 10

            //// PreFix [Decrement and then Print]
            //Console.WriteLine(--X); // Print 9
            //// PostFix [Print and then Decrement]
            //Console.WriteLine(X--); // Print 10  
            #endregion

            #region Binary Operators

            //// Unary Operators => Works On Two Operands (Variables)
            //int Sum, Mul, Div, Sub, Mod;
            //int Num01 = 2, Num02 = 4;
            //Sum = Num01 + Num02;
            //Sub = Num02 - Num01;
            //Mul = Num01 * Num02;
            //Div = Num01 / Num02;
            //Mod = Num02 % Num01;

            #endregion

            #region Assignment Operator

            //int X;
            //X = 4;
            //X += 2; // X = X + 2
            //X -= 2; // X = X - 2
            //X *= 2; // X = X * 2
            //X /= 2; // X = X / 2
            //X %= 2; // X = X % 2

            #endregion

            #region Relational Operators [Comparsion]

            //int X = 6, Y = 5;
            //Console.WriteLine(X == Y); // Equal
            //Console.WriteLine(X != Y); // Not Equal
            //Console.WriteLine(X > Y);  // More Than
            //Console.WriteLine(X >= Y); // More Than Or Equal
            //Console.WriteLine(X < Y);  // Less Than
            //Console.WriteLine(X <= Y); // Less Than Or Equal


            #endregion

            #region Logical Operators

            //Console.WriteLine(!false);
            //Console.WriteLine(false && true);
            //Console.WriteLine(true || false);

            //Console.WriteLine(4 < 5 && 7 < 9);

            #endregion

            #region Bitwise Operators

            //Console.WriteLine(!false);
            //Console.WriteLine(false & true);
            //Console.WriteLine(true | false);

            //Console.WriteLine(4 < 5 & 7 < 9);

            #endregion

            #region Teranry Operator [Conditional Operator]

            //bool Flag = 4 > 2 ? true : false;
            //Console.WriteLine(Flag);

            #endregion

            #endregion

            #region Operator Priorty [Precedence] and Associtvity

            /*
                     1. Unary Operator (PreFix)
                     2. Round Braces ()
                     3. * / %
                     4. + -
            */

            //int a = 20;
            //int b = 10;
            //int c = 15;
            //int d = 5;
            //int e;
            //e = (a + b) * c / d;     // ( 30 * 15 ) / 5

            //e = ((a + b) * c) / d;   // (30 * 15 ) / 5

            //e = (a + b) * (c / d);   // (30) * (15/5) 

            //e = a + (b * c) / d;    //  20 + (150/5)  
            #endregion

            #region String Formating

            // Equation: 4 + 2 = 6
            //int X = 4, Y = 2;

            //string Message = "Equation : " + X + " + " + Y + " = " + X + Y;

            //// String Interpolation
            //Message = string.Format("Equation : {0} + {1} = {2}", X, Y, X + Y);
            //Console.WriteLine(Message);
            //Console.WriteLine("Equation : {0} + {1} = {2}", X, Y, X + Y);

            /////$ : String Manipulation Operator
            //Message = $"Equation : {X} + {Y} = {X + Y}";
            //Console.WriteLine(Message);

            //Console.WriteLine($"Equation : {X,5}+{Y,-5}={X + Y:c}");

            #endregion

            #region Conditional Statments

            #region If & Switch Ex01

            //int X;
            //X = int.Parse(Console.ReadLine());
            //if ( X ==1)
            //    Console.WriteLine("Jan");
            //else if (X ==2)
            //    Console.WriteLine("Feb");
            //else if (X ==3)
            //    Console.WriteLine("Mar");
            //else
            //    Console.WriteLine("Not in Q01");


            //switch (X)
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mar");
            //        break;
            //    default:
            //        Console.WriteLine("Not in Q03");
            //        break;
            //}
            #endregion

            #region If & Switch Ex02

            //Console.WriteLine("Please Enter Your Name");
            //string Name = Console.ReadLine();
            //if(Name == "Ahmed")
            //    Console.WriteLine("Hello Ahmed");
            //else if(Name == "Ali")
            //    Console.WriteLine("Hello Ali");
            //else if(Name == "Esraa")
            //    Console.WriteLine("Hello Esraa");
            //else if(Name == "Mai")
            //    Console.WriteLine("Hello Mai");

            //switch (Name)
            //{
            //    case "Ahmed":
            //        Console.WriteLine("Hello Ahmed");
            //        break;
            //    case "Ali":
            //        Console.WriteLine("Hello Ali");
            //        break;
            //    case "Esraa":
            //        Console.WriteLine("Hello Esraa");
            //        break;
            //    case "Mai":
            //        Console.WriteLine("Hello Mai");
            //        break;
            //}
            #endregion

            #region Switch Ex02

            //int Value = 3000;

            //switch (Value)
            //{
            //    case 3000:
            //        Console.WriteLine("Option 03");
            //        Console.WriteLine("Option 02");
            //        Console.WriteLine("Option 01");
            //        break;
            //    case 2000:
            //        Console.WriteLine("Option 02");
            //        Console.WriteLine("Option 01");
            //        break;

            //    case 1000:
            //        Console.WriteLine("Option 01");
            //        break;
            //    default:
            //        Console.WriteLine("NA");
            //        break;
            //}

            //switch (Value)
            //{
            //    case 3000:
            //        Console.WriteLine("Option 03");
            //        //Console.WriteLine("Option 02");
            //        //Console.WriteLine("Option 01");
            //        goto case 2000;
            //        //break;
            //    case 2000:
            //        Console.WriteLine("Option 02");
            //        //Console.WriteLine("Option 01");
            //        goto case 1000;
            //        //break;
            //    case 1000:
            //        Console.WriteLine("Option 01");
            //        break;
            //    default:
            //        Console.WriteLine("NA");
            //        break;
            //} 
            #endregion

            #endregion

            #region Loops Statments

            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");

            //// 1. For
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //// 2. Do While
            //int x;
            //bool flag = true;
            //do
            //{
            //    Console.WriteLine("Please Enter Even Number");
            //    //x = int.Parse(Console.ReadLine());
            //    flag = int.TryParse(Console.ReadLine(), out x);
            //    if (x == 0)
            //        x = 1;
            //} while (x % 2 == 1 || !flag);

            //// 3. While
            //while (dbConnection)
            //{

            //}


            //// 4. Foreach
            //string Name = "Ahmed";
            //foreach (char item in Name)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


        }
    }
}
