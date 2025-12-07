using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal struct EmployeeStruct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public static bool operator ==(EmployeeStruct left, EmployeeStruct right)
        {
            return left.Id==right.Id && left.Name==right.Name && left.Age==right.Age && left.Salary==right.Salary;
        }
        public static bool operator !=(EmployeeStruct left, EmployeeStruct right)
        {
            return left.Id != right.Id || left.Name != right.Name || left.Age != right.Age || left.Salary != right.Salary;
        }
        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} , Age : {Age} , Salary : {Salary}";
        }
    }
}
