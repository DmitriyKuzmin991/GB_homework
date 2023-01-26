// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.



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

int[] theArray = myArray(13, 6);
int arrLength = theArray.Length;
for (int i = 0; i < arrLength - 1; i++)
{
  System.Console.WriteLine($"Результат произведения {i+1} пары чисел массива = " + theArray[i] * theArray[arrLength-1]);
  
  arrLength = arrLength - 1;
}

System.Console.WriteLine("Массив: " + string.Join("; ", theArray));
