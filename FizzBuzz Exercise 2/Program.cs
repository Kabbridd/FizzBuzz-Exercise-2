namespace FizzBuzz_Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 1;
            
            for ( i = 1; i <= 15; i++) 
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBUzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else 
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
