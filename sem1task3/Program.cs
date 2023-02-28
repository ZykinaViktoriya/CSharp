System.Console.WriteLine("Введите число N ");
 int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

for (int i = -number; i <= number; i++)
{
    System.Console.Write(i + " ");
}