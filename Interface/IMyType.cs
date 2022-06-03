using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_02_Demo.Interfaces
{
    internal interface IMyType
    {
        /// Default Access Modifier Inside Interface is public
        /// U Can't Use private Access Modifier Inside Interface

        /// What You Can Write Inside Interface?
        /// 1. Signature For Property
        /// 2. Signature For Method
        /// 3. Default Implemented Method (C# 8.0)

        decimal Salary { get; set; }

        void FunOne();

        internal void FunTwo()
        {
            Console.WriteLine("Default Implemented Method");
        }
    }
    class MyType : IMyType
    {
        decimal salary;
        public decimal Salary 
        { 
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public void FunOne()
        {
            Console.WriteLine("Function One");
        }
    }
}
