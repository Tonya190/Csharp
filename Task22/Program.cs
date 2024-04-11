int [,] Fill2Array (int row,int colum)
{
    Random rnd = new Random();
    int [,] arr = new int [row,colum];
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
int [,] arr = Fill2Array(3,5);
Print2DArray(arr);
 