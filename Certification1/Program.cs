/*
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.
*/
int start = Convert.ToInt32(Console.ReadLine());
int end = Convert.ToInt32(Console.ReadLine());
IntegersNum(start, end);

void IntegersNum(int start, int end)
{
    if (start > end)
    {
        return;
    }
    Console.Write(start);
    IntegersNum(start + 1, end); 
}