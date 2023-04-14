// Напишите программу, которая принимает на вход цифру,  
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели: ");
int number = int.Parse(Console.ReadLine());

if (number >= 1 && number <= 5) 
{
    Console.WriteLine("Этот день не является выходным: " + number);
}
if (number >= 6)
{
    Console.WriteLine("Этот день является выходным: " + number);
}
