using System;
class Program
{
    static void Main(string[] args)
    {
        {
            Console.WriteLine("Задание 1: ");
            Console.WriteLine("Введите номер члена прогрессии:"); // Задание1
            int n = int.Parse(Console.ReadLine());

            double a1 = -30;
            double d = 0.4;

            double result = Calculate(n, a1, d);
            Console.WriteLine($"n-ый член прогрессии: {result}");
            Console.ReadLine();
        }
        {
            Console.WriteLine("Задание 2: ");
            Console.WriteLine("Введите номер члена прогрессии:");// Задание 2
            int n = int.Parse(Console.ReadLine());

            double b1 = 7;
            double q = 5;

            double result = Calcul(n, b1, q);
            Console.WriteLine($"n-ый член прогрессии: {result}");
            Console.ReadLine();
        }
        {
            Console.WriteLine("Задание 3: ");// Задание 3
            Console.WriteLine("Введите два целых числа А и В:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                PrintNumbersAscending(a, b);
            }
            else
            {
                PrintNumbersDescending(a, b);
            }

            Console.ReadLine();
        }
        {
            Console.WriteLine("Задание 4: ");
            string[] strings = { "abcba", "hello", "level", "ananas", "world" };// Задание 4

            foreach (string s in strings)
            {
                bool isPalindrome = Palindrome(s);
                Console.WriteLine($"{s}: {isPalindrome}");
            }

            Console.ReadLine();
        }
    }

    static double Calculate(int n, double a1, double d)// Задание 1
    {
        if (n == 1)
        {
            return a1;
        }
        else
        {
            return Calculate(n - 1, a1, d) + d;
        }
    }
    static double Calcul(int n, double b1, double q) // Задание 2
    {
        if (n == 1)
        {
            return b1;
        }
        else
        {
            return Calcul(n - 1, b1, q) * q;
        }
    }
    static void PrintNumbersAscending(int a, int b)// Задание 3
    {
        if (a <= b)
        {
            Console.WriteLine(a);
            PrintNumbersAscending(a + 1, b);
        }
    }

    static void PrintNumbersDescending(int a, int b)
    {
        if (a >= b)
        {
            Console.WriteLine(a);
            PrintNumbersDescending(a - 1, b);
        }
    }
    static bool Palindrome(string s)// Задание 4
    {
        if (s.Length <= 1)
        {
            return true;
        }
        else
        {
            if (s[0] == s[s.Length - 1])
            {
                return Palindrome(s.Substring(1, s.Length - 2));
            }
            else
            {
                return false;
            }
        }
    }
}