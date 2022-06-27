// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    
    Console.Write("Последняя цифра трехзначного числа: ");
    Console.WriteLine(num % 10);
}
else 
{
    Console.WriteLine("Введите корректное число!");
}