/*
    Задача 6: Напишите программу, которая на вход принимает 
    число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    4 -> да
    -3 -> нет
    7 -> нет
*/

Console.Clear();

Console.WriteLine("Является ли число чётным?");
void EvenNumber(int num)
{ 
    if (num % 2 == 0)
    {
        Console.WriteLine($"{num} -> да");
    }
    else 
    {
        Console.WriteLine($"{num} -> нет");
    }
}

EvenNumber(4);
EvenNumber(-3);
EvenNumber(7);
