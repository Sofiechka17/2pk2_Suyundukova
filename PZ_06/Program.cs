namespace PZ_06vostanovlen
{
    internal class Program
    {
        static void Main(string[] args)
        {

                int[] array1 = new int[10];
                int[] array2;
                Random random = new Random();

                // Заполнение первого массива случайными числами
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = random.Next(0, 101);
                }

                // Подсчет количества четных элементов в первом массиве
                int count = 0;
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] % 2 == 0)
                    {
                        count++;
                    }
                }

                // Создание второго массива и заполнение его индексами четных элементов первого массива
                array2 = new int[count];
                int index = 0;
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] % 2 == 0)
                    {
                        array2[index] = i;
                        index++;
                    }
                }

                // Вывод значений второго массива на экран
                Console.WriteLine("Индексы четных элементов первого массива:");
                for (int i = 0; i < array2.Length; i++)
                {
                    Console.WriteLine(array2[i]);
                }

                Console.ReadLine();
            
        }
    }
}
    
