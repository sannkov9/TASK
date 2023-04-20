// Напишите программу, которая по заданному номеру четверти
// показывает диапозон возможных координат точек в этой четверти(х,у)

Console.WriteLine("Введите четверть: ");
int numberQuater = Convert.ToInt32(Console.ReadLine());

string coordinate = Coordinate(numberQuater);
Console.WriteLine (coordinate == null 
                    ?"Введен неправильный номер четверти": coordinate);

string Coordinate(int num)
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x < 0, y < 0";
    if (num == 4) return "x > 0, y < 0";
    return null;
}

