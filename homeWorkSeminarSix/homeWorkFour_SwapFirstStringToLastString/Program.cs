// Написать программу, которая обменивает элементы первой строки и последней строки


System.Console.WriteLine("Введите количество строк массива: ");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество стобцов массива: ");
int m = int.Parse(Console.ReadLine());

int[,] newArray = new int[n, m];

FillArray(newArray);
PrintArray(newArray);
System.Console.WriteLine();
SwapRowFirstToLast(newArray);
PrintArray(newArray);


int[,] SwapRowFirstToLast(int[,] ArrayToSwapRow){
  int countRow = ArrayToSwapRow.GetLength(0);
  int countColumns = ArrayToSwapRow.GetLength(1);
  int temp;

  for (int i = 0; i < countColumns; i++){
    temp = ArrayToSwapRow[0, i];
    ArrayToSwapRow[0, i] = ArrayToSwapRow[countRow - 1, i];
    ArrayToSwapRow[countRow - 1, i] = temp;
  }
  return ArrayToSwapRow;
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