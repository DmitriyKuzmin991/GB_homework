// В двумерном массиве целых чисел. Удалить строку и столбец,
//на пересечении которых расположен наименьший элемент.

System.Console.WriteLine();
var workArray = new int[5, 5];
FillArray(ref workArray);
PrintArray(workArray);

var result = TrimArrayByMinimumValue(workArray);
System.Console.WriteLine();
PrintArray(result);


int[,] TrimArrayByMinimumValue(int[,] arrayForCute)
{
  var minValue = arrayForCute[0, 0];
  var minPositionRow = 0;
  var minPositionColumns = 0;

  for (int i = 0; i < arrayForCute.GetLength(0); i++) // find minimum elements, it's row and columns
  {
    for (int j = 0; j < arrayForCute.GetLength(1); j++)
    {
      if (arrayForCute[i, j] < minValue)
      {
        minValue = arrayForCute[i, j];
        minPositionRow = i;
        minPositionColumns = j;
      }
    }
  }

  System.Console.WriteLine();
  System.Console.WriteLine($"Минимальный элемент '{minValue}' находиться\n в '{minPositionRow + 1}' строке" +
  $" и '{minPositionColumns + 1}' столбце");

  int[,] cuteArray = new int[arrayForCute.GetLength(0) - 1, arrayForCute.GetLength(1) - 1];
  int indexK = 0;
  int indexB = 0;
  for (int i = 0; i < cuteArray.GetLength(0); i++)
  {
    if (i == minPositionRow) indexK += 1;
    for (int j = 0; j < cuteArray.GetLength(1); j++)
    {
      if (j == minPositionColumns) indexB += 1;
      cuteArray[i, j] = arrayForCute[indexK, indexB];
      indexB += 1;
    }
    indexB = 0;
    indexK += 1;
  }
  return cuteArray;
}


void FillArray(ref int[,] arrayToFill)
{
  var randon = new Random();

  for (int i = 0; i < arrayToFill.GetLength(0); i++)
  {
    for (int j = 0; j < arrayToFill.GetLength(1); j++)
    {
      arrayToFill[i, j] = randon.Next(1, 10);
    }
  }
}


void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
  }
}
