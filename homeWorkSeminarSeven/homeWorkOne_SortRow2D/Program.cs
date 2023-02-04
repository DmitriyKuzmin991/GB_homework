// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] sortArray = new int[m, n];

FillArray(sortArray);
System.Console.WriteLine("\nИзначальный массив");
PrintArray(sortArray);

for (int k = 0; k < sortArray.GetLength(0); k++)
{
  for (int i = 0; i < sortArray.GetLength(1); i++)
  {
    var maxValue = sortArray[k, i];
    var maxPosition = i;
    var temp = sortArray[k, i];

    for (int j = i + 1; j < (sortArray.GetLength(1)); j++)
    {
      if (sortArray[k, j] > maxValue)
      {
        maxValue = sortArray[k, j];
        maxPosition = j;
      }

    }
    sortArray[k, i] = maxValue;
    sortArray[k, maxPosition] = temp;
  }
}

System.Console.WriteLine("\nСортированный массив");
PrintArray(sortArray);



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