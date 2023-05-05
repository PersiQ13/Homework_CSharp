// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int m = 3;
int n = 4;

double[,] arr = new double[m, n];

Random rnd = new Random();

for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rnd.NextDouble() * 10;
            Console.Write("{0:F2} ", arr[i, j]);
        }
        Console.WriteLine();
    }