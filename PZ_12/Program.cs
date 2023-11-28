using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите ваш вес (в килограммах):");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите ваш рост (в метрах):");
        double height = double.Parse(Console.ReadLine());

        double imt = CalculateIMT(weight, height);
        string explanation = GetExplanation(imt);

        Console.WriteLine($"Ваш ИМТ: {imt}");
        Console.WriteLine(explanation);

        Console.ReadLine();
    }

    static double CalculateIMT(double weight, double height)
    {
        return Math.Round(weight / (height * height), 2);
    }

    static string GetExplanation(double imt)
    {
        if (imt < 16)
        {
            return "Дефицит массы тела (истощение)";
        }
        else if (imt >= 16 && imt < 18.5)
        {
            return "Недостаточный вес (дефицит)";
        }
        else if (imt >= 18.5 && imt < 24.9)
        {
            return "Нормальный вес";
        }
        else if (imt >= 25 && imt < 29.9)
        {
            return "Избыточный вес";
        }
        else if (imt >= 30 && imt < 34.9)
        {
            return "Ожирение 1 степени";
        }
        else if (imt >= 35 && imt < 39.9)
        {
            return "Ожирение 2 степени";
        }
        else
            return "Ожирение 3 степени";
    }
}