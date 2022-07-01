// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.WriteLine("Введите координаты первой точки X & Y:");

int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки X & Y:");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());



double newPoint()
{
    double newPoint = Math.Sqrt(Math.Pow(x2-x1, 2)+ Math.Pow(y2-y1, 2));
    return newPoint;
}


Console.WriteLine(newPoint()); 
/*
Console.WriteLine ("Введите координаты первой точки");
Console.Write ("X1 :");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Y1 :");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координаты второй точки");
Console.Write ("X2 :");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Y2 :");
int n4 = Convert.ToInt32(Console.ReadLine());

double Distance (int x1,  int y1, int x2, int y2)
{
    double dis = Math.Sqrt((x2-x1)*(x2-x1)+(y2 -y1)*(y2 -y1));
    return dis;

}



Console.WriteLine(Distance(n1,n2,n3,n4));*/