// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]

void GetArray(int[] newRow)
{
    int lenth = newRow.Length;
    int index = 0;
    while (index < lenth)
    {
        newRow[index] = new Random().Next(10);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(collection[position]);
        position += 1;
    }
}

int[] array = new int[8];
GetArray(array);
PrintArray(array);
