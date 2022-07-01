//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
//квадратов чисел от 1 до N.

// Вариант 1

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int Sqrt2(int num)
{
    int a = num * num;
    return a;
}

int index = 1;
while (index <= number) {
    Console.Write(Sqrt2(index) + " ");
    index++;
}
/*

// Вариант 2

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int squareTable(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write(i * i + " | ");
    }
    Console.WriteLine();
    return n;
}
squareTable(number); */