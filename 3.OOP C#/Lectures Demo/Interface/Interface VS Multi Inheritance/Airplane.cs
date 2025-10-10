using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Interface_VS_Multi_Inheritance
{
    internal class Airplane : Vehicle, IMoveOnGround, IMoveOnAir
    {

        // Implement Implicitly ->

        // Implement Explicitly ->

        // Methods That Implemented Explicitly Can nit be non Private
        void IMoveOnAir.Backward()
        {
            Console.WriteLine("Airplane Move Backward On Air");
        }

        void IMoveOnGround.Backward()
        {
            Console.WriteLine("Airplane Move Backward On Ground");
        }

        public void Forward()
        {
            Console.WriteLine("Airplane Move Forward Implement Implicitly.");
        }

        void IMoveOnAir.Left()
        {
            
        }

        void IMoveOnGround.Left()
        {
            
        }

        void IMoveOnAir.Right()
        {
            throw new NotImplementedException();
        }

        void IMoveOnGround.Right()
        {
            throw new NotImplementedException();
        }
    }
}
