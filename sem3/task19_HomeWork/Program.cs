// Задача 19.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number;

do
{
    Console.Write("Введите пятизначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number > 9999 && number < 100000)
    {
        int num1 = number / 10000;
        int num2 = number / 1000 % 10;
        int num4 = number / 10 % 10;
        int num5 = number % 10;

        if (num1 == num5 && num2 == num4)
        {
            Console.WriteLine("Число является полиндромом");
        }
        else
        {
            Console.WriteLine("Число НЕ является полиндромом");
        }
    }
    else
    {
        Console.Write("Неверное число. ");
    }
}
while (number <= 9999 || number >= 100000);



