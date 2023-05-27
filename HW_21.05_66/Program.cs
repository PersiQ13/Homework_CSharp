/* Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N */

static int Sum(int m, int n) 
{
    if (m == n) 
    { 
        return m;
    } else 
    {
        return m + Sum(m + 1, n); 
    }
}
    
int m = 1; 
int n = 10;
int sum = Sum(m, n);
Console.WriteLine("Сумма натуральных элементов в промежутке от {0} до {1} равна {2}.", m, n, sum);
