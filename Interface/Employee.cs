using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_02_Demo.Interface
{
    internal class Employee: ICloneable, IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee()
        {

        }
        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        // Copy Constructor
        public Employee(Employee EmpCopy)
        {
            Id= EmpCopy.Id;
            Name = EmpCopy.Name;
            Salary = EmpCopy.Salary;
        }
        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary}";
        }

        public object Clone()
        {
            //return new Employee()
            //{
            //    Id = Id,
            //    Name = Name,
            //    Salary = Salary
            //};
            return new Employee(this); // Using Copy Constructor
        }

        /// Return +ve : this.Salary > Obj.Salary
        /// Return -ve : this.Salary < Obj.Salary
        /// Return 0   : this.Salary = Obj.Salary
        public int CompareTo(object obj)
        {
            Employee Right = (Employee) obj;
            if(this.Salary > Right.Salary)
                return 1;
            else if(this.Salary < Right.Salary)
                return -1;
            else
                return 0;
        }
    }
    
}
