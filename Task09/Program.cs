/*
Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибоильшую цифру числа
*/

int number = new Random ().Next(10,100);
System.Console.WriteLine(number);
int first = number / 10;
int second = number % 10;
int max = first;

if(second > max)
{
    max = second;
}

Console.WriteLine(max);

