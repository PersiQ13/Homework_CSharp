/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет */

int[,] array = new int[,]
    {
        { 1, 4, 7, 2 },
        { 5, 9, 2, 3 },
        { 8, 4, 2, 4 }
    };

Console.Write("Введите номер строки: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите номер столбца: ");
int col = int.Parse(Console.ReadLine()!);

    if(row >= 0 && row < array.GetLength(0) && col >= 0 && col < array.GetLength(1))
    {
        int value = array[row, col];
        Console.WriteLine($"Значение элемента: {value}");
    }
    else
    {
        Console.WriteLine("Такого элемента в массиве нет.");
    }

