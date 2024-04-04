/*
Задайте массив из N случайных целых чисел (N вводится с клавиатуры).Найдите количество чисел, которые делятся нацело на 7
*/
void FillArray (int[] arr)
{
    System.Console.WriteLine("заполните массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}
System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] user_arr = new int [size];
FillArray(user_arr);
int CounEven(
    
)
