// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.WriteLine("Введите координаты первой точки");
Console.Write("X1 :");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 :");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X2 :");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 :");
int d = Convert.ToInt32(Console.ReadLine());

double newPoint(int x1, int y1, int x2, int y2)
{
    double dis = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return dis;
}

Console.WriteLine(newPoint(a, b, c, d)); 