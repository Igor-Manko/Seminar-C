// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

int[] fillArray(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random().Next(0, 2);
        index++;
    }
    return arr;
}

void printArray(int[] arr)
{
    int count = arr.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(arr[position] + " ");
        position++;
    }
    Console.WriteLine();
}

int[] array = new int[8];
fillArray(array);
printArray(array);

//Console.Write(String.Join(" ", array)); // печать массива сразу