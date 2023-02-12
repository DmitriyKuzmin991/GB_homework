// Найти сумму элементов от M до N, N и M заданы

Console.Write("Введите число N = ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число M = ");
int m = int.Parse(Console.ReadLine());

System.Console.WriteLine(RecursionSumElements(n,m));

int RecursionSumElements(int start, int end)
{
  if (start == end) return start;
  if (start > end ) return start + RecursionSumElements(start-1,end);
  return start + RecursionSumElements(start+1,end);
}