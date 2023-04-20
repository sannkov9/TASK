// Напишите программу которая принимает на вход координаты двух точек
// и находит растояние между ними в 2d пространсве.
// А(3,6); В(2,1) -> 5,09
// А(7,-5); В(1,-1) -> 7,21

double Distanceab(int xa, int ya, int xb, int yb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    double distAB = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    return distAB;
}

Console.WriteLine("Введите координаты точек:");
Console.Write("Xa: ");
int xaCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Ya: ");
int yaCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Xb: ");
int xbCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Yb: ");
int ybCoordinate = Convert.ToInt32(Console.ReadLine());

double distanceab = Distanceab(xaCoordinate, yaCoordinate, xbCoordinate, ybCoordinate);
double disRound = Math.Round(distanceab, 2, MidpointRounding.ToZero);


Console.WriteLine(disRound);