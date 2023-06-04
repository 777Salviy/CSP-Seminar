// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

int[] CreateArray(int lenghts)
{
    int[] NewArray = new int[lenghts];
    for (int i = 0; i < NewArray.Length; i++)
    {
        NewArray[i] = new Random().Next(1, 19 + 1);
    }
    return NewArray;
}

int OddIndexSum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    // В данной задаче считаю четность-нечетность по индексу массива (0, 1, 2, 3... и т.д.)
    // поэтому при суммировании чисел под нечетными индексами [i] (1, 3, 5 и т.д.)
    // визуально (в консоли) будут суммироваться числа на четных позициях. Для того чтобы 
    // суммировать визуально нечетные позиции следует заменить int i = 1; на int i = 0;
    {
        sum += arr[i];
    }
    return sum;
}

int[] Array = CreateArray(10);
Console.WriteLine($"Массив: [ {String.Join("; ", Array)} ]");

int OddSUM = OddIndexSum(Array);
Console.WriteLine($"Сумма чисел на нечетных позициях = {OddSUM}");

