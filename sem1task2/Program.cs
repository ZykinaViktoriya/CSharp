// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

System.Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        System.Console.WriteLine("Понедельник");
        break;
    case 2:
        System.Console.WriteLine("Вторник");
        break;
    case 3:
        System.Console.WriteLine("Среда");
        break;
    case 4:
        System.Console.WriteLine("Четверг");
        break;
    case 5:
        System.Console.WriteLine("Пятница");
        break;
    case 6:
        System.Console.WriteLine("Суббота");
        break;
    case 7:
        System.Console.WriteLine("Воскресенье");
        break;
    default:
        System.Console.WriteLine("Такого дня недели не существует");
        break;

}
// if (number == 1)
// {
//     System.Console.WriteLine("Понедельник");
// }

// else if (number == 2)
// {
//     System.Console.WriteLine("Вторник");
// }

// else if (number == 3)
// {
//     System.Console.WriteLine("Среда");
// }

// else if (number == 4)
// {
//     System.Console.WriteLine("Четверг");
// }

// else if (number == 5)
// {
//     System.Console.WriteLine("Пятница");
// }

// else if (number == 6)
// {
//     System.Console.WriteLine("Суббота");
// }

// else if (number == 7)
// {
//     System.Console.WriteLine("Воскресенье");
// }

// else
// {
//     System.Console.WriteLine("Такого дня недели не существует");
// }
