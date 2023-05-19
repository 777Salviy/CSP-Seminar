
// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4-> 16
// - 3-> 9
// - 7-> 49

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32 (Console.ReadLine ());
int result = number * number;
double resultPartTwo = Math.Pow(number, 2); 

Console.WriteLine("число " + number + " в квадрате: " + result);
Console.WriteLine("число " + number + " в квадрате: " + resultPartTwo);
