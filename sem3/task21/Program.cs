// Задача 21: Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,2

Console.Write("Введите координату x1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
// Math.Sqrt(число) => Math.Sqrt(25) = 5
//(x2 - x1) * (x2 - x1) => Math.Pow(x2 - x1, 2) => Math.Pow(число, степень)
// Math.Pow(5, 3) => 5*5*5  = 125
double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
// Math.Round(число, кол-во знаков)
// Math.Round(1.234, 2) 
Console.WriteLine($"Расстояние между строчками A:({x1}, {y1}) и B:({x2}, {y2}) равно: {Math.Round (d,1)}"); 