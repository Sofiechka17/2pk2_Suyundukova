namespace PZ_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк матрицы: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов матрицы: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            Console.WriteLine("Введите элементы матрицы:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Элемент [{0},{1}]: ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Исходная матрица:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Сортировка столбцов по убыванию значений элементов в первой строке
            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows - 1; i++)
                {
                    for (int k = i + 1; k < rows; k++)
                    {
                        if (matrix[i, j] < matrix[k, j])
                        {
                            int temp = matrix[i, j];
                            matrix[i, j] = matrix[k, j];
                            matrix[k, j] = temp;
                        }
                    }
                }
            }

            Console.WriteLine("Матрица после сортировки столбцов:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}