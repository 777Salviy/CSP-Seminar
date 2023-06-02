// void - будет дальше (после двумерных массивов)

// тип_возр_значения ИмяМетода (параметы)
// PascalCase
// calculate - переменная, Calculate - имя метода
int Calculate(int a, int b, char sign)
// a - число 1, b - число; char - 1 символ - '+'
{
    int result = 0;
    if (sign == '+')
    {
        result = a + b;
    }
    else if (sign == '-')
    {
        result = a - b;
    }
    else
    {
        Console.WriteLine("Такого знака еще нет :(");
    }
    return result;
}
// Вызов метода
Console.WriteLine(Calculate(100, 25, '-')); // 100 - 25 
Console.WriteLine(Calculate(100, 400, '+')); // 100 + 400 
Console.WriteLine(Calculate(100, 400, '*')); // 100 * 400  -> 0
