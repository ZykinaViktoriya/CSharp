// Задача22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
//  -> 1, 4, 9, 16, 25.
// 2 -> 1,4

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i<=N; i++)
{
    System.Console.Write(Math.Pow(i,2) + ",");
}

// int i = 1;
// while(i<=N)
// {
//     System.Console.Write(Math.Pow(i,2) + ",");
//     i++;
// }


