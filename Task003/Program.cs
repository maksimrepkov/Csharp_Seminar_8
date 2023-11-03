// Задача 58.
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] firstMatrix = new int[3, 4];
int[,] secondMatrix = new int[3, 4];
FillArrayRandom(firstMatrix);
PrintArray(firstMatrix);
Console.WriteLine();
FillArrayRandom(secondMatrix);
PrintArray(secondMatrix);