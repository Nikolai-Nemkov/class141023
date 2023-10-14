// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Задача 53:
// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.



int[,]  CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
        
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j], 6}");
        }
        Console.WriteLine("    |");
    }
}
// // 7 8 9
//    4 5 6
//    1 2 3
void ReplaceFirstLastRow(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[0,j];// 3
        matrix[0,j] = matrix[matrix.GetLength(0) - 1, j];//9
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
ReplaceFirstLastRow(array2d);
PrintMatrix(array2d);
