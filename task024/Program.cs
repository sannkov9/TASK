﻿// Напишите программу которая принимает на вход число А
// и выдает сумму чисел от 1 до А
// 7 = 28
// 4 = 10
// 8 = 36


Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumber = SumNumbers(number);
Console.WriteLine($"Сумма чисел он 1 до {number} = {sumNumber}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum = sum + i;
        // sum += i;
        }
    }
    return sum;
}