// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите номер дня недели от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
{
    System.Console.WriteLine("Введено неверное число");
}
else if (day > 5)
{
    System.Console.WriteLine("да");
}
else if (day < 5)
{
    System.Console.WriteLine("нет");
}
