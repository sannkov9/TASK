// Напишите программу которая будет принимать на вход два числа 
// и выводить является ли первое число кратным второму. Если первое
// число не кратно второму, то программа выводит остаток от деления.
// 35, 5 -> не кратно, остаток 4.
// 16,4 ->кратно

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = Remainder(numberA, numberB);

int Remainder(int numberA, int numberB)
{
    return numberA % numberB;
}
// if (result == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine($"не кратно, остаток {result}");
// }
string res = (result == 0) ? "Кратно" : $"не кратно, остаток {result}";
Console.WriteLine(res);