// Подсчитать сумму цифр в числе
Console.Write("Введите число : ");
string str = Console.ReadLine();
int length = str.Length;
double result = 0;

for (int index = 0; index < length; index++)
{

  double numberValue = Char.GetNumericValue(str, index);
  result = result + numberValue;
  System.Console.Write(numberValue + " ");
}

Console.WriteLine("Сумма чисел = " + result);