using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_03_Demo.Operator_Overloading
{
    internal class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }

        public static /*Person*/ explicit operator Person(Employee employee)
        {
            string[] Names = employee?.FullName.Split(' ');
            return new Person()
            {
                FName = Names[0],
                LName = Names[1]
            };
        }
        public override string ToString()
        {
            return $"{FName} {LName}";
        }
    }
}
