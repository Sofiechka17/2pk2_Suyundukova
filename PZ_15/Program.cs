using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Ввод полного пути к каталогу от пользователя
        Console.Write("Введите полный путь к каталогу: ");
        string directoryPath = Console.ReadLine();

        // Проверка существования каталога
        if (!Directory.Exists(directoryPath))
        {
            Console.WriteLine("Каталог не существует.");
            return;
        }

        try
        {
            // Получение списка всех файлов в каталоге
            string[] files = Directory.GetFiles(directoryPath);

            // Вывод списка файлов
            Console.WriteLine("Список файлов в каталоге:");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            // Удаление текстовых файлов
            foreach (string file in files)
            {
                // Проверка расширения файла, чтобы удалить только текстовые файлы
                if (Path.GetExtension(file).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    File.Delete(file);
                    Console.WriteLine($"Файл {file} удален.");
                }
            }

            // Обновленный список файлов после удаления
            string[] updatedFiles = Directory.GetFiles(directoryPath);

            // Вывод обновленного списка файлов
            Console.WriteLine("Обновленный список файлов в каталоге после удаления:");
            foreach (string file in updatedFiles)
            {
                Console.WriteLine(file);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}