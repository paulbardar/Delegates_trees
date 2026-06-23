namespace NumChecker
{

    /* Завдання 3 Створіть додатки через власний Делегат для виконання арифметичних операцій. 
     * Підтримувані операції: Перевірка числа на парність; Перевірка числа на непарність; 
     * Перевірка чи є число простим; Перевірка чи є число числом Фібоначчі. 
     */
    internal class Program
    {

        public delegate bool NumberCheckDelegate(int x);

        public static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        public static bool IsOdd(int n)
        {
            return n % 2 != 0;
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(n));
            for (int i = 3; i <= boundary; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static bool IsFibonacci(int n)
        {
            if (n < 0) return false;

            return IsPerfectSquare(5 * n * n + 4) || IsPerfectSquare(5 * n * n - 4);
        }

        private static bool IsPerfectSquare(int x)
        {
            if (x < 0) return false;
            int s = (int)Math.Sqrt(x);
            return s * s == x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            NumberCheckDelegate isEven = IsEven;
            NumberCheckDelegate isOdd = IsOdd;
            NumberCheckDelegate isPrime = IsPrime;
            NumberCheckDelegate isFibonacci = IsFibonacci;


            NumberCheckDelegate[] checkers = { isEven, isOdd, isPrime, isFibonacci };

            int testNumber = 5;
            Console.WriteLine($"Check for number {testNumber} ---\n");

            foreach (var checker in checkers)
            {
                string methodName = checker.Method.Name; 
                bool result = checker(testNumber);       

                Console.WriteLine($"MEthod: {methodName,-12} | Result: {result}");
            }
        }
    }
}
