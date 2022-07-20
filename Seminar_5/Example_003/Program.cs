// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.


int[] fillArray(int[] arr)
{
   
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
    return arr;
}

string findArray(int[] arr, int num)
{
   // int find = 3;
    //int count;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return ($"Число {num} есть в массиве");
        //else Console.WriteLine($"Чмсло {find} отсутствует в массиве");
    }
    return "отсутствует";

}

 int[] arr = new int[5];

Console.WriteLine(String.Join(" ", fillArray(arr)));
Console.WriteLine(String.Join(" ", findArray(arr, 3)));