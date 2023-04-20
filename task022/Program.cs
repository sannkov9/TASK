﻿// напишите программу которая принимает на вход число (N)
// и выдает таблицу квадратов чисел от 1 до N
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

void TableAllSquares(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index, 3}  {index * index, 4}");
        index ++;
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
TableAllSquares(number);