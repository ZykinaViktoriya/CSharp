// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

metka:
System.Console.WriteLine("Введите 3 числа: ");

int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); //преобразование введенной строки в массив
if(array.Length!= 3)
{
    System.Console.WriteLine("Массив введен не корректно");
    goto metka;
}
if ((array[0] + array[1]) > array[2] && (array[1] + array[2]) > array[0] && (array[0] + array[2]) > array[1])
{
    System.Console.WriteLine("Такой треугольник существует");
}
else 
{
    System.Console.WriteLine("Такой треугольник не существует");
}