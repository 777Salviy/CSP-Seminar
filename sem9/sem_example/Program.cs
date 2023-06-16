// Рекурсия. факториал.

int Factorial(int value)
{
    // Базовый случай - случай выхода из рекурсии, бесконечный вызов
    if (value == 1) return 1;
    // Рекурсивный случай - задание рекурсии
    return value * Factorial(value - 1);
}
int N = 4;
Console.WriteLine($"Факториал от числа {N} = {Factorial(N)}");
