using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeB : TypeA
    {
        
        public TypeB()
        {
            //A = 1; // Not Inherited  --> Private
            B = 2; // Inherited --> Internal 
            C = 3; // Inherited --> Public 

            X = 10; // Inherited private protected => private
            Y = 20; // Inherited protected => private
            Z = 30; // Inherited internal protected => internal
        }
        public void Print()
        {
            TypeA typeA = new TypeA();
            // typeA.A = 1; // Invalid [private] within its class only
            typeA.B = 2; // Valid [internal] within class and project only
            typeA.C = 3; // Valid [public] within class , project and outside project only

            //  typeA.X = 10; // Invalid [private protected] --> without inheritance --> it become private within class only
            //  typeA.Y = 20; // Invalid [protected] without inheritance --> it become without access modifier --> it will take by default private within class only
            typeA.Z = 30; // Valid [internal] without inheritance --> it become without access modifier --> it will take by internal within class and project only


        }
    }
}
