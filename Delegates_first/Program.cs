/*
 Завдання 2
Створіть додаток для виконання арифметичних операцій. Підтримувані операції:
    Додавання двох чисел;
    Віднімання двох чисел;
    Множення двох чисел.
Код програми обов'язково повинен використовувати механізм делегатів.
 */

namespace Delegates_first
{
    internal class Program
    {
        public delegate int MyDelegate(int a, int b);

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MyDelegate[] dg = new MyDelegate[]
            {
                Add,
                Subtract,
                Multiply
            };

            int x = 2;
            int y = 6;

            foreach (MyDelegate del in dg)
            {
            
                int result = del(x, y);
                Console.WriteLine($"{del.Method.Name}({x}, {y}) = {result}");
            }

            Console.WriteLine("=============================================");


            Console.WriteLine(dg[0](2, 6));
            Console.WriteLine(dg[1](2, 6));
            Console.WriteLine(dg[2](2, 6));

            

        }
    }
}

