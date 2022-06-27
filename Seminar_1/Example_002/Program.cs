// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

int num = 0;

while(num < 1 | num > 7)
{
    Console.WriteLine("Введите число от 1 до 7: ");
    num = Convert.ToInt32(Console.ReadLine());
}

switch (num)
{
    case 1:{
        Console.WriteLine("Понедельник");
        break;
    }
    case 2:{
        Console.WriteLine("Вторник");
        break;
    }
    case 3:{
        Console.WriteLine("Среда");
        break;
    }
    case 4:{
        Console.WriteLine("Четверг");
        break;
    }
    case 5:{
        Console.WriteLine("Пятница");
        break;
    }
    case 6:{
        Console.WriteLine("Суббота");
        break;
    }
    case 7:{
        Console.WriteLine("Воскресенье");
        break;
    }
}

/*
Console.WriteLine("Введите номер дня недели от 1 до 7: ");
string number = Console.ReadLine();

if (number == "1")
{
    Console.WriteLine("Понедельник");
}
if (number == "2")
{
    Console.WriteLine("Вторник");
}
if (number == "3")
{
    Console.WriteLine("Среда");
}
if (number == "4")
{
    Console.WriteLine("Четверг");
}
if (number == "5")
{
    Console.WriteLine("Пятница");
}
if (number == "6")
{
    Console.WriteLine("Суббота");
}
if (number == "7")
{
    Console.WriteLine("Воскресенье");
}
*/