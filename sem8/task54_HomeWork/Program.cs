// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] BackOrderMatrix(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < array2D.GetLength(1) - j - 1; k++)
            {
                if (array2D[i, k] < array2D[i, k + 1])
                {
                    // Обмен элементов местами
                    int temp = array2D[i, k];
                    array2D[i, k] = array2D[i, k + 1];
                    array2D[i, k + 1] = temp;
                }
            }
        }
    }
    return array2D;
}

int[,] resMatrix = GetMatrix(rows, columns, 1, 10);
// rows=3, columns=4 => таблица из 3 строк и 4 столбцов, элемент: число от 0 до 10 включительно
PrintMatrix(resMatrix); // PrintMatrix(матрица)
Console.WriteLine();

int[,] newMatrix = BackOrderMatrix(resMatrix);
PrintMatrix(newMatrix);