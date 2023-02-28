// Задача 11. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100,1000);
// System.Console.WriteLine("Случайное число:" + number);

// int leftNumber = number / 100;
// int rightNumber = number % 10;
// System.Console.WriteLine($"{leftNumber}{rightNumber}");

int number = new Random().Next(100,1000);
System.Console.WriteLine("Случайное число:" + number);

int leftNumber = number / 100;
int rightNumber = number % 10;
System.Console.WriteLine($"{leftNumber}{rightNumber}");

number = ((number/100)*10) + (number%10); //сохранили значение в переменной