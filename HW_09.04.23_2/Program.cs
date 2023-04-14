// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number >= 100 && number <= 999) 
{
    int third = (number / 1) % 10;
    Console.WriteLine("третья цифра: " + third);
}
if (number <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}

if (number >= 1000 && number <= 99999) 
{
    int third = (number / 100) % 10;
    Console.WriteLine("третья цифра: " + third);
}
