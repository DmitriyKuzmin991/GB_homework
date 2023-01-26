// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом


double[] doublesArray(int range)
{
  double[] theArray = new double[range];
  Random rand = new Random();
  
  for (int i = 0; i < theArray.Length; i++)
  {
    theArray[i] = rand.NextDouble();
  }
  return theArray;
}



double[] theArray = doublesArray(10);// заполнение массива значениями


double minValue = theArray[0];
double maxValue = theArray[1];


if (theArray[0] > theArray[1])
{
  minValue = theArray[1];
  maxValue = theArray[0];
}

for (int i = 2; i < theArray.Length; i++)// перебор массива и уточнение значений
{
  if (theArray[i] > maxValue)
  {
    maxValue = theArray[i];
  }
  else if (theArray[i] < minValue)
  {
    minValue = theArray[i];
  }
}
System.Console.WriteLine("Максимальное значение = " + maxValue);
System.Console.WriteLine();
System.Console.WriteLine("Минимальное значение = " + minValue);
System.Console.WriteLine();
System.Console.WriteLine("Разница значений между наибольшим  и наименьшим элементами массива = " + (maxValue - minValue));
System.Console.WriteLine();
System.Console.WriteLine(String.Join("**\n", theArray));