﻿Console.Clear();
string[] arr1 = new string[3] {"1234", "1567", "-2"};
string[] arr2 = new string[arr1.Length];
void ReleaseArray(string[] arr1, string[] arr2)
{
    int res = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[res] = arr1[i];
        res++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ReleaseArray(arr1, arr2);
PrintArray(arr2);