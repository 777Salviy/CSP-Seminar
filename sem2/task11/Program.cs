// Задача 11. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.


Random rnd = new Random();
int rndNum = rnd.Next(100, 1000);
Console.WriteLine(rndNum);

int a = rndNum / 100;
int c = rndNum % 10;
int res = 10 * a + c;

Console.WriteLine(res);