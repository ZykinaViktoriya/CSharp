//  Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());


double getNumberX(double b1, double k1, double b2, double k2)
{
    double X = 0;
    X = (b2-b1)/(k1-k2);
    return X;
}

double getNumberY(double b1, double k1,double b2, double k2, double X)
{
    double Y = 0;
        Y = k1*X+b1;
    return Y;
}

double NumberX = getNumberX(b1, k1, b2, k2);
double NumberY = getNumberY(b1, k1, b2, k2, NumberX);
Console.Write($"Точка пересечения двух прямых ({NumberX};{NumberY})");