﻿// Задайте массив из 12 эл-ов, 
// заполненый случайными элементами из промежутка (-9,9)
// найдите сумму отрицательных и положительных элементов массива.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int[] array = CreateArrayRndInt(12, -9, 9);

Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();
