// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] fillArray(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-5, 6);
       // if (arr[i] < 0) arr[i] = arr[i] * -1;
        //else arr[i] = arr[i] * -1;
        // if (arr[i] > 0) arr[i] = arr[i] * -1;
    }
    return arr;
} */

int[] getArray = new int[] { 1, 6, 3, -3, -7, -1 };

int[] replaceArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
    return arr;
}

//Console.WriteLine(String.Join(" ", fillArray(10)));

Console.WriteLine(String.Join(" ", replaceArray(getArray)));