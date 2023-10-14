// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 53:
// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.






















// Задача 46 Задайте двумерный массив размером m x n,
// заполненный случайными целыми числами
// m = 6, n = 8.
//    Пример

//  i     0  1  2  3

//  0     1  4  8  19
//  1     5 -2 33  -2
//  2    77  3  8   1

// CОЗДАНИЕ МАТРИЦЫ ДВУ МЕРНОГО МАССИВА заполненного 0 - ми

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)  // Great - большой
{
    //                        0       1
    int[,] matrix = new int[rows, columns];  // rows = 3 - строка columns = 4 - столбец
    Random rnd = new Random();   // создаем объект Random

                            // GetLength - переводится как "получить длину"

    for (int i = 0; i < matrix.GetLength(0); i++)  // строка всегда начинается от 0 элемента. GetLength - получить длину массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // столбец от элемента 1
        {
            matrix[i, j] = rnd.Next(min, max + 1);  //  matrix[i, j] - адрес ячейки присваеваем ей значение случайного числа.
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5}");  // 5 это отступ, ради форматирования, можно любую цифру.
        }
        Console.WriteLine("  ]");
    }
}

int[,] array2d = CreateMatrixRndInt(6, 8, -10,  10);
PrintMatrix(array2d);
Console.WriteLine();

