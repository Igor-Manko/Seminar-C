// Написать программку, которая на входе принимает два числа и проверяет является ли первое число квадратом второго

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine("первое число является квадратом второго");
}
else
{
    Console.WriteLine("первое число НЕ является квадратом второго");
}