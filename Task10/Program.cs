/*
Задайте массив. Напишите программу которая определяет присутствует ли заданное число в массиве. Ответ да/нет
*/
int [] array = {1,2,3,4,5};
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int v = 0;
foreach ( int i in array)
{
    if (i == number)
    {
        v=number;
    }
}
if (v == number)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}