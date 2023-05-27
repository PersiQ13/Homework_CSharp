/* Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии. 
N = 5; N = 8 */

int n = 8;
PrintNumbers(n);

static void PrintNumbers(int n)
{
    Console.Write(n + " ");

    if (n == 1) 
        return;

    PrintNumbers(n - 1);
}