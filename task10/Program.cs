﻿// Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
int number = new Random().Next(100, 1000);
Console.WriteLine($"Наше случайное число {number}");
int digit1 = number / 100;
int digit2 = number / 10;
int result = digit2 - digit1*10;

Console.WriteLine($"вторая цифра: {result}");