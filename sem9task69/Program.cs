﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


System.Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"A = {a}; B = {b}; -> {GetResult(a, b)}");

int GetResult(int a, int b)
{
    if (b == 1)
        return a;
    b--;
    return a * GetResult(a, b);
}
