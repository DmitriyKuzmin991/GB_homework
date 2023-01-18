// Найти расстояние между точками в пространстве 2D

Console.Write("Введите координату х первой точки.");
int coordXOne = int.Parse(Console.ReadLine());
Console.Write("Введите координату y первой точки.");
int coordYOne = int.Parse(Console.ReadLine());
Console.Write("Введите координату х второй точки.");
int coordXSecond = int.Parse(Console.ReadLine());
Console.Write("Введите координату y второй точки.");
int coordYSecond = int.Parse(Console.ReadLine());

double distanceBetweenDots = Math.Sqrt(Math.Pow(coordXSecond-coordXOne,2)+Math.Pow(coordYSecond-coordYOne,2));

System.Console.WriteLine($"Расстояние между точками = {distanceBetweenDots}");