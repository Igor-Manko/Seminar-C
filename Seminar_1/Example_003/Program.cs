// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int negativ_num = num * -1;

while (negativ_num <= num)
{
    Console.WriteLine(negativ_num);
    negativ_num ++;
}