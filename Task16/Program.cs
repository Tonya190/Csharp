/*
Найдите произведение пар чисел в одномерном массиве. Первый - последний и тд
*/
int r = new Random().Next (1, 11);
int[] arr = new int[r];
for (int i = 0; i < arr.Length; i++)
{
    arr [i] = new Random().Next(1,11);
    Console.Write($"{arr[i]} ");
}
System.Console.WriteLine();

int[] arr2 = new int[r/2];
for (int i = 0; i < arr.Length/2 ; i++)
{
    arr2[i] = arr[i] * arr[arr.Length-i-1];
    Console.Write($"{arr2[i]} ");
}