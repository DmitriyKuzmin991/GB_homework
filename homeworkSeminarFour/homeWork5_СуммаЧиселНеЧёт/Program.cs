// Найти сумму чисел одномерного массива стоящих на нечетной позиции





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

int[] theArray = myArray(10, 11);
int sumNumbers = 0;

for (int i = 0; i < theArray.Length; i++)
{
  if (i%2 == 0)
  {
    sumNumbers += theArray[i];
  }
}
System.Console.WriteLine("Сумма чисел на нечётных позициях в массиве = " + sumNumbers);
System.Console.WriteLine("Массив: " + string.Join("; ", theArray));
