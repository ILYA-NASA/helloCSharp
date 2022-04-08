// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.Clear();

int[,] CreateRandomMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}

int[,] SortWaneMatrix(int[,] matrix)
{
    int min,
        temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            min = j;
            for (int k = j; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] < matrix[i, min]) min = k;
            }
            temp = matrix[i, j];
            matrix[i, j] = matrix[i, min];
            matrix[i, min] = temp;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

// int[,] array = CreateRandomMatrix(5, 5);
// PrintMatrix(SortWaneMatrix(array));

// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void MinSumRowMatrix(int[,] matrix)
{
    int sumRow = 0,
        minSumRow = 0,
        numMinSumRow = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
        minSumRow += matrix[0, j];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            sumRow += matrix[i, j];
        if (sumRow < minSumRow)
        {
            minSumRow = sumRow;
            numMinSumRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов таблицы: {numMinSumRow + 1}");
}

// int[,] array = CreateRandomMatrix(5, 2);
// MinSumRowMatrix(array);

// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 75(0,1,0) 31(0,1,1)
// 45(1,0,0) 53(1,0,1)
// 32(1,1,0) 23(1,1,1)

int[,,] userArray = new int[,,]
{
    {
        {12, 22},
        {75, 31},
    },
    {
        {45, 53},
        {32, 23},
    }
};

int[,,] CreateRandomArray3D(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                // Console.Write($"{array3D[i, j, k]} ");
            }
            // Console.WriteLine();
        }
        // Console.WriteLine();
    }
    // Console.WriteLine();
    return array3D;
}

void PrintStringsArray3D(int[,,] array)
{
    Console.WriteLine($"Массив размером: {array.GetLength(0)} x {array.GetLength(1)} x {array.GetLength(2)}");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        // Console.WriteLine();
    }
    Console.WriteLine();
}

PrintStringsArray3D(CreateRandomArray3D(userArray));

// Задача 4: Заполните спирально массив 4 на 4.
// На выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

