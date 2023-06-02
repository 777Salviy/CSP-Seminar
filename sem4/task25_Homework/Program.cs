// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа: ");
int numberPower = Convert.ToInt32(Console.ReadLine());

int powerCount = 0;
int result = 1;
while (powerCount < numberPower)
{
    result = result * numberA;
    powerCount++;
}
Console.WriteLine($"Число {numberA} в степени {numberPower} равняется {result}");