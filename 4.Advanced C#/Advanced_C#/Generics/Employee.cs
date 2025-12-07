using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class EmployeeEqualityComparerName : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x.Name==y.Name;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Name); 
            // HashCode --> Built-in Struct 
            // Combine --> function in it --> return the HashCode for This Parameter
        }
    }
    class EmployeeComparerSalary : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }
    internal class Employee :IComparable<Employee> , IEquatable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public int CompareTo(object? obj)
        {
            Employee employee = obj as Employee;
            return Id.CompareTo(employee.Id);
        }

        public int CompareTo(Employee? other)
        {
            return Id.CompareTo(other.Id);
        }

        public bool Equals(Employee? other)
        {
            if(other is null)
                return false;
             return Id.Equals(other.Id) && Name.Equals(other.Name) && Age.Equals(other.Age) && Salary.Equals(other.Salary);
          //  return this==other;
                
        }

        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} , Age : {Age} , Salary : {Salary}";
        }

    }
}
