// Умножение двух матриц

System.Console.WriteLine();
int[,] matrixOne = new int[3, 3];
int[,] matrixTwo = new int[3, 3];

FillMatrix(ref matrixOne);
FillMatrix(ref matrixTwo);

PrintTwoArray(matrixOne, matrixTwo);
System.Console.WriteLine();

var result = DivisionTwoMatrix(matrixOne, matrixTwo);
PrintOneMatrix(result);


void PrintOneMatrix(int[,] result){
System.Console.WriteLine();
for (int i = 0; i < result.GetLength(0); i++)
  {
    System.Console.Write("   ");
    for (int j = 0; j < result.GetLength(1); j++)
    {
      System.Console.Write(result[i, j] + " ");
    }
    System.Console.WriteLine();
  }
}


int[,] DivisionTwoMatrix(int[,] firstMatrix, int[,] secondMatrix){

  int[,] result = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];

  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      result[i, j] = 0;

      for (int k = 0; k < result.GetLength(1); k++)
      {
        result[i, j] += matrixOne[i, k] * matrixTwo[k, j];
      }
    }
  }
  return result;
}

int[,] FillMatrix(ref int[,] array){

  Random random = new Random();

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = random.Next(1, 5);
    }
  }
  return array;
}

void PrintTwoArray(int[,] arrayToPrintOne, int[,] arrayToPrintTwo){

  for (int i = 0; i < arrayToPrintOne.GetLength(0); i++)
  {
    for (int j = 0; j < arrayToPrintOne.GetLength(1); j++)
    {
      System.Console.Write(arrayToPrintOne[i, j] + " ");
    }
    System.Console.Write("   ");
    for (int k = 0; k < arrayToPrintTwo.GetLength(1); k++)
    {
      System.Console.Write(arrayToPrintTwo[i, k] + " ");
    }
    System.Console.WriteLine();
  }
}
