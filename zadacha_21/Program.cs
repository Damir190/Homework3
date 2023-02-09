// Задача 21 Напишите программу, которая принимает на вход координаты двух
//  точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.Write("Введите координату точки А по оси X: ");
int xa = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату точки А по оси Y: ");
int ya = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату точки А по оси Z: ");
int za = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату точки B по оси X: ");
int xb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату точки B по оси Y: ");
int yb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату точки B по оси Z: ");
int zb = int.Parse(Console.ReadLine()!);

int a = xb - xa;
int b = yb - ya;
int c = zb - za;

double a2 = Math.Pow(a, 2);
double b2 = Math.Pow(b, 2);
double c2 = Math.Pow(c, 2);
double result = Math.Sqrt(a2 + b2 + c2);

Console.Write($"Расстояние от точки A до точки B равно {result:F2}  ");