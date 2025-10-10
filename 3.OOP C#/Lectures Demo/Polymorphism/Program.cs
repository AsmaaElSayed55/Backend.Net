using Common;
using Polymorphism.Overloading;
using Polymorphism.Overriding;

namespace Polymorphism
{
    internal class Program
    {
        static int SumNumbers(int x,int y)
        {
            return x + y;
        }
        static double SumNumbers(double x, double y)
        {
            // Method Overloading
            return x + y;
        }
        static double SumNumbers(int x, double y)
        {
            // Method Overloading
            return x + y;
        }
        //=================================      
       
        static void Main(string[] args)
        {
            #region Notes


            #endregion

            #region Overloading [ Compile Time ]

            // 1. Constructor Overloading
            #region Constructor Overloading

            Car car1 = new Car(10);
            Console.WriteLine(car1);

            Car car2 = new Car(20, "BYD");
            Console.WriteLine(car2);

            Car car3 = new Car(30, "BMW", 250);
            Console.WriteLine(car3);

            #endregion

            // 2. Indexer Overloading
            #region 2. Indexer Overloading

            #endregion

            // 3. Method Overloading
            #region Method Overloading

            int a=10,b=20;
            double x = 234.477,y=7431.57;
            Console.WriteLine(SumNumbers(a,b));
            Console.WriteLine(SumNumbers(x,y));
            Console.WriteLine(SumNumbers(a,y));

            #endregion

            // 4. Operator Overloading
            #region Operator Overloading

            #region Binary Operators

            #region Complex Class
            Complex C1 = new Complex();
            C1.Real = 10;
            C1.Img = 5;
            Console.WriteLine($"C1 = {C1}");

            Complex C2 = new Complex();
            C2.Real = 6;
            C2.Img = 2;
            // C2 = null;
            Console.WriteLine($"C2 = {C2}");

            Complex C3 = default;

            C3 = C1 + C2; // Invalid Before Operator Overloading 
                          // Valid After Operator Overloading 

            Console.WriteLine($"C3 = {C3}");

            Complex C4 = default;
            C4 = C3 - C1;
            Console.WriteLine($"C4 = {C4}");

            #endregion

            #region Maths Class
            //Maths maths1 = new Maths() { A = 10, B = 20 };
            //Console.WriteLine($"Maths1 = {maths1} ");



            #endregion

            #endregion

            #region Unary Operators

            Complex C5=new Complex();
            C5.Real = 10;
            C5.Img = 5;
            Console.WriteLine($"C5 = {C5}");

            ++C5;
            Console.WriteLine($"C5 = {C5}");

            C5--;
            Console.WriteLine($"C5 = {C5}");

            #endregion

            #region Relational Operators
            Complex C6 = new Complex()
            {
                Real = 20,
                Img = 5,
            };
            Complex C7 = new Complex()
            {
                Real = 20,
                Img = 10,
            };
            if(C6>C7)
                Console.WriteLine("C6 is bigger than C7");
            if (C6 < C7)
                Console.WriteLine("C6 is less than C7");
            else Console.WriteLine("C6 is equal C7");
            #endregion

            #endregion

            // 5. Casting Operator Overloading
            #region Casting Operator Overloading

            #region Casting Operator Overloading [ explicit & implicit ]

            Complex C8 = new Complex()
            {
                //  Real = 10,  
                Img = 5,
            };
            int X = (int)C8;

            string str = C8;
            Console.WriteLine($"Str = {str}");

            #endregion

            #region Casting Operator Overloading [ User Defined Data Type ]

            User user1 = new User()
            {
                Id = 10,
                FullName = "Asmaa El Sayed",
                Email = "asmaaelsayed@gmail.com",
                Password = "P@ssword",
                SecurityStamp = Guid.NewGuid()
            };


            UserViewModel userViewModel = (UserViewModel)user1;
            // (UserViewModel) => Casting Operator
            // Manual Mapping [User => UserViewModel]
            // Model => ViewModel
            // ViewModel => Model

            Console.WriteLine(userViewModel);

            Console.WriteLine();

            #endregion 

            #endregion

            #endregion

            #region Overriding [ RunTime ]

            TypeX typeX = new TypeX(1);

            typeX.MyFun1(); // This Is MyFun1 From Base And I Am Base
            typeX.MyFun2(); // This Is MyFun2 From Base And TypeX : 1

            TypeY typeY = new TypeY(1,2);

            typeY.MyFun1(); // Static Polymorphism [Compile-Time] -> Calling Function Based On Object Type 

            typeY.MyFun2(); // Dynamic Polymorphism [Run-Time] -> Calling Function Based On Object Type 

            #endregion



        }
    }
}
