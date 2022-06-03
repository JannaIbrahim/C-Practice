using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_03_Demo.Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        #region Operator Overloading
        /// Must be Static Member Functions
        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Right?.Real ?? 0) + (Left?.Real ?? 0),
                Imag = (Right?.Imag ?? 0) + (Left?.Imag ?? 0)
            };
        }

        public static Complex operator +(Complex Left, int Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) + Right,
                Imag = Left?.Imag ?? 0
            };
        }
        public static Complex operator ++(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) + 1,
                Imag = C?.Imag ?? 0
            };
        }

        public static bool operator > (Complex Left, Complex Right)
        {
            if (Left?.Real != Right?.Real)
                return Left?.Real > Right?.Real;
            else
                return Left?.Imag > Right?.Imag;
        }
        public static bool operator < (Complex Left, Complex Right)
        {
            if (Left?.Real != Right?.Real)
                return Left?.Real < Right?.Real;
            else
                return Left?.Imag < Right?.Imag;
        }

        public static implicit operator int(Complex C)
        {
            return C?.Real ?? 0;
        }
        public static explicit operator string (Complex C)
        {
            return C?.ToString() ?? "NA";
        }
        #endregion

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }
}
