/*
Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
*/
Console.WriteLine("Введите число из отрезка [10,99]: ");
int number = Convert.ToInt32(Console.ReadLine());
int first = number / 10;
int two = number % 10;
int max = first;
if (two > max)
{
    max = two;
}
Console.WriteLine(max);
