// Задача 39: Напишите программу, 
// которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }

    return array;
}

int[] resultArray = GetArray(10, 0, 10); // size = 10, min = 0, max = 10
Console.WriteLine($"Исходный массив: [{String.Join("; ", resultArray)}]");
