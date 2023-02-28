// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] arr = new int[8];
// var rand = new Random();
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i]= rand.Next(0,2);
//     System.Console.Write($"{arr[i]} ");
// }


int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < 8; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("["+string.Join(" ", array)+"]");
}

int[] MyArray = FillArray(8);
PrintArray(MyArray);


// void GetArray(int[] arr)
// {
// var rand = new Random();
// for (int i = 0; i < arr.Length; i++)
// {
// arr[i] = rand.Next(0, 2);
// }
// }

// void PrintArray(int[] arr)
// {
// System.Console.WriteLine("["+string.Join(", ", arr)+"]");
// }

// int[] myArray = new int[8];
// GetArray(myArray);
// PrintArray(myArray);