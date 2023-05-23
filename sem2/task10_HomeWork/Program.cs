// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int Number = int.Parse(Console.ReadLine());

if (Number < 1000 && Number > 99)
{
    int a = Number / 10;
    int b = a % 10;
    Console.WriteLine("Вторая цифра в числе " + Number + " -> " + b);
}
else
{
    Console.WriteLine("Введенное число не трехзначное");
}
