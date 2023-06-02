﻿// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число А: ");

int limit = Convert.ToInt32(Console.ReadLine());

int sum = 0; // Изначально суммы нет
// for (точка входа; условие цикла; увел.счетчика)
for (int i = 1; i <= limit; i++)
{
    sum += i; // sum = sum + i
}

Console.WriteLine($"Сумма чисел от 1 до {limit} = {sum}");
