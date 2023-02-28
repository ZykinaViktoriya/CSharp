// Задача18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


System.Console.WriteLine("Введите координату x:");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0)
{
    System.Console.WriteLine("Первая четверть");
}
else if (x<0 && y>0)
{
    System.Console.WriteLine("Вторая четверть");
}
else if (x<0 && y<0)
{
    System.Console.WriteLine("Третья четверть");
}
else if (x>0 && y<0)
{
    System.Console.WriteLine("Четвертая четверть");
}


// System.Console.WriteLine("Введите номер четверти:");
// int q = Convert.ToInt32(Console.ReadLine());

// if (q == 1)
// {
//     System.Console.WriteLine("x > 0 && y > 0");
// }
// else if (q == 2)
// {
//     System.Console.WriteLine("x < 0 && y > 0");
// }
// else if (q == 3)
// {
//     System.Console.WriteLine("x < 0 && y < 0");
// }
// else if (q == 4)
// {
//     System.Console.WriteLine("x > 0 && y < 0");
// }
// else
// {
//     System.Console.WriteLine("Такой четверти нет");
// }