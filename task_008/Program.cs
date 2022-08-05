/*
    Задача 8: Напишите программу, которая на вход принимает число (N), 
    а на выходе показывает все чётные числа от 1 до N.
    5 -> 2, 4
    8 -> 2, 4, 6, 8
*/

Console.Clear();

void EvenNumber(int N)
{
    Console.Write($"Четные числа от 0 до {N} -> ");

    int count = 2;
    while (count <= N)
    {
        if (count % 2 == 0) 
        {
            Console.Write(count);
            Console.Write(" ");
        }
        count++;
    }
    
    Console.WriteLine();
}

EvenNumber(5);
EvenNumber(8);

