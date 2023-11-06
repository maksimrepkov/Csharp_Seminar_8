// Задача № 54.
// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n]; // [кол-во строк, кол-во столбцов]
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки, m = matrix.GetLength(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы, n = matrix.GetLength(1)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t"); 
        }
        Console.WriteLine();
    }
}

// Функция сортировки элементов в строке двумерного массива, по убыванию
void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int[,] array2D = GetMatrix(rows, columns, 0, 10);
PrintMatrix(array2D);
Console.WriteLine();
SortToLower(array2D);
PrintMatrix(array2D);