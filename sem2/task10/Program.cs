// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

void GenNumbers(int[] arr)
{
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(10, 100);
    }
}

// Random rnd = new Random();
// int rndNum = rnd.Next(10, 100); // 10 - 99
//                                 // 5 6
// int a = rndNum % 10; // 4
// int b = rndNum / 10;
// if (a > b)
// {
//     Console.WriteLine(a);
// }
// else
// {
//     Console.WriteLine(b);
// }

int[] arr = new int[10]; // { 0,0,0,0,0,0....}

GenNumbers(arr); // { 15,15,64,16,83....}

for (int i = 0; i < arr.Length; i++) // 0 = 15
{
    int left = arr[i] / 10; // 15 / 10 = 1
    int right = arr[i] % 10; // 15 % 10 = 5
    if (left > right)
    {
        Console.WriteLine($"Наибольшая цифра числа {arr[i]} = " + left);
    }
    else
    {
        Console.WriteLine($"Наибольшая цифра числа {arr[i]} = " + right);
    }
}