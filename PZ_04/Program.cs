namespace PZ_04
{
    internal class Program
    {
        // Задание 1
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1:");
            for (int i = 20; i <= 80; i += 3)
            {
                Console.WriteLine(i);
            }

            // Задание 2
            Console.WriteLine("Задание 2:");
            char startChar = 'з';

            for (int i = 0; i < 6; i++)
            {
                Console.Write(startChar);
                startChar++;
            }
            Console.WriteLine();

            // Задание 3
            Console.WriteLine("Задание 3:");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write('#');
                }
                    Console.WriteLine();
            }

            // Задание 4
            Console.WriteLine("Задание 4:");
            int count = 0;
            for (int i = -200; i <= 200; i++)
            {
                if (i % 19 == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }
            }
                Console.WriteLine("\nКоличество кратных чисел: " + count);


            // Задание 5
            Console.WriteLine("Задание 5:");
            int a = 0;
            int b = 99;

            while (Math.Abs(a - b) >= 21)
            {
                Console.WriteLine($"i = {a}, j = {b}");
                a++;
                b--;
            }

            Console.WriteLine($"Final values: i = {a}, j = {b}");


        }

    }   
}




