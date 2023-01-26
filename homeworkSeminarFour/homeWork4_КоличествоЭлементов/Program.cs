// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]



int[] myArray(int range, int maxValue)
{
  int[] theArray = new int[range];
  Random rand = new Random();

  for (int i = 0; i < theArray.Length; i++)
  {
    theArray[i] = rand.Next(maxValue);
  }

  return theArray;
}

int[] theArray = myArray(100, 123);
string strNumber = String.Empty;
for (int i = 9; i < 98; i++)
{
  strNumber =strNumber + theArray[i];
}


System.Console.WriteLine("Строка из найденных значений\n" + strNumber + "\n");
System.Console.WriteLine("Количество элементов в нужном отрезке = " + strNumber.Length + "\n");
//System.Console.WriteLine("Массив: " + string.Join("; ", theArray));
System.Console.Write("Элементы масива из нужного отрезка ");
for (int i = 9; i < 98; i++)
{
  System.Console.Write(theArray[i] + "; ");
}