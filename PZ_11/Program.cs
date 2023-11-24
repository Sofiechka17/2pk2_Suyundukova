
namespace PZ_11
{
    internal class Program
    {
        static void Minmax(ref double X, ref double Y)
        {
            if (X > Y)
            {
                double temp = X;
                X = Y;
                Y = temp;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите четыре числа: ");
            Console.WriteLine("Введите A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите C: ");
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите D: ");
            double D = Convert.ToDouble(Console.ReadLine());

            Minmax(ref A, ref B);
            Minmax(ref C, ref D);
            Minmax(ref A, ref C);
            Minmax(ref B, ref D);

            Console.WriteLine("Минимальное число: " + A);
            Console.WriteLine("Максимальное число: " + D);
        }
    }
}