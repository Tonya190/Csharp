/*
Задайте одномерный массив, заполненный случайными целыми числами. Определите количество четных чисел в этом массиве. 
*/
void FillArrray (int start, int end, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(start, end);
    }
}
void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}
int CountEven (int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            result ++;
        }
    }
    return result;
}

int [] user_arr = new int [10];
FillArrray(1,100,user_arr);
PrintArray(user_arr);
System.Console.WriteLine();
System.Console.WriteLine(CountEven(user_arr));
