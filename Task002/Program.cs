// Задача 56.
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Функция заполнения массива рандомно числами от 1 до 9
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Функция вывода двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int SumOfRow(int[,] matrix, int row)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[row, j];
    }
    return sum;
}

int[] MinimumSumRow(int[,] matrix)
{
    int minSum = SumOfRow(matrix, 0);
    int minRow = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = SumOfRow(matrix, i);
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }
    return new int[] { minRow, minSum };
}

int[,] my2DArray = new int[3, 4];
FillArrayRandom(my2DArray);
PrintArray(my2DArray);
MinimumSumRow(my2DArray);
Console.WriteLine();
int[] myArray = new int[2];
myArray = MinimumSumRow(my2DArray);
Console.WriteLine($"{string.Join(", ", myArray)}");