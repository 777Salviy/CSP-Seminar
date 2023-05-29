// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Первый вариант Do-While

// int denNedeli;
// do
// {
//     Console.WriteLine("Введите номер дня недели: ");
//     denNedeli = Convert.ToInt32(Console.ReadLine());

//     if (denNedeli == 1)
//     {
//         Console.WriteLine("Понедельник");
//     }
//     else if (denNedeli == 2)
//     {
//         Console.WriteLine("Вторник");
//     }
//     else if (denNedeli == 3)
//     {
//         Console.WriteLine("Среда");
//     }
//     else if (denNedeli == 4)
//     {
//         Console.WriteLine("Четверг");
//     }
//     else if (denNedeli == 5)
//     {
//         Console.WriteLine("Пятница");
//     }
//     else if (denNedeli == 6)
//     {
//         Console.WriteLine("Суббота - выходной!");
//     }
//     else if (denNedeli == 7)
//     {
//         Console.WriteLine("Воскресенье - выходной!");
//     }
//     else
//     {
//         Console.WriteLine("Такого дня недели нет, введите номер от 1 до 7");
//     }
// }
// while (denNedeli < 1 || denNedeli > 7);

// 2. Второй вариант - метод

void DayOfTheWeekAndWeekend()
{
    Console.WriteLine("Введите номер дня недели: ");
    int denNedeli = Convert.ToInt32(Console.ReadLine());

    if (denNedeli == 1)
    {
        Console.WriteLine("Понедельник");
    }
    else if (denNedeli == 2)
    {
        Console.WriteLine("Вторник");
    }
    else if (denNedeli == 3)
    {
        Console.WriteLine("Среда");
    }
    else if (denNedeli == 4)
    {
        Console.WriteLine("Четверг");
    }
    else if (denNedeli == 5)
    {
        Console.WriteLine("Пятница");
    }
    else if (denNedeli == 6)
    {
        Console.WriteLine("Суббота - выходной!");
    }
    else if (denNedeli == 7)
    {
        Console.WriteLine("Воскресенье - выходной!");
    }
    else
    {
        Console.WriteLine("Такого дня недели нет, введите номер от 1 до 7");
        DayOfTheWeekAndWeekend();
    }
}
DayOfTheWeekAndWeekend();