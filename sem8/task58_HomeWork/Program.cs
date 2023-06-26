// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк для первой матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество cтолбцов для первой матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк для второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество cтолбцов для второй матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
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

int[,] GetProductMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    // строчки = кол-во строк из первой матрицы(i), столбцы = кол-во столбцов из второй матрицы(j)
    for (int i = 0; i < firstMatrix.GetLength(0); i++) // строчки первой матрицы
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++) // столбцы второй матрицы
        {
            for (int k = 0; k < firstMatrix.GetLength(1); k++) // столбцы первой матрицы
            {
                resMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                // resMatrix = resMatrix + firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return resMatrix;

}

int[,] resMatrix = GetMatrix(rows, columns, 1, 10);
PrintMatrix(resMatrix);
Console.WriteLine();

int[,] resMatrix2 = GetMatrix(rows2, columns2, 1, 10);
PrintMatrix(resMatrix2);
Console.WriteLine();

int[,] MultipliedMatrix = GetProductMatrix(resMatrix, resMatrix2);
PrintMatrix(MultipliedMatrix);