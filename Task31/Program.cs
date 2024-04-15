/*
Считать строку с консоли, содержащую латинские буквы.Вывести на экран согласные буквы этой строки.
*/
string str = Console.ReadLine();
char[] vowels = {'i','e','u','y','o','a'};
PrintSoglas(str, vowels , 0);

void PrintSoglas(string str, char[] arr, int i)
{
    if (i > str.Length )
    {
        return;
    }
    else
    {
        
        for (int j = 0; j < arr.Length; j++)
        {
            if(str[i] == arr[j])
            {
                System.Console.WriteLine(str[i]);
            }
        }
        PrintSoglas(str, arr, i = i+1);
    }
}