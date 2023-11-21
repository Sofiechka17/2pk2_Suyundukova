using System;
using System.Text.RegularExpressions;

namespace PZ_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            int sum = 0; 
            int count = 0; 
            int i = 0;

            while (i < text.Length)
            {
                string number = ""; // текущее число

                // проверяем, является ли символ цифрой 
                while (i < text.Length && (Char.IsDigit(text[i])))
                {
                    number += text[i];
                    i++;
                }

                if (!String.IsNullOrEmpty(number))
                {
                    sum += int.Parse(number);
                    count++;
                }

                i++;
            }

            double average = (double)sum / count;

            Console.WriteLine($"Среднее значение чисел: {average}");
        }
    }
}