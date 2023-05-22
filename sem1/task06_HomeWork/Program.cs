﻿
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4->да
// - 3->нет
// 7->нет

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 0)
{
    Console.WriteLine("Нельзя делить на ноль, хотя по общим правилам математики 0 относится к четным числам");
}
else
{
    if (number % 2 == 0)
    {
        Console.WriteLine("Число является четным");
    }
    else
    {
        Console.WriteLine("Число является нечетным");
    }
}
