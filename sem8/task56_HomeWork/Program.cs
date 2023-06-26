// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n]; // Таблица из m строк и n столбцов 
    for (int i = 0; i < matrix.GetLength(0); i++) // Цикл по строчкам , i < m
    {
        // i,j,m,k 
        for (int j = 0; j < matrix.GetLength(1); j++)// Цикл по стобцам , j < n
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

// Метод, который печатает массив 
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // строчки
    {
        for (int j = 0; j < array.GetLength(1); j++) // столбцы
        {
            Console.Write(array[i, j] + "\t"); // "\t" = Tab = 4 пробела между элементами
        }
        Console.WriteLine();
    }
}

int GetRowNumber(int[,] matrix)
{
    int rowWithMinSum = 0;
    int minSum = 0;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minSum = minSum + matrix[0, i]; // minSum = сумме элементов 0 строчки
    }

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j]; // сумма элементов текущей строчки, начиная от 1
        }
        if (sum < minSum)
        {
            minSum = sum; // Если сумма текущей строчки меньше предп-й мин. суммы, то мы
            // перезаписываем переменную
            rowWithMinSum = i;
        }
    }
    return rowWithMinSum;
}

int[,] matr = GetMatrix(5, 5, 0, 10); // Матрица 5 на 5, элемент - рандомное число от 0 до 10 вклю-то
PrintMatrix(matr);

Console.WriteLine($"Строчка с наименьшей суммой: {GetRowNumber(matr)}");