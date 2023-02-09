// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

Console.Write("Введите пятизначное число : ");
int num = int.Parse(Console.ReadLine()!);
int a1 = num / 10000;
int a2 = num % 10;
int b1 = num / 1000 - a1 * 10;
int b2 = (num % 100 - a2) / 10;
if (num > 9999 && num < 100000)
{
    if (a1 == a2 && b1 == b2) Console.Write("Да! ");
    else Console.Write("Нет! ");
}
else Console.WriteLine($"Число {num} не является пятизначным! ");