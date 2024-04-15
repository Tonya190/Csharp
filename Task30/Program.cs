/*
Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
*/
System.Console.WriteLine(PowUser(2,3));
int PowUser(int a, int b)
{
    if (b == 1)
    {
        return a;
    }
    else
    {
        return a * PowUser(a, b-1);
    }
}