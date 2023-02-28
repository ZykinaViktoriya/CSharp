// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


System.Console.Write("Введите первое число: A = ");
int A = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: B = ");
int B = Convert.ToInt32(Console.ReadLine());

if (A > B)
{
    System.Console.WriteLine("max = " + A);
}
else
{
    System.Console.WriteLine("max = " + B);
}
