// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить,
// что это невозможно (в случае, если матрица не квадратная).

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] arrayForSwap = new int[m, n];
System.Console.WriteLine();
FillArray(arrayForSwap);
PrintArray(arrayForSwap);
System.Console.WriteLine();

if (arrayForSwap.GetLength(0) < 2 || arrayForSwap.GetLength(1) < 2)
{ System.Console.WriteLine("Массив не является прямоугольным"); }
else{
  arrayForSwap = swapRowColumns(arrayForSwap);
  PrintArray(arrayForSwap);
}

int[,] swapRowToColumns(int[,] array)
{
  int[,] cloneArray = new int[array.GetLength(1), array.GetLength(0)];

  for (int i = 0; i < cloneArray.GetLength(0); i++)//5
  {
    for (int k = 0; k < cloneArray.GetLength(1); k++)//3
    {
      cloneArray[i, k] = array[k, i];
    }
  }

  return cloneArray;
}


int[,] FillArray(int[,] arrayToFill)
{
  Random rand = new Random();
  for (int i = 0; i < arrayToFill.GetLength(0); i++)
  {
    for (int j = 0; j < arrayToFill.GetLength(1); j++)
    {
      arrayToFill[i, j] = rand.Next(1, 10);
    }
  }
  return arrayToFill;
}

int[,] PrintArray(int[,] arrayToPrint)

{
  for (int i = 0; i < arrayToPrint.GetLength(0); i++)
  {
    for (int j = 0; j < arrayToPrint.GetLength(1); j++)
    {
      System.Console.Write(arrayToPrint[i, j] + " ");
    }
    System.Console.WriteLine();
  }
  return arrayToPrint;
}