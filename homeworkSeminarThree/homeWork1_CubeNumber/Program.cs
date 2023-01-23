// Найти кубы чисел от 1 до N
Console.Write("Введите номер числа : ");
int number1 = int.Parse(Console.ReadLine());

for  (int index = 1; index<=number1; index++)
{
  
  Console.WriteLine(index + " в кубе = " + (index * index * index));
}

