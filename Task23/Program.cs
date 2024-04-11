/*
Задайте двумерный массив.Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты
*/
int [,] arr = new int [3,5];
Random rnd = new Random();
int [,] Fill2Array (int [,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); i++)
        {
            arr[i,j] = rnd.Next(1,100);
        }
    }
    return arr;
}
void Print2DArray (int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    const int startIndex = 0;
    for (var i = startIndex + 0; i < startIndex + arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{(i)}]\t");
    }
    Console.WriteLine();
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[" + i +"]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
void Print2DArrayNew (int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    const int startIndex = 0;
    for (var i = startIndex + 0; i < startIndex + arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{(i)}]\t");
    }
    Console.WriteLine();
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[" + i +"]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                Console.Write(Convert.ToInt32(Math.Pow(arrayToPrint[i,j],2)) + "\t");
            }
            else
            {
                Console.Write(arrayToPrint[i,j] + "\t");
            }
        }
        Console.WriteLine();
    }
}


Print2DArray(arr);
System.Console.WriteLine();
Print2DArrayNew(arr);

