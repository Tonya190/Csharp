static void Main(string[] args)
{
    int[] array = { 1, 3, 5, 6, 7, 8 };
    foreach (int number in array)
        {
            Console.Write(number + ",");
        }
    System.Console.WriteLine();
    Array.Reverse(array);
    Console.WriteLine(String.Join(',', array));
}
//Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)