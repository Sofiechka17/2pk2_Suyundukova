﻿namespace PZ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число от 1 до 31:"); // Выводим строку подсказывающую какую переменную необходимо ввести
            int day = Convert.ToInt32(Console.ReadLine()); // Считывает введенное пользователем число и преобразует его в тип int.


            int decade = (day - 1) / 10 + 1; // формула для расчета 

            switch (decade) // оператор switch используется для проверки значения переменной decade.
            {
                case 1: // проверяет, равно ли значение переменной decade 1.
                    Console.WriteLine("Число попадает в первую декаду месяца (1-10 день)"); // выводит сообщение о том, что число попадает в первую декаду.
                    break; // завершает выполнение оператора switch.

                case 2:
                    Console.WriteLine("Число попадает во вторую декаду месяца (11-20 день)"); // выводит сообщение о том, что число попадает во вторую декаду
                    break;
                case 3:
                    Console.WriteLine("Число попадает в третью декаду месяца (21-31 день)"); // выводит сообщение о том, что число попадает в третью декаду
                    break;
                default: // если значение переменной decade не соответствует ни одному из case, то выполняется код внутри default.
                    Console.WriteLine("Введено некорректное число"); // выводит сообщение о том, что введено некорректное число
                    break;
            }

            Console.ReadLine(); // ожидает нажатия клавиши Enter, чтобы программа не закрылась сразу после вывода результата.
        }
    }
}
 