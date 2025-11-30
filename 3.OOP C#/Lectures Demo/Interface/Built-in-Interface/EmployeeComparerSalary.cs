using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Built_in_Interface
{
    internal class EmployeeComparerSalary : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y;
            if (X.Salary > Y.Salary) return 4;
            else if(X.Salary<Y.Salary) return -4;
            return 0;
        }
    }

    internal class EmployeeComparerNameLength : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y;
            if (X.Name.Length > Y.Name.Length) return 4;
            else if (X.Name.Length < Y.Name.Length) return -4;
            return 0;
        }
    }
}
