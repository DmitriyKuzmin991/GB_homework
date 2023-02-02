// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

System.Console.WriteLine("Введите количество строк массива: ");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество стобцов массива: ");
int m = int.Parse(Console.ReadLine());

int[,] newArray = new int[n, m];

System.Console.WriteLine();

FillArray(newArray);
PrintArray(newArray);
System.Console.WriteLine();
SquareEvenIndexArray(newArray);
PrintArray(newArray);



void PrintArray(int[,] arrayToPrint)
{
  for (int i = 0; i < arrayToPrint.GetLength(0); i++)
  {
    for (int j = 0; j < arrayToPrint.GetLength(1); j++)
    {
      System.Console.Write(arrayToPrint[i, j] + " ");
    }
    System.Console.WriteLine();
  }
}

int[,] FillArray(int[,] arrayToFill)
{
  Random random = new Random();

  for (int i = 0; i < arrayToFill.GetLength(0); i++)
  {
    for (int j = 0; j < arrayToFill.GetLength(1); j++)
    {
      arrayToFill[i, j] = random.Next(1, 11);
    }
  }
  return arrayToFill;
}

int[,] SquareEvenIndexArray(int[,] ArrayToSquarIndex)
{
  for (int i = 0; i < ArrayToSquarIndex.GetLength(0); i = i + 2)
  {
    for (int j = 0; j < ArrayToSquarIndex.GetLength(1); j = j + 2)
    {
      ArrayToSquarIndex[i, j] = ArrayToSquarIndex[i, j] * ArrayToSquarIndex[i, j];
    }
  }
  return ArrayToSquarIndex;
}