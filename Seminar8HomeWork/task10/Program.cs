﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1
void twodig(int dig)
{
    int des = dig / 10;
    int des2 = des % 10;
    Console.WriteLine($"Вторая цифра в числе: {des2}");
}
Console.Write("Введите трехзначное число: ");
//Console.Read();
twodig(Convert.ToInt32(Console.ReadLine()));





