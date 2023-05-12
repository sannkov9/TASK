﻿// Напишите программу которая принимает на вход число
// и выдает кол-во чисел.
// 456 -> 3;

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int length = Length(number);
Console.WriteLine(length);

int Length (int num)
{
    int count = 0;
    while (num != 0)
    {
        num /= 10;
        count++;
    }
    return count;
}