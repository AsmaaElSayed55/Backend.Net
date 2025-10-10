using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class TypeD :TypeA
    {   
        public TypeD() 
        {
            //A = 1; Not Valid [Private for TypeA]
            //B = 2; Not Valid [Internal For TypeA --> Not inherited for deferent namespace]
            C = 3; // Valid [public]

            //X = 10; // Not Valid [private protected For TypeA --> Not inherited for deferent namespace]
            Y = 20; // Valid [protected For TypeA --> inherited as private For TypeD]
            Z = 30; // valid [internal protected For TypeA --> inherited as private For TypeD]
        }  
    }
}
