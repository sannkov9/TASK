// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int NumberB = 2;

if (numberA > 1)
{
    while (NumberB <= numberA)
    {
        Console.Write(NumberB + " ");
        NumberB = NumberB + 2;
    }
}