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

        static int calSumDigit(int num)
        {
            if (num < 10)  
                return num;

            int lastDigit = num % 10;  
            int digits = num / 10;  

            return lastDigit + calSumDigit(digits);  
        }

       
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number to calculate its factorial: ");
            int f = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"The {f}! is: {calFactorial(f)}");
            Console.WriteLine();

            Console.WriteLine("Please Enter a number  to calculate its Fibonacci: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"The fibonacci of {a} is: {calFibonacci(a)}");
            Console.WriteLine();

            Console.WriteLine("Please Enter a number to calculate its digits: ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum digits of {s} is: {calSumDigit(s)}");
        }
    }
}