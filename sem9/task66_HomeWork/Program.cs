// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int N = Convert.ToInt32(Console.ReadLine());

int SumOfNumbersfromMtoN(int m, int n)
{
    if (m > n) return 0;
    return m + SumOfNumbersfromMtoN(m + 1, n);
}

int result = SumOfNumbersfromMtoN(M, N);
Console.WriteLine(result);