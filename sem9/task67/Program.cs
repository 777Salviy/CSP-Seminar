// Задача 67: Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int N = Convert.ToInt32(Console.ReadLine());

int GetDigitsSum(int number)
{
    if (number == 0) return 0;

    return number % 10 + GetDigitsSum(number / 10);
}

Console.WriteLine($"Сумма цифр в числе: {N} = {GetDigitsSum(N)}");