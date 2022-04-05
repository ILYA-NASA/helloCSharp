// Задача 1. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// void DoubleRandomArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Math.Round(new Random().NextDouble());
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Укажите количество строк таблицы: ");
// int lines = Convert.ToInt32(Console.ReadLine());
// Console.Write("Укажите количество столбцов таблицы: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] userArray = new double[lines, columns];
// DoubleRandomArray(userArray);

// Задача 2. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int[,] array = new int[,]
{
{ 1, 4, 7, 2 },
{ 5, 9, 2, 3 },
{ 8, 4, 2, 4 },
};

void PrintArray(int[,] existArray)
{
    Console.WriteLine("Таблица: ");
    for (int i = 0; i < existArray.GetLength(0); i++)
    {
        for (int j = 0; j < existArray.GetLength(1); j++)
        {
            Console.Write($"{existArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

// void SearchElementArray(int[,] existArray, int m, int n)
// {
//     m = m - 1;
//     n = n - 1;
//     if (m < existArray.GetLength(0)
//         && n < existArray.GetLength(1)
//         && m >= 0
//         && n >= 0)
//         Console.WriteLine($"Указанный Вами элемент имеет значение: {existArray[m, n]}");
//     else Console.WriteLine("Указанного Вами элемента в таблице нет.");
// }

// PrintArray(array);
// Console.Write("Укажите номер строки элемента таблицы: ");
// int lines = Convert.ToInt32(Console.ReadLine());
// Console.Write("Укажите номер столбца элемента таблицы: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// SearchElementArray(array, lines, columns);

// Задача 3. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ArithmeticMeanColumnsArray(int[,] existArray)
{
    for (int i = 0; i < existArray.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < existArray.GetLength(0); j++)
        {
            sum = sum + existArray[j, i];
        }
        sum = sum / existArray.GetLength(0);
        Console.WriteLine($"Среднее арифметическое столбца №{i + 1} таблицы равняется {sum}");
    }
}

PrintArray(array);
ArithmeticMeanColumnsArray(array);