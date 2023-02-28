// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

string InputNumber(string text)
{
    System.Console.WriteLine(text);
    return Console.ReadLine();
}


string a = InputNumber("Введите число N: ");
int length = a.Length;

System.Console.WriteLine(length);
