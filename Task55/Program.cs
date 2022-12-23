// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

int[,] arr = FillMatrix(3,3);
PrintMatrix(arr);
var result = ChangeRows(arr);
System.Console.WriteLine();
PrintMatrix(result);

int[,] ChangeRows(int[,] matrix)
{
   int rows = matrix.GetLength(0);
   int columns = matrix.GetLength(1);
   if(rows != columns)
   {
        return null;
   }
   int[,] result = new int[rows, columns];
   for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result[j, i] = matrix[i, j];
        }
    }
    return result;
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