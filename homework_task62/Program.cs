// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    //Наружный контур
    int s = 01;
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < cols; i++)
    {
        matrix[0, i] = s;
        s++;
    }
    for (int j = 1; j < rows; j++)
    {
        matrix[j, cols - 1] = s;
        s++;
    }
    for (int i = cols - 2; i >= 0; i--)
    {
        matrix[rows - 1, i] = s;
        s++;
    }
    for (int j = rows - 2; j > 0; j--)
    {
        matrix[j, 0] = s;
        s++;
    }
    //Внутренний контур
    int c = 1;
    int d = 1;

    while (s < rows * cols)
    {
        while (matrix[c, d + 1] == 0)  //Движемся вправо.
        {
            matrix[c, d] = s;
            s++;
            d++;
        }

        while (matrix[c + 1, d] == 0)   //Движемся вниз.
        {
            matrix[c, d] = s;
            s++;
            c++;
        }

        while (matrix[c, d - 1] == 0)   //Движемся влево.
        {
            matrix[c, d] = s;
            s++;
            d--;
        }

        while (matrix[c - 1, d] == 0)   //Движемся вверх.
        {
            matrix[c, d] = s;
            s++;
            c--;
        }
    }

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (matrix[i, j] == 0)
            {
                matrix[i, j] = s;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");

var newMatrix = GenerateMatrix(rows, cols);
PrintMatrix(newMatrix);
