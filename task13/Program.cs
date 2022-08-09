// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
int number = new Random().Next(Int32.MinValue, Int32.MaxValue);
Console.WriteLine($"Наше случайное число {number}");
if (number < 0)
{
    number = -number;
}
if (number < 100)
{
    Console.WriteLine("третей цифры нет");
}
while (number > 1000)
{
    number /= 10;
    //number = number / 10;
}
int result = number % 10;
Console.WriteLine($"третья цифра: {result}");