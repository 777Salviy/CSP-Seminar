// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//Первый вариант

// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = Convert.ToInt32(Math.Log10(num));
// Console.WriteLine($"Разрядность числа - {i}");
// int stepen = i;
// int num1 = Convert.ToInt32(Math.Pow(10, stepen));
// Console.WriteLine($"num1 = {num1}");
// int num2 = num / num1;
// Console.WriteLine($"num2 = {num2}");
// int num3 = Convert.ToInt32(Math.Pow(10, stepen - 1));
// Console.WriteLine($"num3 = {num3}");
// int num4 = num % num3;
// Console.WriteLine($"num4 = {num4}");
// Console.WriteLine($"Полученное чисо - {num2}{num4}");

// Второй вариант

// Console.WriteLine("Введите число: ");
// int Number = int.Parse(Console.ReadLine());

// if (Number > 99)
// {
//     // int stepen = Convert.ToInt32 (Math.Log10 (Number));
//     int ThreeDigitOrderNumber = Number / 10;
//     int ThirdDigitOfNumber = ThreeDigitOrderNumber % 10;
//     Console.WriteLine("Третья цифра = " + ThirdDigitOfNumber);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

// Идеальное решение от Geekbrains

// int Prompt (string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int GetThirdRank (int number)
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     return number % 10;

// }

// bool ValidateNumber (int number)
// {
//     if (number < 100)
//     {
//         Console.WriteLine("Третьей цифры нет");
//         return false;
//     }
//     return true;
// }

// int number = Prompt("Введите число > ");
// if (ValidateNumber (number))
// {
//     Console.WriteLine(GetThirdRank(number));
// }


int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int MakeArray(int a, int b)
{
    int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет, держи: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
    return result;
}



// var stringNumber = "0003"; // var - ключевое слово, определяет тип данных 
// int number; // Если строчка состоит только из чисел,
// // то в переменную попадает наше число 
// // TryParse (строчка, out переменная) -- out переменная - сохраняем число 

// bool isNumber = int.TryParse(stringNumber, out number);
// // isNumber = true, то строка состоит только из чисел ("2"), number = числу из строчки
// // false - присутствуют в строке еще и символы, number = 0
// if (isNumber && stringNumber.Length >= 3) // isNumber == true
// {
//     Console.WriteLine("Перевод произошел успешно, в строчке есть ТОЛЬКО цифры");
//     Console.WriteLine(number);
//     Console.WriteLine("Третья цифра числа: " + stringNumber[2]);
// }
// else // isNumber == false
// {
//     Console.WriteLine("Ошибка! В строчке присутсвуют и другие символы");
//     Console.WriteLine(number);
// }