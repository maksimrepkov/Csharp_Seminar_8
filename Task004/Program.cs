// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Метод для заполнения трехмерного массива неповторяющимися двузначными целыми числами
void Fill3DMatrixRandom(int[,,] matrix)
{

    int number = 10;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // while (number < 100)
        // {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    matrix[i, j, k] = number;
                    number++;
                }

            }
        // }
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

// // Метод для проверки, возможно ли умножения двух матриц matrixA и matrixB
// void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
// {
//     int[,] matrixC = new int [matrixA.GetLength(0), matrixA.GetLength(1)];
//     Console.WriteLine();
//     if (matrixA.GetLength(1) != matrixB.GetLength(0))
//     {
//         Console.WriteLine("It is impossible to multiply.");
//     }
//     else
//     {
//     matrixC = MatrixMultiplication(matrixA, matrixB);
//     PrintMatrix(matrixC);
//     }
// }

// // Метод для умножения двух матриц matrixA и matrixB. 
// int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
// {
//     int[,] resultMatrix = new int [matrixA.GetLength(0), matrixB.GetLength(1)];
//     for (int i = 0; i < matrixA.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixB.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrixA.GetLength(1); k++)
//             {
//                 resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
//             }
//         }
//     }
//     return resultMatrix;
// }

int[,,] my3DMatrix = new int[5, 5, 5];
// int[,] secondMatrix = new int[4, 4];
Console.WriteLine("my3DMatrix:");
Fill3DMatrixRandom(my3DMatrix);
PrintMatrix(my3DMatrix);
// Console.WriteLine();
// Console.WriteLine("MatrixB:");
// FillMatrixRandom(secondMatrix);
// PrintMatrix(secondMatrix);
// MultiplyIfPossible(firstMatrix, secondMatrix);
