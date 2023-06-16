// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillMatrix(int n, int m, int min, int max)
{
    int[,] matrix = new int[n, m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix2D)
{
    for (int i = 0; i < matrix2D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2D.GetLength(1); j++)
        {
            Console.Write(matrix2D[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newMatrix = FillMatrix(rows, columns, 1, 20);
PrintMatrix(newMatrix);

void ColumnSum(int[,] madeMatrix)
{
    int rows = madeMatrix.GetLength(0);
    int cols = madeMatrix.GetLength(1);

    double[] columnSums = new double[cols]; // Массив для хранения суммы элементов в каждом столбце

    // Вычисление суммы элементов в каждом столбце
    for (int j = 0; j < cols; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            columnSums[j] += madeMatrix[i, j];
        }
    }

    // Вычисление среднего арифметического для каждого столбца
    double[] columnAverages = new double[cols];
    for (int j = 0; j < cols; j++)
    {
        columnAverages[j] = columnSums[j] / rows;
    }

    // Вывод среднего арифметического для каждого столбца
    for (int j = 0; j < cols; j++)
    {
        Console.Write(Math.Round (columnAverages[j], 2));
        if (j < cols - 1)
        {
            Console.Write(";\t");
        }
    }
}

ColumnSum(newMatrix);