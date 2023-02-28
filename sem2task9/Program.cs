//Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Random rand = new Random();
int number = rand.Next(10, 100);
System.Console.WriteLine(number);

int leftNumber = number / 10;
int rightNumber = number % 10;

//System.Console.WriteLine($"{leftNumber} {rightNumber}");

if (leftNumber > rightNumber)
{
    System.Console.WriteLine($"Левое число больше и равно { leftNumber}");
}
else if (leftNumber < rightNumber)
{
    System.Console.WriteLine($"Правое число больше и равно {rightNumber}");
}
else
{
    System.Console.WriteLine("Числа равны");
}