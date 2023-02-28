// Задачаа 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string stringnumber = Convert.ToString(number);

if (number > 100)
{
    Console.WriteLine(stringnumber[2]);
}
else if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}