namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите целое число:"); // Выводим строку подсказывающую какую переменную необходимо ввести
            double b = int.Parse(Console.ReadLine()); // Ввод любых значений в консоли, конвертируем строку в тип Double

            Console.WriteLine("Введите действительное число:");
            double d = double.Parse(Console.ReadLine());

            double p, q, r;
            
            
            // Вычисление значения переменной p в зависимости от значения b

            if (b > 2) // Условие (если b > 2),то выполняется код внутри фигурных скобок.
            {
                p = b * Math.Cos(d) / Math.Sqrt(Math.Pow(d, 2) - b); // матем.уравнение
            }
            else // иначе (b <= 2) - выполняется другая операция
            {
                p = 2 - Math.Exp(Math.Abs(b)) * Math.Sin(b); // матем.уравнение
            }

            // Вычисление значения переменной q в зависимости от значения p

            if (p <= 0) // условие
            {
                q = Math.Pow(Math.Sin(b * p), 2) - Math.Pow(Math.Cos(b * p), 2); // матем.уравнение
            }
            else // иначе
            {
                q = Math.Pow(Math.Sin(b * p), 2) - 1 / Math.Pow(Math.Cos(b * p), 2); // матем.уравнение
            }

            r = 23 * b + 1.2 * p * Math.Pow(q, 2) + d / 2; // Вычисление значения переменной r

            // Вывод значений переменных p, q и r на экран

            Console.WriteLine("Значение p: " + p);
            Console.WriteLine("Значение q: " + q);
            Console.WriteLine("Значение r: " + r);

            Console.ReadLine(); // Необходимо чтобы окно консоли не закрывалось после запуска 
        }
    }
}

        