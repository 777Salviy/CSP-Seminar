// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size)
{
    int[] resultArray = new int[size];

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(99, 999 + 1);
    }
    return resultArray;
}

int IndicateEven(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] Array = GetArray(18);
Console.WriteLine($"Массив: [ {String.Join("; ", Array)} ]");

int EvenNumber = IndicateEven(Array);
Console.WriteLine($"Колличество четных чисел в массиве составляет: {EvenNumber}");
