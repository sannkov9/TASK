﻿// Напишите программу которая на вход принимает
// число и проверяет его кратно ли оно одновременно 7 и 23
// 14 -> нет 
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = MultipleTwoDigits(number,7,23);
Console.WriteLine(result ? "да" : "нет");
bool MultipleTwoDigits(int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
}

