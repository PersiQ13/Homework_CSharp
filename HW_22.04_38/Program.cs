/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементом массива.  */

double[] array = { 1.2, 3.7, 5.3, 7.8, 9.6 };
double max = array[0];
double min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }

    if (array[i] > max)
    {
        max = array[i];
    }
}

Console.WriteLine($"Min: {min}");
Console.WriteLine($"Max: {max}");
Console.WriteLine($"Разница между max и min элементами массива: {max - min}");
