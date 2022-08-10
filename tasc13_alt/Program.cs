// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");
 int number = Convert.ToInt32(Console.ReadLine());
 int digitIndex = 2; // Индекс нужной цифры
 if (number < 0)
{
    number = -number;
}
 if(number>100)
 {
    int digit = number.ToString()[digitIndex] - '0';
    Console.WriteLine("третья цифра" + digit);
 }
 else
 {
    Console.WriteLine($"Во введенном числе {number} третья цифра отсутствует");
 }