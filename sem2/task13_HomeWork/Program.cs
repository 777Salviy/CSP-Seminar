// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число: ");
// int Number = int.Parse(Console.ReadLine());

// if (Number > 99)
// {
//     while ()
//     {

//     }
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

int Prompt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank (int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidateNumber (int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

int number = Prompt("Введите число > ");
if (ValidateNumber (number))
{
    Console.WriteLine(GetThirdRank(number));
}



// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = Convert.ToInt32(Math.Log10(num));
// Console.WriteLine($"Разрядность числа - {i}");
// int stepen = i;
// int num1 = Convert.ToInt32(Math.Pow(10, stepen));
// int num2 = num / num1;
// int num3 = Convert.ToInt32(Math.Pow(10, stepen - 1));
// int num4 = num % num3;
// Console.WriteLine($"Полученное чисо - {num2}{num4}");
