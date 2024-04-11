/*
Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
*/
char [,] arr = new char [,] {{'l','o'},{'v','e'}};
string result = CreateString(arr);
Console.WriteLine(result);
string CreateString(char[,] arr)
{
    string result = "";
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result += arr[i, j];
        }
    }
    return result;
}