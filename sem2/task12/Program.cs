// Задача 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// int a = int.Parse(Console.ReadLine()); // Convet.ToInt32() = int.Parse()
// int b = int.Parse(Console.ReadLine()); // Convet.ToInt32() = int.Parse()
// if (b % a == 0)
// {
//     Console.WriteLine("Кратное");
// }
// else
// {
//     Console.WriteLine(b % a);
// }


Console.WriteLine("Введите первое число: ");
int FirstNumber = int.Parse(Console.ReadLine()); // Convet.ToInt32() = int.Parse()
Console.WriteLine("Введите второе число ");
int SecondNumber = int.Parse(Console.ReadLine()); // Convet.ToInt32() = int.Parse()

if (Math.Pow(FirstNumber, 2) == SecondNumber || Math.Pow(SecondNumber, 2) == FirstNumber) // && = и || = или
{
    if (Math.Pow(FirstNumber, 2) == SecondNumber)
    {
        Console.WriteLine("Второе число является квадратом первого");
    }
    else
    {
        Console.WriteLine("Первое число является квадратом второго");
    }

}
else
{
    Console.WriteLine("ни одно из чисел не является квадратом другого");
}