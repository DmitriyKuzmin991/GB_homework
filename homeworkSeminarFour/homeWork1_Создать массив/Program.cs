//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран


Random rand = new Random();
int[] myArray = new int [8];
for (int i = 0; i < myArray.Length; i++)
{
  myArray[i] = rand.Next(2); 
}
System.Console.WriteLine(string.Join(";", myArray));
