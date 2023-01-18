// Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Введите номер четверти: ");
int numberOfPlace = int.Parse(Console.ReadLine());


if (numberOfPlace == 1)
{
  Console.WriteLine("Четверть номер 1.");
  Console.WriteLine("Возможные координаты x>0");
  Console.WriteLine("Возможные координаты y>0");
}
else if (numberOfPlace == 2)
{
  Console.WriteLine("Четверть номер 2.");
  Console.WriteLine("Возможные координаты x<0");
  Console.WriteLine("Возможные координаты y>0");
}
else if (numberOfPlace == 3)
{
  Console.WriteLine("Четверть номер 3");
  Console.WriteLine("Возможные координаты x<0");
  Console.WriteLine("Возможные координаты y<0");
}
else if (numberOfPlace == 4)
{
  Console.WriteLine("Четверть номер 4");
  Console.WriteLine("Возможные координаты x>0");
  Console.WriteLine("Возможные координаты y<0");
}
else
{
  Console.WriteLine("Неверный номер");
}
