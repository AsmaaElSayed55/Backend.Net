using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Partial
{
    public partial class Employee
    {
        public int Id { get; set; }


    }

    partial class Employee
    {
        public string Name { get; set; }

    }
}
