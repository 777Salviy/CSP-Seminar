// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 0;

// while (num != 0)
// {
//     num /= 10;
//     i++;

// }
// Console.WriteLine("количество цифр в числе " + i);

// Второй вариант

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;// Количеств цифр в числе

// while (number != 0)
// {
//     count++;
//     number /= 10; // number = number / 10
// }

// Console.WriteLine($"количество цифр в числе:  {count} ");

//Третий вариант

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 0; // количество цифр в числе
for (count = 0; number > 0; count++)
{
    number = number / 10;
}
Console.WriteLine($"Число состоит из {count} цифр");

