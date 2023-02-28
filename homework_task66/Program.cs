// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int SumNumbers(int a, int b)
{
    if (b > a)
    {
        return b + SumNumbers(a, b - 1);
    }
    return a;
}

int m = ReadInt("Введите значение M: ");
int n = ReadInt("Введите значение N: ");
System.Console.WriteLine($"M = {m}; N = {n}; -> {SumNumbers(m, n)}");