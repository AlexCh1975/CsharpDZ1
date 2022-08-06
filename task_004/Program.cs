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
    int[] arr = {a, b, c};
    int max = arr[0];
    for (int i = 0; i < 3; i++)
    {
         if (arr[i] > max) 
        {
            max = arr[i];
        } 
    }
   
    Console.WriteLine($"{a}, {b}, {c} max -> {max}");
 }

MaxNumber(2, 3, 7);
MaxNumber(44, 5, 78);
MaxNumber(22, 3, 9);

 