/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

int n = 5; 
int m = 7; 
int[,] array = new int[n, m];

Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = rnd.Next(10, 100);
        }
    }

Console.WriteLine("Текущий массив:");

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0} ", array[i, j]);
        }
        Console.WriteLine();
    }

int minSum = int.MaxValue;
int minSumRowIndex = -1;

    for (int i = 0; i < array.GetLength(0); i++) 
    {
        int sum = 0;

            for (int j = 0; j < array.GetLength(1); j++) 
            {
                sum += array[i, j];
            }

            if (sum < minSum) 
            {
                minSum = sum;
                minSumRowIndex = i;
            }
    }

Console.WriteLine($"Минимальная сумма элементов в строке {minSumRowIndex}: {minSum}");