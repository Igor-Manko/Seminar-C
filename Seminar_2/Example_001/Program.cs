// Напишите функцию, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int num = new Random().Next(100, 999);  // рандомное трёхзначное число
Console.WriteLine("Сгенерировано случайное число : " + num);

int showNumber(int num1)
{
    int firstNum = num1 / 100;
    int secondNum = num1 % 10;
    int newNum = firstNum * 10 + secondNum;

    Console.WriteLine("Первая цифра: " + firstNum);
    Console.WriteLine("Третья цифра: " + secondNum);

    return newNum;
}

Console.WriteLine("Новое число без второй цифры: " + showNumber(num));