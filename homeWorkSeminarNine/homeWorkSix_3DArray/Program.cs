// Сформировать трехмерный массив не повторяющимися 
//двузначными числами показать его построчно 
//на экран выводя индексы соответствующего элемента

System.Console.WriteLine();

int [,,] workArray = new int[3,3,3];

FillAndPrintArray(ref workArray);

  
void FillAndPrintArray(ref int [,,] array){

  int doubleFigures = 10;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        array[i,j,k] = doubleFigures;
        doubleFigures += 1;
        System.Console.Write($"{i};{j};{k}='{array[i,j,k]}' ");
      }
    }
    System.Console.WriteLine();
    System.Console.WriteLine();
  }
  System.Console.WriteLine();
  System.Console.WriteLine();
}
