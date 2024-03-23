/*
Напишите программу, которая будет принимать на вход два числа и выводить явяется ли второе число кратным первому, 
если второе число не кратно первому,то программа выводит остаток от деления
*/
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)
{
    Console.WriteLine("Кратно");
}
else 
{
    Console.WriteLine("Некратно. Остаток от деления -" + " " + number1 % number2);
}