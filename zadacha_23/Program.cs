﻿// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int count = 1;

while (count <= N)
{
    double result = Math.Pow(count, 3);
    Console.Write($"{result} ");
    if (count != N) Console.Write(", ");
    count++;
}