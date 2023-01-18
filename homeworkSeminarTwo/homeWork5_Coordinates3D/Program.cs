//Найти расстояние между точками в пространстве 3D

Console.Write("Введите координату х первой точки.");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату y первой точки.");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату z первой точки.");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату х второй точки.");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату y второй точки.");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату z второй точки.");
int z2 = int.Parse(Console.ReadLine());

double distanceBetweenDots = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
System.Console.WriteLine($"Расстояние между точками = {distanceBetweenDots}");