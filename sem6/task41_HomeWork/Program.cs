// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetArray(int size)
{
    Console.WriteLine($"Введите массив состоящий из {size} чисел: ");
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int GetPositiveNumbersSum(int[] madeArray)
{
    int sum = 0;
    for (int i = 0; i < madeArray.Length; i++)
    {
        if (madeArray[i] > 0) sum = sum + madeArray[i];
    }
    return sum;
}

int[] resultArray = GetArray(10);
Console.WriteLine($"Сохданный массив: [{String.Join(" ,", resultArray)}]");

int positiveSum = GetPositiveNumbersSum(resultArray);
Console.WriteLine($"Сумма положительных чисел массива = {positiveSum}");