/*
    Задача 2: Напишите программу, которая на вход принимает два числа
    и выдаёт, какое число большее, а какое меньшее.
    a = 5; b = 7 -> max = 7
    a = 2; b = 10 -> max = 10
    a = -9; b = -3 -> max = -3
*/

Console.Clear();

void MaxMinNumber(int a, int b)
{
    Console.Write($"(a = {a}, b = {b}) ");

    int max = a;
    int min = a;

    if (b > max) max = b;
    else min = b;

    Console.Write($"max = {max}; ");
    Console.WriteLine($"min = {min}");
}

MaxMinNumber(5, 7);
MaxMinNumber(2, 10);
MaxMinNumber(-9, -3);


