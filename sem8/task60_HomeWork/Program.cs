// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
//  27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int sizeX = InputInt("Введите размерность X: ");
int sizaY = InputInt("Введите размерность Y: ");
int sizeZ = InputInt("Введите размерность Z: ");
int countNumbers = 59;

if (sizeX * sizaY * sizeZ > countNumbers)
{
    Console.WriteLine("Результат:");
    Console.WriteLine("Массив слишком БОЛЬШОЙ!");
    return;
}

int[,,] resultNumbers = Create3DArray(sizeX, sizaY, sizeZ);

Console.WriteLine("Результат:");

for (int i = 0; i < resultNumbers.GetLength(0); i++)
{
    for (int j = 0; j < resultNumbers.GetLength(1); j++)
    {
        for (int k = 0; k < resultNumbers.GetLength(2); k++)
        {
            Console.WriteLine($"{resultNumbers[i, j, k]} ({i}, {j}, {k})");
        }
    }
    Console.WriteLine();
}

int[,,] Create3DArray(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] val = new int[countNumbers];
    int Number = 10;
    for (int i = 0; i < val.Length; i++)
        val[i] = Number++;

    for (int i = 0; i < val.Length; i++)
    {
        int randomIndex = new Random().Next(0, val.Length);
        int temp = val[i];
        val[i] = val[randomIndex];
        val[randomIndex] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = val[valueIndex++];
            }
        }
    }
    return array;
}

int InputInt(string output)
{
    Console.WriteLine(output);
    return int.Parse(Console.ReadLine());
}

