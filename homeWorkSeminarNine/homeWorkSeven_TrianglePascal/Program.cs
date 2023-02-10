// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника


Console.Write("Введите высоту треугольника = ");
int hight = int.Parse(Console.ReadLine());

int[][] trianglePascal = new int[hight][];

for (int i = 0; i < trianglePascal.Length; i++) // Создаём зубчатый массив 
{
  trianglePascal[i] = new int[i + 1];
}

FillArray(ref trianglePascal);
PrintArrayWithSpace(trianglePascal);

static void FillArray(ref int[][] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    for (int j = 0; j < array[i].Length; j++)
    {
      if (j == 0 || j == (array[i].Length - 1)) // первый и последний элемент массива равен 1
      {
        array[i][j] = 1;
      }
      else
        array[i][j] = array[i - 1][j - 1] + array[i - 1][j];
    }
  }

}


static void PrintArrayWithSpace(int[][] array)
{
  for (int j = 0; j < array.Length; j++)
  {
    for (int k = 0; k < array.Length - j; k++) // создаём отступ
    {
      System.Console.Write(" ");
    }

    for (int i = 0; i < array[j].Length; i++)
    {

      System.Console.Write(array[j][i] + " ");
    }
    System.Console.WriteLine();
  }
}







