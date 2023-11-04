// Задача 58.
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void FillMatrixRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

// Метод для вывода двумерного массива (матрицы)
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// Метод для проверки, возможно ли умножения двух матриц matrixA и matrixB
void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int [matrixA.GetLength(0), matrixA.GetLength(1)];
    Console.WriteLine();
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine("It is impossible to multiply.");
    }
    else
    {
    matrixC = MatrixMultiplication(matrixA, matrixB);
    PrintMatrix(matrixC);
    }
}

// Метод для умножения двух матриц matrixA и matrixB. 
int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] resultMatrix = new int [matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return resultMatrix;
}

int[,] firstMatrix = new int[4, 4];
int[,] secondMatrix = new int[4, 4];
Console.WriteLine("MatrixA:");
FillMatrixRandom(firstMatrix);
PrintMatrix(firstMatrix);
Console.WriteLine();
Console.WriteLine("MatrixB:");
FillMatrixRandom(secondMatrix);
PrintMatrix(secondMatrix);
MultiplyIfPossible(firstMatrix, secondMatrix);