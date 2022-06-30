// Напишите функцию, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру этого числа

int showNumber()
{
    int num = new Random().Next(10, 99);
    int first = num / 10;             // узнаем первую цифру числа
    int second = num % 10;            // узнаем вторую цифру числа (остаток после деления на 10)

    Console.Write(num + "->");

    if(first>second)                   // сравниваем первую и вторую цифру случайного числа
    {
        return first;
    }
    else
    {
        return second;
    }
};

Console.WriteLine(showNumber());       // выводим результат работы функции в консоль