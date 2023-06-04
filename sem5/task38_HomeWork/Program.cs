// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// 1 вариант. Метод создания массива вещественных 
// чисел в диапазонах типа (0,0 - 1,0; 0,0 - 10; 0,0 - 100,00 и т.д.)

// double[] CreateArray(int lenghts)
// {
//     double[] NewArray = new double[lenghts];
//     for (int i = 0; i < NewArray.Length; i++)
//     {
//         NewArray[i] = new Random().NextDouble() * 100;
//         NewArray[i] = Math.Round(NewArray[i], 2);
//     }
//     return NewArray;
// }

// double[] Array = CreateArray(10);
// Console.WriteLine($"Массив: [ {String.Join("; ", Array)} ]");

// 2-ой вариант. Метод создания массива вещественных 
// чисел с возможностью точно устанавливать границы диапазона 

double[] CreateArray2(int size)
{
    double[] NewArray2 = new double[size];
    Random random = new Random();
    double LowerLimit = 0.01; // нижняя граница массива
    double UpperLimit = 99.99; //верхняя граница массива
    for (int i = 0; i < NewArray2.Length; i++)
    {
        NewArray2[i] = LowerLimit + (random.NextDouble() * (UpperLimit - LowerLimit));
        NewArray2[i] = Math.Round(NewArray2[i], 2);
    }
    return NewArray2;
}

double[] Array2 = CreateArray2(10);
Console.WriteLine($"Массив: [ {String.Join("; ", Array2)} ]");

double MaxNumber(double[] arrmax)
{
    double max = arrmax[0];
    int i = 0;
    while (i < arrmax.Length)
    {
        if (arrmax[i] > max) max = arrmax[i];
        i++;
    }
    return max;
}

double MaxArrayNumber = MaxNumber(Array2);
Console.WriteLine($"Максимальное число массива = {MaxArrayNumber}");

double MinNumber (double[] arrmin)
{
    double min = arrmin[0];
    int i = 0;
    while (i < arrmin.Length)
    {
        if (arrmin[i] < min) min = arrmin[i];
        i++;
    }
    return min;
}

double MinArrayNumber = MinNumber(Array2);
Console.WriteLine($"Минимальное число массива = {MinArrayNumber}");

double DivergenceMinMax (double Min, double Max)
{
    double DivergenceResult = Max - Min;
    return DivergenceResult;
}

double Result = DivergenceMinMax(MinArrayNumber, MaxArrayNumber);
Console.WriteLine($"Разница между минимаьным и максимальным элементами массива = {Result}");