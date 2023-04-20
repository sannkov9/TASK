// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distanceab(int xa, int ya, int za, int xb, int yb, int zb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    int deltaZ = za - zb;
    double distAB = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    return distAB;
}

Console.WriteLine("Введите координаты точек:");
Console.Write("Xa: ");
int xaCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Ya: ");
int yaCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Za: ");
int zaCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Xb: ");
int xbCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Yb: ");
int ybCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Zb: ");
int zbCoordinate = Convert.ToInt32(Console.ReadLine());

double distanceab = Distanceab(xaCoordinate, yaCoordinate, zaCoordinate, xbCoordinate, ybCoordinate, zbCoordinate);
double disRound = Math.Round(distanceab, 2, MidpointRounding.ToZero);


Console.WriteLine(disRound);