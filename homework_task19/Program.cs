// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число N: ");
string? N = Console.ReadLine();

if (N!.Length == 5)
{
    if (N[0] == N[4] && N[1] == N[3])
    {
        System.Console.WriteLine("Да, это палиндром");
    }
    else
    {
        System.Console.WriteLine("Нет, это не палиндром");
    }
}
else
{
    System.Console.WriteLine("Введено неверное число");
}