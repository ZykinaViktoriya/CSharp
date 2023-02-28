// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(",", array) + "]");
}
//1й вариант
// int SumNegative(int[] array)
// {
// int result = 0;
//     for(int i = 0; i<array.Length; i++)
//     {
//         if(array[i]<0)
//         {
//             result+=array[i];
//         }
//     }
//     return result;
// }


//2й вариант
// int[] sumNegativeAndPositive(int[] array)
// {
//     int[] result = new int[2];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//             result[0] += array[i];
//         }
//         else
//         {
//             result[1] += array[i];
//         }
//     }
//     return result;
// }


//3й вариант
void sumNegativeAndPositive(int[] array, out int SumPositive, out int SumNegative)
{
    SumNegative = 0;
    SumPositive = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            SumNegative += array[i];
        }
        else
        {
            SumPositive += array[i];
        }
    }
}


int[] myArray = GenerateArray(5, -9, 9);
PrintArray(myArray);
sumNegativeAndPositive(myArray, out int SumPositive, out int SumNegative);

//1й вариант
// System.Console.WriteLine($"Сумма отрицательных элементов равна{SumNegative(myArray)}");
// System.Console.WriteLine($"Сумма положительных элементов равна{SumPositive(myArray)}");

//2й вариант
// System.Console.WriteLine($"Сумма отрицательных элементов равна{sums[0]}");
// System.Console.WriteLine($"Сумма отрицательных элементов равна{sums[1]}");

//3й вариант
System.Console.WriteLine($"Сумма отрицательных элементов равна{SumNegative}");
System.Console.WriteLine($"Сумма отрицательных элементов равна{SumPositive}");