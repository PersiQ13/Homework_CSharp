// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
int second = 0;

if (number > 99 && number < 1000)
{
    second = (number / 10) % 10;
    Console.WriteLine("Вторая цифра: " + second);
}
else
{
    Console.WriteLine("Введены некорректные данные");
}
