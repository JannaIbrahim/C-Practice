using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_03_Demo
{
    internal class Helper<T> where T: IComparable<T>

        /// T Must be a Class or Struct Implementing ICompareable

        /// Primary Constraint [0: 1]
        /// 1.General Primary Constarint
        /// class  => T Must Be Class 
        /// struct => T Must Be Struct
        /// Enum   => T Must Be Enum (C# 7.X)
        /// 2.Special Primary Constarint
        /// Point => T Must Be Point Or Another Class Inherits From Point

        /// Secondary Constraint (Interface Constarint) [0 : M]
        /// IComparable<T>
        /// T Must Be Class/Struct Implementing ICompareable 

        /// Constructor Constraint [0:1]
        /// T Must be Datatype Having Accessable(public) Parameterless Constructor
        /// Till C# 9.0 Only One Constructor Constraint
        /// Can't Use new() [Constructor Constraint] With struct [Special Primary Constraint]

    {
        #region Non Generic SWAP
        //public static void SWAP(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //public static void SWAP(ref double X, ref double Y)
        //{
        //    double Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //public static void SWAP(ref string X, ref string Y)
        //{
        //    string Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //public static void SWAP(ref Point X, ref Point Y)
        //{
        //    Point Temp = X;
        //    X = Y;
        //    Y = Temp;
        //} 
        #endregion

        //public static int Sum(T X, T Y) { return X + Y; } // There is no Operator Constraint
        public static void BubbleSort(T[] Arr)
        {
            for (int i = 0; i < Arr?.Length; i++)
                for (int j = 0; j < Arr?.Length-i-1; j++)
                        if (Arr[j].CompareTo(Arr[j+1]) == 1)
                            SWAP(ref Arr[j], ref Arr[j+1]);
        }
        public static int SearchArray(T[] Arr, T Value)
        {
            for (int i = 0; i < Arr?.Length; i++)
                if(Arr[i].Equals(Value))
                    return i;
            return -1;
        }
        public static void SWAP(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }
    }
    struct Employee:IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(Employee other)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Employee Right, Employee Left)
        {
            return Right.Equals(Left);
        }
        public static bool operator !=(Employee Right, Employee Left)
        {
            return !(Right.Equals(Left));
        }
    }
}
