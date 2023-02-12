// Показать натуральные числа от N до M

Console.Write("Введите число N = ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число M = ");
int m = int.Parse(Console.ReadLine());

RecursionRangeNumber(n,m);

void RecursionRangeNumber(int start, int end)
{
  System.Console.WriteLine(start);
  if(start == end) System.Console.WriteLine();
  else if(start>end) RecursionRangeNumber(start -1,end);
  else RecursionRangeNumber(start+1,end);
}
