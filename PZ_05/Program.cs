namespace PZ_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое положительное число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int i = 0;

            do
            {
                sum += i;
                i++;
            }
            while (i <= n);

            Console.WriteLine("Сумма всех целых чисел от 0 до {0} равна {1}", n, sum);
        }
    }
}