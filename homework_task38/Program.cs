//  Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.21 7.68 22.11 2 78] -> 76


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

double FindDifference(int[] array)
{
    double result = 0;
    double min = array[0];
    double max = array[0];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
        result = max - min;
    }
    return result;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


// arr[i] = Math.Round(rand.NextDouble() * (maxValue - minValue) + minValue);
//         arr[i] = Math.Round(rand.Next(minValue, maxValue) + rand.NextDouble());

int[] myArray = GenerateArray(5, -100, 100);
PrintArray(myArray);

System.Console.WriteLine(FindDifference(myArray));