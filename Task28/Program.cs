/*
Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
*/
int SumNumber(int num)
{
    if (num == 0)
    {
        return 0;
    }
    else
    {
        return num % 10 + SumNumber(num/10);
    }
}
System.Console.WriteLine(SumNumber(356));