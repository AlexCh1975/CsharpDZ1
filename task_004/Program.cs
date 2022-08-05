/*
    Задача 4: Напишите программу, которая принимает на вход 
    три числа и выдаёт максимальное из этих чисел.
    2, 3, 7 -> 7
    44 5 78 -> 78
    22 3 9 -> 22
*/
 Console.Clear();

 void MaxNumber(int a, int b, int c)
 {
    int max = a;
    if (b > max) max = b;
    if (c > max) max = c;

    Console.Write(a);
    Console.Write(", ");
    Console.Write(b);
    Console.Write(", ");
    Console.Write(c);
    Console.Write("  -> ");
    Console.Write("max = ");
    Console.WriteLine(max);
 }

MaxNumber(2, 3, 7);
MaxNumber(44, 5, 78);
MaxNumber(22, 3, 9);

 