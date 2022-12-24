// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается
// элемент входных данных.

var matrix = FillMatrix(4, 4);
PrintMatrix(matrix);

int[] arrNums = new int[matrix.GetLength(0) * matrix.GetLength(1)];
int arrNumsTrueLength = 0;

GetFrequencyDictionary(matrix);
PrintCount(matrix);

void PrintCount(int[,] arr)
{
    for(int i = 0; i < arrNumsTrueLength; i++)
    {
        System.Console.WriteLine($"{arrNums[i]} встречается {GetCount(arr, arrNums[i])}");
    }
}

int GetCount(int[,] arr, int element)
{
    int count = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        { 
            if(matrix[i, j] == element)
            {
                count++;
            }
        }
    } 
    return count;
}

void GetFrequencyDictionary(int[,] matrix)
{
   
   for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        { 
            CheckContain(matrix[i, j]);
        }
    } 
}

void CheckContain(int element)
{
    for(int i = 0; i <= arrNumsTrueLength; i++)
    {
        if(element == arrNums[i])
        {
            return;
        }
    }
    arrNums[arrNumsTrueLength] = element;
    arrNumsTrueLength++;
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