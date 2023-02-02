// Массив заполненый реальными числами
Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

double[,] realNumberArray = new double[m,n];

Random random = new Random();

for (int i = 0; i < realNumberArray.GetLength(0); i++)
{
  for (int j = 0; j < realNumberArray.GetLength(1); j++)
  {
    realNumberArray[i,j] = random.Next(1,10) + random.NextDouble();
  }
}

System.Console.WriteLine();
double[,] PrintArray(double[,] array)

{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
  }
  return array;
}


PrintArray(realNumberArray);