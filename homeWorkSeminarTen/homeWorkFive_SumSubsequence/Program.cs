// Написать программу показывающие первые N чисел,
// для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем

Console.Write("Введите длинну последовательности = ");
int length = int.Parse(Console.ReadLine());
Console.Write("Введите первое число = ");
int firstCount = int.Parse(Console.ReadLine());
Console.Write("Введите второе число = ");
int secondCount = int.Parse(Console.ReadLine());

SumSubsequence(firstCount,secondCount,length);

void SumSubsequence (int firstCount,int secondCount, int length)
{
  int temp = 0;
  System.Console.WriteLine(firstCount+secondCount);
  temp = firstCount;
  firstCount = secondCount;
  secondCount = temp + secondCount;
  if (length > 1) SumSubsequence(firstCount,secondCount,length-1);
}

