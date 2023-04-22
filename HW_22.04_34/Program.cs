/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве. */

int [] array = new int[10];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 999);
}

int count = 0;

Console.WriteLine("Массив случайных трехзначных чисел: ");

for (int i = 0; i < 10; i++)
{
    Console.Write(array[i] + " ");
    if (array[i] % 2 == 0)
        {
            count++; 
        }
}
Console.WriteLine();
Console.WriteLine("Количество четных чисел в массиве: " + count);