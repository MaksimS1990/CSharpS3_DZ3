// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84.
// A (7,-5, 0); B (1,-1,9) -> 11.53.

Console.WriteLine("Введите координаты точки А (х,y,z)");
int xa = int.Parse(Console.ReadLine()!);
int ya = int.Parse(Console.ReadLine()!);
int za = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки B (х,y,z)");
int xb = int.Parse(Console.ReadLine()!);
int yb = int.Parse(Console.ReadLine()!);
int zb = int.Parse(Console.ReadLine()!);

double Length(int xa, int ya, int za, int xb, int yb, int zb)
{
    double result = 0;
    result =  Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
    return result;
}

Console.WriteLine($"Расстояние равно " + Length(xa, ya, za, xb, yb, zb));
