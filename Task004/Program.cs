// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Метод для заполнения трехмерного массива неповторяющимися двузначными целыми числами
void Fill3DMatrixRandom(int[,,] matrix)
{

    int number = 10;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = number;
                number++;
            }

        }
      
    }
}

// Метод для вывода двумерного массива (матрицы)
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.WriteLine($"[{i}, {j}, {k}] = {matrix[i, j, k]}\t");
            }
        }
    }
    Console.WriteLine();
}

int[,,] my3DMatrix = new int[5, 5, 5];
Console.WriteLine("my3DMatrix:");
Fill3DMatrixRandom(my3DMatrix);
PrintMatrix(my3DMatrix);