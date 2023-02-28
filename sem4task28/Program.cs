// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetFactorial(int A)
{
    int result = 1;
    for (int i = 1; i <= A; i++)
    {
        result *= i;
    }
    return result;
}

int num = GetNumber("Введите число A: ");


System.Console.WriteLine($"Произведение чисел от 1 до {num} = {GetFactorial(num)}");