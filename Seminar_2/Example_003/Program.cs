// Напишите функцию, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит остаток от деления.

string showNumber()
{
    // int num1 = new Random().Next(10, 20);
    // int num2 = new Random().Next(10, 20);
    Console.WriteLine("Введите первое число:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num2 % num1 == 0)
    {
        return "Второе число кратно первому";
    }
    else
    {
        return ("Остаток деления = " + num2 % num1);
    }
}

Console.WriteLine(showNumber());