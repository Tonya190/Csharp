/*
Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
*/
int[] arr = {1,2,3,4,5,6};
ArrayReverse(arr,arr.Length-1);
void ArrayReverse(int[] arr,int index)
{
    if (index < 0)
    {
        return;
    }
    System.Console.Write(arr[index]+ " ");
    ArrayReverse(arr, index - 1);
}