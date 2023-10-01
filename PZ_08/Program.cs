using System;

namespace PZ_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Генерация случайной длины второго измерения
            Random random = new Random();
            int[] lengths = new int[10];
            for (int i = 0; i < lengths.Length; i++)
            {
                lengths[i] = random.Next(10, 41);
            }

            // Создание ступенчатого массива строк
            string[][] stepArray = new string[10][];
            for (int i = 0; i < stepArray.Length; i++)
            {
                stepArray[i] = new string[lengths[i]];
                for (int j = 0; j < stepArray[i].Length; j++)
                {
                    stepArray[i][j] = random.Next(1,101).ToString(); // Пример заполнения значениями
                }
            }

            // Вывод сгенерированного массива
            Console.WriteLine("Сгенерированный массив:");
            for (int i = 0; i < stepArray.Length; i++)
            {
                for (int j = 0; j < stepArray[i].Length; j++)
                {
                    Console.Write(stepArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Подсчет общего количества символов в строках каждой строки массива
            int[] totalLengths = new int[stepArray.Length];
            for (int i = 0; i < stepArray.Length; i++)
            {
                int totalLength = 0;
                for (int j = 0; j < stepArray[i].Length; j++)
                {
                    totalLength += stepArray[i][j].Length;
                }
                totalLengths[i] = totalLength;
            }

            // Вывод массива с общим количеством символов
            Console.WriteLine("\nМассив с общим количеством символов в строках:");
            for (int i = 0; i < totalLengths.Length; i++)
            {
                Console.WriteLine(totalLengths[i]);
            }

            // Создание нового одномерного массива и запись последних элементов каждой строки
            string[] newArray = new string[stepArray.Length];
            for (int i = 0; i < stepArray.Length; i++)
            {
                newArray[i] = stepArray[i][stepArray[i].Length - 1];
            }

            // Вывод нового массива
            Console.WriteLine("\nМассив с последними элементами строк:");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }

            // Поиск максимальных элементов в каждой строке и запись их в новый массив
            string[] maxArray = new string[stepArray.Length];
            for (int i = 0; i < stepArray.Length; i++)
            {
                string max = stepArray[i][0];
                for (int j = 1; j < stepArray[i].Length; j++)
                {
                    if (string.Compare(stepArray[i][j], max) > 0)
                    {
                        max = stepArray[i][j];
                    }
                }
                maxArray[i] = max;
            }

            // Вывод массива с максимальными элементами
            Console.WriteLine("\nМассив с максимальными элементами строк:");
            for (int i = 0; i < maxArray.Length; i++)
            {
                Console.WriteLine(maxArray[i]);
            }

            // Замена первого элемента и максимального элемента в каждой строке
            for (int i = 0; i < stepArray.Length; i++)
            {
                string temp = stepArray[i][0];
                stepArray[i][0] = maxArray[i];
                maxArray[i] = temp;
            }
            // Вывод обновленного массива
            Console.WriteLine("\nОбновленный массив:");
            for (int i = 0; i < stepArray.Length; i++)
            {
                for (int j = 0; j < stepArray[i].Length; j++)
                {
                    Console.Write(stepArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            // Реверс каждой строки ступенчатого массива
            for (int i = 0; i < stepArray.Length; i++)
            {
                Array.Reverse(stepArray[i]);
            }

            // Вывод массива после реверса
            Console.WriteLine("\nМассив после реверса строк:");
            for (int i = 0; i < stepArray.Length; i++)
            {
                for (int j = 0; j < stepArray[i].Length; j++)
                {
                    Console.Write(stepArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}