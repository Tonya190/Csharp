﻿/*
Дано натуральное трехзначное число. Создайте массив, состоящий из цифр этого числа. 
Младший разряд должен располагаться на 0-м индексе массива, старший на 2м
456 = 654
*/
int [] array = {1,2,3};
Array.Reverse(array);
Console.WriteLine(String.Join(',', array));