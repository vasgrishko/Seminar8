// Задача 53: Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.

var arr = FillMatrix(3,4);
PrintMatrix(arr);
ChangeRows(arr);
Console.WriteLine();
PrintMatrix(arr);

void ChangeRows(int[,] matrix)
{
   int rowCount = matrix.GetLength(0) - 1;
   for(int i = 0; i < matrix.GetLength(1); i++)
    {
       int temp = matrix[0,i];
       matrix[0,i] = matrix[rowCount,i];
       matrix[rowCount,i] = temp;
    } 
}

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        { 
            matrix[i,j] = rnd.Next(1, 100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}