/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
*/
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int result = Ackerman(num1, num2);
Console.WriteLine(result);

int Ackerman(int num1, int num2)
{
    if (num1 == 0)
    {
        return num2 + 1;
    }
    else if (num1 > 0 && num2 == 0)
    {
        return Ackerman(num1 - 1, 1);
    }
    else if (num1 > 0 && num2 > 0)
    {
        return Ackerman(num1 - 1, Ackerman(num1, num2 - 1));
    }
     else
    {
        return -1; 
    }
}