// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

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


Console.WriteLine("Введите номер четверти на координатной оси : ");
int number = Convert.ToInt32(Console.ReadLine());

string Quote(int a)
{
    switch (a)
    {
        case 1:
            {
                return "X > 0, Y > 0";
            }
        case 2:
            {
                return "X < 0, Y > 0";
            }
        case 3:
            {
                return "X < 0, Y < 0";
            }
        case 4:
            {
                return "X > 0, Y < 0";
            }
    }
    return "err";
}

Console.WriteLine(Quote(number));