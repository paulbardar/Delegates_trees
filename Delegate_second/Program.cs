namespace Delegate_second
{
    internal class Program
    {

        /*
            Завдання 3
            Створіть додатки для виконання арифметичних операцій. Підтримувані операції:
                Перевірка числа на парність;
                Перевірка числа на непарність;
                Перевірка чи є число простим;
                Перевірка чи є число числом Фібоначчі.
        */

        public delegate void Parity(int x);

        public static void ParityCheck(int x, Parity parity)
        {
            parity.Invoke(x);
        }
        public static void IsOdd(int x)
        {
            if (x % 2 != 0)
            {
                Console.WriteLine($"Number {x} is Odd");
            }
            else
            {
                Console.WriteLine($"Number {x} is Even");
            }
        }

        public static void IsEven(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine($"Number {x} is Even");
            }
            else
            {
                Console.WriteLine($"Number {x} is Odd");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int x = 4;
            ParityCheck(x, IsEven);

            int b = 11;
            ParityCheck(b, IsOdd);

            Console.WriteLine("-----------------------------------------");
        }
    }
    

}
