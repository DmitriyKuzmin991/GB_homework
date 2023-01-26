// Определить, присутствует ли в заданном массиве, некоторое число


int[] myArray(int range, int maxValue)
{
  int [] theArray = new int [range];
  Random rand = new Random();

  for (int i = 0; i < theArray.Length; i++)
  {
    theArray[i] = rand.Next(maxValue); 
  }
  
  return theArray;
}

int[] theArray = myArray(10, 11);
//System.Console.WriteLine(string.Join(";", theArray));
System.Console.Write("Введите число для поиска в массиве от 0 до 10:\t");
int findCount = int.Parse(Console.ReadLine());
int result = 0;
for (int i = 0; i < theArray.Length; i++)
{
  if (theArray[i] == findCount)
  {
    result = 1;
    break;
  }
  
}

if (result == 1)
{
  System.Console.WriteLine("Такое число есть!");
  System.Console.WriteLine("Массив: " + string.Join(";", theArray));
}
else
{
  System.Console.WriteLine("Такого числа нет.");
  System.Console.WriteLine("Массив: " + string.Join(";", theArray));
}

