// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

int[] fillArray(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

int posSum = 0;
int negSum = 0;

foreach (int item in fillArray(12))   // проход по массиву для каждого элемента
{
    posSum += item > 0 ? item : 0;     // если больше нуля положи значение в сумму позитив
    negSum += item < 0 ? item : 0;
}

//Console.WriteLine(String.Join(" ", fillArray(12)));
Console.WriteLine($"posSum = {posSum} negSum = {negSum}");


/*
int[] inputArray = new int[] { 7, 1, -3, 10,-10 };

void displayNegativeAndPositive(int[] getArray)
{

    int posSum = 0;
    int negSum = 0;

    foreach (int item in getArray)
    {
        posSum += item > 0 ? item : 0;
        negSum += item < 0 ? item : 0;
    }

    Console.WriteLine($"posSum = {posSum} negSum = {negSum}");
}
displayNegativeAndPositive(inputArray);
*/



