// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Sergey: приверы: [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 124);
    }
    return arr;
}

int CountArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 10 & arr[i] < 99)
            count++;
    }
    return count;
}

int[] array = new int[6];

FillArray(array);
Console.WriteLine(String.Join(" | ", array));
Console.WriteLine($"Количество чисел в интервале от 10 до 99: {CountArray(array)}");
