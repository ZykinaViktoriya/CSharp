﻿// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

System.Console.WriteLine("Введите число: ");
int Fibonacci1 = 0;
int Fibonacci2 = 1;
int FibonacciN;
int n = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("0 1 ");

for(int i =0; i<n-2; i++)
{
    int sum = Fibonacci1 + Fibonacci2;
    System.Console.Write(sum + " ");
    Fibonacci1 = Fibonacci2;
    Fibonacci2 = sum;
}