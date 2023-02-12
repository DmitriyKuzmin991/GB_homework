// Рекурсивно реализовать функцию Аккермана
//
//
//

Console.Write("Введите число m для функции Аккермана = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n для функции Аккермана = ");
int n = int.Parse(Console.ReadLine());

System.Console.WriteLine(akkerman(m,n));


int akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return akkerman(m-1,1);
  if (m > 0 && n > 0) return akkerman(m-1, akkerman(m,n-1));
  if (m < 0 || n < 0) return -1;
  return -1;
}
