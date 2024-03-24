/*
Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
*/
Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10)
{
    Console.WriteLine(number);
}
else 
{
    int first = number / 10;
    int two = number % 10;
    Console.Write(first + "," + two);
}



