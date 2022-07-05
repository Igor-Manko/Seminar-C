// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

Console.Write("Введите число :");
int num = Convert.ToInt32(Console.ReadLine());


int mySum(int numbers)
{
    int sum = 0;
    for (int i = 1; i <= numbers; i++)
    {
        sum = sum + i;
    }
    return sum;
}

Console.WriteLine(mySum(num));