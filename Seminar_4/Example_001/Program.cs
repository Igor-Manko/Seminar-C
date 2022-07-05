// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до N.

Console.Write("Введите число :");
int num = Convert.ToInt32(Console.ReadLine());


int mySum(int numbers)
{
    int sum = 0;
    for (int i = 1; i <= numbers; i++)
    {
        // sum = sum + i;
        sum += i;
    }
    return sum;
}

Console.WriteLine(mySum(num));


/*
через while

int summary(int x)
{
    int sum = 0;
    int i = 0;
    while (i <= x)
    {
        sum = sum + i;
        i++;
    }
    return sum;
}

Console.WriteLine(summary(10)); */