// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
int[] ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= (-1); //  arr[i] =  arr[i] * (-1)
    }
    return arr;
}

int[] array = GetArray(12, -9, 9);
// Интерполяция ($)
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");
Console.WriteLine($"Перевернутый массив: [ {String.Join("; ", ReverseArray(array))} ]");
