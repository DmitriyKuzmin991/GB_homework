// Показать натуральные числа от N до 1, N задано

Console.Write("Введите число = ");
int x = int.Parse(Console.ReadLine());

Recursion(x);

void Recursion(int n)
{
  System.Console.WriteLine(n);
  if (n == 1 || n <= 0) System.Console.WriteLine();
  else Recursion(n-1);
}
