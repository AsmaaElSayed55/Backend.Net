namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generics --> C# Feature in 2005
            // Before 2005

            // Swap
            int a=4, b=5;
            Console.WriteLine($" A : {a} " );
            Console.WriteLine($" B : {b}");

            Helper.Swap(a,b);

            Console.WriteLine($" A : {a} ");
            Console.WriteLine($" B : {b}");


            // double
            double x=5.33, y=8182.4;
            Console.WriteLine($" X : {x} ");
            Console.WriteLine($" Y : {y}");

            Point P1 = new Point(2, 4);
            Point P2=new Point(6, 5);

            Console.WriteLine($" P1.x : {P1.X} , P1.Y : {P1.X} ");
            Console.WriteLine($" P1.x : {P2.X} , P1.Y : {P2.Y} ");

            Helper.Swap(ref P1, ref P2);

            Console.WriteLine($" P1.x : {P1.X} , P1.Y : {P1.X} ");
            Console.WriteLine($" P1.x : {P2.X} , P1.Y : {P2.Y} ");
        }
    }
}
