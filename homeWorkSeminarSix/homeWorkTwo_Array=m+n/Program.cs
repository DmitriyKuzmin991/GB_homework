// Задать двумерный массив следующим правилом: Aₘₙ = m+n

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());


int[,] myArray = new int[m, n];

FillArray(myArray);
System.Console.WriteLine();
PrintArray(myArray);

int[,] FillArray(int[,] arrayToFill)
{
  for (int i = 0; i < arrayToFill.GetLength(0); i++)
  {
    for (int j = 0; j < arrayToFill.GetLength(1); j++)
    {
      arrayToFill[i, j] = i + j;
    }
  }
  return arrayToFill;
}

int[,] PrintArray(int[,] array)

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
