/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
Указание Использовать рекурсию. Не использовать цикл.
*/
System.Console.WriteLine("Введите число num: ");
int num = Convert.ToInt32(Console.ReadLine());
IntegersNum(num);

void IntegersNum(int num, int count = 1)
{
    if (num < count)
    {
        return;
    }
    else
    {
        System.Console.Write(count);
        IntegersNum(num, count+1);
    }
}