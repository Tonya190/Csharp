/*
Напишите программу, которая на вход принимает трехзначное число и на выходе показывает последнюю цифру этого числа
*/
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number%10;
if (number > 99&& number < 1000)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Число не трехзначное");
}