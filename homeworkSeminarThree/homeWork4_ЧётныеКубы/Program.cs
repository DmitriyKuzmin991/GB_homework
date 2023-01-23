// Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Введите номер числа : ");
int number1 = int.Parse(Console.ReadLine());
int result = 0;
for  (int index = 1; index<=number1; index++)
{
  result = index * index * index;
  if (result%2 == 0)
  {
    Console.WriteLine(index + " в кубе заканчивается на чётную цифру = " + result);
  }
  
}

