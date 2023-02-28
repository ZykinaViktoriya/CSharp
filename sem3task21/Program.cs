﻿// Задача21.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

//((x2 - x1)^2 + (y2 - y1)^2)^0.5;
// Math.Pow(x,y)
// Math.Sqrt(x)


System.Console.WriteLine("Введите координаты точки x1:");
int x1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки y1:");
int y1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2)),3));