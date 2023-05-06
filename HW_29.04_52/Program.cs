/* Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце. */

Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов в массиве: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = new int[rows, cols];
Random rnd = new Random();        
        
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < cols; j++) 
        {
            array[i,j] = rnd.Next(1, 30);
        }
    }

Console.WriteLine("Исходный массив:");
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < cols; j++) 
        {
            Console.Write("{0} ", array[i,j]);
        }
            Console.WriteLine();
    }

double[] num = new double [cols];

    for (int j = 0; j < cols; j++)
    {
        double sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += array[i, j];
            }
            num[j] = sum / rows;
            Console.WriteLine("Cреднее арифметическое элементов в столбце {0} = {1}", j, num[j]);
    }
