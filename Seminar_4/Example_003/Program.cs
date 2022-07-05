// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int myFactorial(int num)
{
    if (num == 0)
    {
        return 1;
    }
    return num * myFactorial(num - 1);

    /* int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        fact = fact * i;
    }
    return fact; */
}

Console.Write("Введите число для расчета факториала: ");
int numbers = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Значение факториала числа: " + myFactorial(numbers));