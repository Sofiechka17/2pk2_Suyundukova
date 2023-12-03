using System.IO;

namespace PZ_14
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        // Открываем файл для чтения и записи
        string path = @"C:\work\products.txt";
        File.Delete(path);

        FileStream file = new FileStream(path, FileMode.OpenOrCreate);
        file.Close();

             Console.WriteLine("Напишите продукт и его стоимость: ");
            Console.WriteLine("Если вы написали весь список, напишите команду stop ");
             Console.Write("Продукт: ");
             string student = Console.ReadLine();
             while (student != "stop")
             {
                     // добавление в тексовый файл
                     File.AppendAllText(path, student + "\n");
                     Console.Write("Продукт: ");
                     student = Console.ReadLine();
             }

                Console.WriteLine("Содержимое файла: ");
                StreamReader reader = new StreamReader(path);
                Console.WriteLine(reader.ReadToEnd());
                reader.Close();

             string[] lines = File.ReadAllLines(path);
             decimal total = 0;
             for (int i = 0; i<lines.Length; i++)
             {
                 string line = lines[i].Trim();

                // Разделяем строку на название продукта и цену
                string[] parts = line.Split(' ');
                string productName = parts[0];
                decimal price = decimal.Parse(parts[1]);

                // Вычисляем сумму чека
                total += price;
             }
                using (var writer = new StreamWriter(path, true))
                {
                        writer.WriteLine($"Сумма чека: {total} р.");
                        Console.WriteLine("Сумма чека успешно дописана в файл.");
                }
        }
    }
}