// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int digitIndex = 3;
// if (number.Length > 0)
// {
//     if (number[0] == '-')
//     {
//         digitIndex++;
//     }
// }
// if (number.Length < digitIndex)
// {
//     Console.WriteLine($"Во введенном числе {number} третья цифра отсутствует");
// }
// else
// {
//     Console.WriteLine($"третья цифра {number[digitIndex - 1]} ");
// }



// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int digitIndex = 2;
// if (number.Length > 0)
// if (number[0] == '-')
// {
//     digitIndex++;
// }

// if (number.Length <= digitIndex)
// {
//     Console.WriteLine($"Во введенном числе {number} третья цифра отсутствует");
// }
// else
// {
//     Console.WriteLine($"третья цифра {number[digitIndex]} ");
// }

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int index = 2;
if (number[0] == '-') index++;
if (number.Length <= index)
{
    Console.WriteLine($"Во введенном числе {number} третья цифра отсутствует");
}
else
{
    Console.WriteLine($"третья цифра {number[index]} ");
}