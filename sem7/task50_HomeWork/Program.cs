// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет

int[,] GetArray2D(int n, int m, int min, int max)
{
    int[,] array2D = new int[n, m];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array2D;
}

void PrintArray2D(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            Console.Write(arr2D[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine($"Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] Array2D = GetArray2D(rows, columns, 1, 20);
PrintArray2D(Array2D);

void FindElement(int[,] Arr2D, int rowPosition, int columnPosition)
{
    if (rowPosition <= Arr2D.GetLength(0) && columnPosition <= Arr2D.GetLength(1))
    {
        int result = Arr2D[rowPosition, columnPosition];
        Console.WriteLine($"Значение элемента под индексами {rowPosition} и {columnPosition} = {result}");
    }
    else
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
}

Console.WriteLine($"Введите индекс строки: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите индекс столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

FindElement(Array2D, row, column);
