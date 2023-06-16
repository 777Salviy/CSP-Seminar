// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Введите число N: ");

int N = Convert.ToInt32(Console.ReadLine());
/// <summary>
/// Печать чисел от 1 до N
/// </summary>
/// <param name="start"> левая граница (1)</param>
/// <param name="end"> правая граница (N)</param>
/// <returns>строчку с числами от 1 до N</returns>
string GetStringOfNumbers(int start, int end)
{
    // Базовый случай - выход 
    if (start == end) return start.ToString(); // Вернул последнее число N в формате строчки

    // Рекурсивный случай 
    return start + ", " + GetStringOfNumbers(start + 1, end);
}
Console.WriteLine($" '{GetStringOfNumbers(1, N)}' "); // start = 1, end = N
