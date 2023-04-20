// Наипишите программу которая принимает на вход координаты точек (Х, У) 
// причем Х не равен 0 и У не равен 0. и выдает номер четверти плоскости
// в которой находлится эта точка.

Console.WriteLine("Введите координаты точек:");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoordinate, yCoordinate);
string result = quarter > 0 
                ? $"Указанные координаты соответсвуют четверти -> {quarter}" 
                : "указанны некоректные координаты";
Console.WriteLine(result);

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}