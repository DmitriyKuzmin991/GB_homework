// В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] workArray = new int[m, n];

System.Console.WriteLine();
FillArray(workArray);
PrintArray(workArray);
System.Console.WriteLine();
minSumRow(workArray);


void minSumRow(int[,] array)
{
  int[] sumResultArray = new int[array.GetLength(0)];
  int minSumRow = 0;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      minSumRow += array[i, j];
    }
    sumResultArray[i] = minSumRow;
    minSumRow = 0;
  }

  int minValue = sumResultArray[0];
  int minRow = 1;

  for (int i = 1; i < sumResultArray.Length; i++)
  {
    if (minValue > sumResultArray[i]){
      minValue = sumResultArray[i];
      minRow = i+1;}
  }
  System.Console.WriteLine($"Минимальная сумма элементов = {minValue} в строке №{minRow}");;
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