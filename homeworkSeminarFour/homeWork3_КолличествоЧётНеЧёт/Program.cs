// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел


int[] myArray(int range, int minValue, int maxValue)
{
  int[] theArray = new int[range];
  Random rand = new Random();

  for (int i = 0; i < theArray.Length; i++)
  {
    theArray[i] = rand.Next(minValue, maxValue);
  }

  return theArray;
}

int[] theArray = myArray(20, 100, 999);
int evenNumbers = 0;
int oddNumbers = 0;
for (int i = 0; i < theArray.Length; i++)
{
  if (theArray[i] % 2 == 0)
  {
    evenNumbers += 1;
  }
  else
  {
    oddNumbers += 1;
  }
}
System.Console.WriteLine($"Количество не чётных чисел = {oddNumbers}.\nКоличество чётных чисел = {evenNumbers}.\n");
System.Console.WriteLine("Массив: " + string.Join("; ", theArray));