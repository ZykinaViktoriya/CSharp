//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(minValue, maxValue + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int[] Copy(int[] array)
{
    int[] array2 = new int[array.Length];
    for(int i = 0; i<array.Length; i++)
    {
        array2[i] = array[i];
    }
    return array2;

}
int[] arr = GenerateArray(5, 0, 100);
PrintArray(arr);
int[] arrCopy = Copy(arr);
PrintArray(arrCopy);


//int[] arrCopy = arr[..]; // Копирование массива одной строкой с разным выделением памяти
//int[] arrCopy2 = arr; // Копирование массива с одними и теми же ячейками памяти