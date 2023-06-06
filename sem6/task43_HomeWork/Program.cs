// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)


Console.WriteLine($"Введите координату k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координату b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координату k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координату b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());


double GetCrossPointX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double GetCrossPointY(double k1, double b1, double k2, double b2)
{
    double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
    return y;
}

double x = GetCrossPointX(k1, b1, k2, b2);
double y = GetCrossPointY(k1, b1, k2, b2);
Console.WriteLine($"Точка пересечения графиков y = k1 * x + b1 и y = k2 * x + b2 находиться в координатах ({Math.Round(x, 1)}; {Math.Round(y, 1)})");