// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int myCounter(int numbers)
{
    int i = 0;
    while (numbers > 0)
    {
        numbers = numbers / 10;
        i++;
    }
    return i;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Количество цифр в числе: " + myCounter(num));