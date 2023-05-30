// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int size = 8;
int[] array = new int[size];
for (int i = 0; i < size;i++)
{
    array[i] = new Random().Next(5);
}
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");