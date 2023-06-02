// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int NumberOrder(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

int SumNumber(int N, int numOrder)
{
    int result = 0;
    for (int i = 0; i < numOrder; i++)
    {
        int digit = N % 10;
        result = result + digit;
        N = N / 10;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int numberPosition = NumberOrder(number);
// Console.WriteLine(numberPosition);

int SUM = SumNumber(number, numberPosition);
Console.WriteLine($"Сумма цифр числа {number} = {SUM}");

