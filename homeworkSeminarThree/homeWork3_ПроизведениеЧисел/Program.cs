// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите число: ");
int numberValue = int.Parse(Console.ReadLine());
int result = 1;
for (int i = 1; i <= numberValue; i++)
{
  result *= i;
  System.Console.WriteLine($"Произведения чисел до числа {i} = {result}.");
}
