// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

void FindQuarter(int a, int b)
{
    if (a > 0 && b > 0)
    {
        System.Console.WriteLine("Первая четверть");
    }
    else if (a < 0 && b > 0)
    {
        System.Console.WriteLine("Вторая четверть");
    }
    else if (a < 0 && b < 0)
    {
        System.Console.WriteLine("Третья четверть");
    }
    else if (a > 0 && b < 0)
    {
        System.Console.WriteLine("Четвертая четверть");
    }
}


// int x = InputNumber("Введите координату x: ");

// int y = InputNumber("Введите координату y: ");

// FindQuarter(x, y);


FindQuarter(InputNumber("Введите координату x: "), InputNumber("Введите координаату y: "));