namespace Standard_Delegates
{

    /*
     Створить набір методів:
    -	Метод для відображення поточного часу;
    -	Метод для відображення поточної дати;
    -	Метод для відображення поточного дня тижня;
    -	Метод для підрахунку площі трикутника;
    -	Метод для підрахунку площі прямокутника.
    Для реалізації проекта використовувати делегати Action, Predicate, Func

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Standart Delegates!");
            // Метод для відображення поточного часу;
            Action<string>? showTimeAction;
            showTimeAction = DisplayTime;
            showTimeAction("HH:mm:ss");

            // Метод для відображення поточної дати;
            Action<string> showDateAction = DisplayDate;
            showDateAction("dd.MM.yyyy");

            // Метод для відображення поточного дня тижня;
            Action<string>showDayAction = DisplayDayOfWeek;
            showDayAction("dddd");

            Console.WriteLine();
            // Метод для підрахунку площі трикутника;
            Func<double, double, double, double> getAreaFunc = CalculateTriangleAreaHeron;
            double result = getAreaFunc(5.0, 7.0, 4.0);
            Console.WriteLine($"Func (Heron’s Formula): Triangle with sides 5, 7, 4 equals {result}");

            Console.WriteLine();
            Func<double, double, double> getRectangleAreaFunc = CalculateRectangleArea;
            double rectArea = getRectangleAreaFunc(7.5, 3.125);
            Console.WriteLine($"Func (площа прямокутника): {rectArea}");
        }

        static void DisplayTime(string format)
        {
            Console.WriteLine($"Current Time: {DateTime.Now.ToString(format)}");
        }

        static void DisplayDate(string format)
        {
            Console.WriteLine($"Action (date): Current date - {DateTime.Now.ToString(format)}");
        }

        static void DisplayDayOfWeek(string format)
        {
            string day = DateTime.Now.ToString(format); 
            Console.WriteLine($"Action (week day): Today {day}");
        }

        static double CalculateTriangleAreaHeron(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double result = Math.Round(area, 2);
            return result;
        }

        static double CalculateRectangleArea(double width, double height)
        {
            double area = width * height;
            return Math.Round(area, 2);
        }
    }
}
