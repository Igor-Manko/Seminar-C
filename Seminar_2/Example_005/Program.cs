﻿// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.



string showNumber()
{
    Console.WriteLine("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 == num2 * num2)
    {
        return "Первое число является квадратом второго";
    }
    else
    {
        return "Первое число НЕ является квадратом второго";
    }
}
Console.WriteLine(showNumber());