﻿/*
Задайте массив из 10 элементов, заполненный числами из промежутка [-10,10]. Замените отрицательные элементы на положительные и наоборот
*/

int [] arr = new int[10];
//Заполняем массив
for (int i = 0; i < 10; i++)
{
    arr [i] = new Random().Next(-10,11);
    Console.Write($"{arr[i]} ");
}
System.Console.WriteLine();

for (int i = 0; i < 10; i++)
{
    arr[i] = arr[i] * -1;
    Console.Write($"{arr[i]} ");
}