//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
//квадратов чисел от 1 до N.
/*
int Sqrt2(int num)
{
    int a = num * num;
    return a;
}

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int index = 1;
while (index <= number)
{
    Console.WriteLine(Sqrt2(index));
    index++;
}*/
Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int powTable(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write(i * i + "|");
    }
    Console.WriteLine();
    return n;
}
powTable(number);