// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

/*
string findQvart(int Quote)
{
    if (Quote == 1){
        return "Все положительные";
    }
     if (Quote == 2){
        return "По X отрицательные, по Y положительные";
    }
     if (Quote == 3){
        return "Все отрицательные";
    }
     if (Quote == 4){
        return "X положительный, Y отрицательный";
    }
    return "err";
}
*/

Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

string Quote(int num)
{
    if (num >= 1 && num <= 4)
    {
        switch (num)
        {
            case 1:
                {
                    return "Все положительные";
                    
                }
            case 2:
                {
                    Console.WriteLine("По X отрицательные, по Y положительные");
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Все отрицательные");
                    break;
                }
            case 4:
                {
                    Console.WriteLine("X положительный, Y отрицательный");
                    break;
                }
        }

    }
    return "err";
}

Console.WriteLine(Quote(number));

/*
string ShowCoord ( int number)
{
    switch (number)
    {
        case  1: 
        {
            return " x > 0 и у >0";
            
        }
        case 2: 
         {   
            return " x < 0 и у >0";
            
         }
        case  3: 
         {   
            return " x < 0 и у <0";
            
         }
        case  4: 
        {
            return " x > 0 и у < 0";
            
        }
    }
    return "ошибка";
}

Console.Write ("Введите номер четверти : ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write(ShowCoord(num));
*/