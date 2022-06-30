// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

string showNumber()
{
    Console.WriteLine("Введите число:");
    int num = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("Введите второе число:");
    //int num2 = Convert.ToInt32(Console.ReadLine());

    if (num % 7 == 0 && num % 23 == 0)
    {
        return "Введенное число кратно 7 и 23 одновременно";
    }
    else
    {
        return "Введенное число НЕ кратно 7 и 23 одновременно";
    }
}

Console.WriteLine(showNumber());