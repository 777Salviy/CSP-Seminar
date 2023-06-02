// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3 , 9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
//  сумма отрицательных равна -20.
// Глагол
int[] GetArray(int size, int minValue, int maxValue)
// size = 12, minValue = -9, maxValue = 9
{
    int[] resultArray = new int[size];

    for (int i = 0; i < resultArray.Length; i++) // i < resultArray.Length = i < size
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

int[] array = GetArray(12, -9, 9);
// Интерполяция ($)
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");

int positiveSum = 0; // +
int negativeSum = 0; // -

// 1-ый способ
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         positiveSum += array[i]; // positiveSum = positiveSum + array[i]
//     }
//     else // <=0
//     {
//         negativeSum += array[i]; // negativeSum = negativeSum + array[i] 
//     }
// }
// Console.WriteLine($"Сумма пол: {positiveSum}, отрц.: {negativeSum}");

// 2-ой способ (тернарный)
for (int i = 0; i < array.Length; i++)
{
    // Тернарный оператор
    // условие ? значение_ист : значение_ложное
    positiveSum += array[i] > 0 ? array[i] : 0; // Если число поло-е, то прибавляю array[i] 
    // иначе - прибавляю 0
    negativeSum += array[i] < 0 ? array[i] : 0;
}
Console.WriteLine($"Сумма пол: {positiveSum}, отрц.: {negativeSum}");