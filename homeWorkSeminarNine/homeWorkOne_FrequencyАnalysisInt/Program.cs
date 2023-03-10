// частотный анализатор цифр для одномерного массива { 1, 9, 9, 0, 2, 8, 0, 9 }
System.Console.WriteLine();
int[] array = { 1, 9, 9, 0, 2, 8, 0, 9 , 3,3,3};
System.Console.WriteLine(string.Join(";", array));
System.Console.WriteLine();
int[,] valueLibrary = FrequencyАnalysis(array);

PrintArray(valueLibrary);
System.Console.WriteLine();
PrintAnalysis(valueLibrary);
  
int[,] FrequencyАnalysis(int[] workArray)
{
int[,] library = {{0,1,2,3,4,5,6,7,8,9},{0,0,0,0,0,0,0,0,0,0}}; 

for (int i = 0; i < workArray.Length; i++)
{
  for (int j = 0; j < library.GetLength(1); j++)
  {
    if(workArray[i] == library[0,j]){library[1,j] = library[1,j] + 1;}
  }
} 
return library;
}

void PrintArray(int [,] arrayToPrint){
  
  for (int i = 0; i < valueLibrary.GetLength(0)  ; i++)
  {
    for (int j = 0; j < valueLibrary.GetLength(1); j++)
     {
      System.Console.Write(valueLibrary[i,j] + " " );
      }  
      System.Console.WriteLine();
  }
}

void PrintAnalysis(int [,] array)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
    System.Console.WriteLine($"Цифра {j} встречается {array[1,j]} раз.");
  }  
  System.Console.WriteLine();
}