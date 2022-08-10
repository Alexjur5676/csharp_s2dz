// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int digitIndex = 3;
if (number.Length > 0)
{
    if (number[0] == '-')
    {
        digitIndex++;
    }
}
if (number.Length < digitIndex)
{
    Console.WriteLine($"Во введенном числе {number} третья цифра отсутствует");
}
else
{
    Console.WriteLine($"третья цифра {number[digitIndex - 1]} ");
}
