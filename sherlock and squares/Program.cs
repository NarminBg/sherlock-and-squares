namespace sherlock_and_squares
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
            {
                if((int)Math.Sqrt(i)==Math.Sqrt(i));
                {
                    count++;
                }
                
            }
            Console.WriteLine(count);




        }

    }
}