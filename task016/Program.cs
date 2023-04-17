// Напишите программу которая на вход принимает два числа
// и проверяет является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
bool result = IsSquare(numberA,numberB);
Console.WriteLine(result? "да" : "нет");

bool IsSquare (int numA, int numB)
{
    // return numA * numB == 0 && numA * num2 == 0;
    return (numA == numB * numB) || (numB == numA * numA);
}
 
