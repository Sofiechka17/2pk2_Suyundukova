namespace PZ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную - а"); // Выводим строку подсказывающую какую переменную необходимо ввести
            double a = Convert.ToDouble(Console.ReadLine()); // Ввод любых значений в консоли, конвертируем строку в тип Double
            Console.WriteLine("Введите переменную - b"); // Выводим строку подсказывающую какую переменную необходимо ввести
            double b = Convert.ToDouble(Console.ReadLine()); // Ввод любых значений в консоли, конвертируем строку в тип Double
            Console.WriteLine("Введите переменную - c"); // Выводим строку подсказывающую какую переменную необходимо ввести
            double c = Convert.ToDouble(Console.ReadLine()); // Ввод любых значений в консоли, конвертируем строку в тип Double

            double result; // Переменная реузльтата

            result = (1 / 9 + Math.Sqrt((Math.Pow(a, 2) + b) / 0.4 * a) - Math.Pow(10, 4) * Math.Exp(a * c) + Math.Cos(Math.Sqrt(Math.Pow(a, 2) + b)) + Math.Sin(3) / 5 * (Math.Pow(a, 2) + b)); // Математическое уравение


            Console.WriteLine(result); // Вывод результата
            Console.ReadLine(); // Необходимо чтобы окно консоли не закрывалось после запуска 

        }
    }
}