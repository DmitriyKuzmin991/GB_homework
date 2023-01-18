// По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine());


if (numberOne*numberOne == numberTwo)
{ 
  Console.Write($"Второе число {numberTwo} является квадратом первого числа {numberOne}");
}
else if(numberOne == numberTwo*numberTwo)
{
  Console.Write($"Первое число {numberOne} является квадратом второго числа {numberTwo}");
}
else
{
  Console.Write("Числа квадратом друг друга не являются");
}
    