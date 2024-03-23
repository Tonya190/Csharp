/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
456-46
*/

int number = new Random().Next(100,1000);
Console.WriteLine(number);
int dig1 = number/100;
int dig2 = number % 10;
int result = (dig1*10) + dig2;
Console.WriteLine(result);
