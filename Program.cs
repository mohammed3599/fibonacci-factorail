namespace Function
{
    internal class Program
    {
        static int calFibonacci(int n)
        {
            int secondLastTerm = 0;
            int lastTerm = 1;
            int nextTerm = 0;

            for (int i = 2; i <= n; i++)
            {
                nextTerm = lastTerm + secondLastTerm;
                secondLastTerm = lastTerm;
                lastTerm = nextTerm;
            }
            return nextTerm;
        }

        static int calFactorial(int n)
        {
            if (n == 0)  
                return 1;
            else
                return n * calFactorial(n - 1);  
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number  to calculate its factorial: ");
            int f = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"The {f}! is: {calFactorial(f)}");
            Console.WriteLine();

            Console.WriteLine("Please Enter a number  to calculate its Fibonacci: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"The fibonacci of {a} is: {calFibonacci(a)}");
        }
    }
}