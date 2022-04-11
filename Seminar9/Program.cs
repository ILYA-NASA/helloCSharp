// Задача 1.
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

void CrossPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = x * k1 + b1;
    Console.WriteLine("Точка пересечения заданных прямых имеет координаты: (" + x + ";" + y + ")");
}

// CrossPoint(2, 5, 4, 9);

// Задача 2.
// Показать треугольник Паскаля. 
// Сделать вывод в виде равнобедренного треугольника.

int[,] TrianglePascal(int n)
{
    int[,] matrix = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        matrix[i, 0] = 1;
        matrix[i, i] = 1;
    }
    for (int j = 2; j < n; j++)
    {
        for (int k = 1; k < n; k++)
        {
            matrix[j, k] = matrix[j - 1, k - 1] + matrix[j - 1, k];
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j]} ");
        Console.WriteLine();
    }
}

PrintMatrix(TrianglePascal(7)); // треуголник всегда равнобедренный
// TODO: прописать метод, где вместо нулей пробелы и вершина треугольника по центру 