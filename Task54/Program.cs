// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Задача 54");
Console.WriteLine();

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.

//Console.Clear();
//Console.WriteLine(
//    $"Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
//каждой строки двумерного массива."
//);
//Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите количество столбцов, m: ");
int n = InputNumbers("Введите количество строк, n: ");
int range = InputNumbers("Введите диапазон значений: от 1 до ");
Console.WriteLine();

int[,] array = new int[m, n];
CreateArray(array);
PrintMatrix(array);
Console.WriteLine();

Console.WriteLine($"\nОтсортированный массив: ");
Console.WriteLine();
SortRowsDescending(array);
PrintMatrix(array);

void SortRowsDescending(int[,] matrix)
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

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] matrix)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
