using Boxing_And_Nullable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_And_Nullable
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public decimal Salary { get; set; }

        public Department? Department { get; set; }

        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} , Age : {Age} , Salary : {Salary} , Department : {Department}";
        }
    }
}
