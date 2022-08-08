// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
int number = new Random().Next(-10000000, 10000000);
Console.WriteLine($"Наше случайное число {number}");

int digit1 = number / 100;
int digit2 = number / 10;
int digit3 = number % 10;
int result = digit2 - digit1*10;

Console.WriteLine($"вторая цифра: {result}");