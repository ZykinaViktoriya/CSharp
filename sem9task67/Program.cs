// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

System.Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Sum(m));

int Sum(int num)
{
    if(num==0)
    {
        return 0;
    }
    return num%10 + Sum(num/10);
}