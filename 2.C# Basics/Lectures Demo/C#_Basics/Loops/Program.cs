namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Loop
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                Console.Write(i + " ");
            }
            #endregion

            #region Foreach Loop

            int[] arr = { 1, 2, 3, 4, 5, 2, 3, 5 };
            foreach (int i in arr)
                Console.Write(i + " ");

            #endregion

            #region While Loop

            int.TryParse(Console.ReadLine(), out int N);
            while (N > 0)
            {
                Console.Write(N-- + " ");
            }
            #endregion

            #region Do While Loop

            // Inter Positive Number 

            int.TryParse(Console.ReadLine(), out int num);
            do
            {
                int.TryParse(Console.ReadLine(), out num);
            }
            while (num <= 0);

            // To Make Sure That He Enters Number not any Thing
            bool ok = false;
            do
            {
                ok = int.TryParse(Console.ReadLine(), out num);
            }
            while (num % 2 == 1 || !ok); // if num is not even (odd) or num is not integer

            #endregion      
        }
       
    }
    
}
