//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой находится эта точка.
//     .............................
//     .            .              .
//     .            .              .
//     .     2      .       1      .
//     .            .              .
//     .............................
//     .            .              .
//     .            .              .
//     .     3      .       4      .
//     .            .              .
//     .............................


string findQvart(int a, int b)
{
    if (a > 0 && b > 0){
        return "1 четверть";
    }
     if (a < 0 && b > 0){
        return "2 четверть";
    }
     if (a < 0 && b < 0){
        return "3 четверть";
    }
     if (a > 0 && b< 0){
        return "4 четверть";
    }
    return "err";
}

Console.WriteLine("Введите координату X :");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y :");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(findQvart(x, y));