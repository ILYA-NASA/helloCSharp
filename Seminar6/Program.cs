// Задача 1
// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.
// A < B + C

// void Triangle(int a, int b, int c)
// {
//     if (a < b + c && b < a + c && c < a + b) Console.WriteLine("The triangle exists.");
//     else Console.WriteLine("The triangle does not exist.");
// }

// Console.WriteLine("Enter the number A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the number B: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the number C: ");
// int numC = Convert.ToInt32(Console.ReadLine());
// Triangle(numA, numB, numC);

// Задача 2
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

void Binary(int num)
{
    string answer = "";
    while (num > 0)
    {
        // answer = Convert.ToString($"{num % 2}{answer}");
        answer = num % 2 + answer;
        num = num / 2;
    }
    Console.Write(answer);
}

Console.WriteLine("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
Binary(num);

// Задача 3
// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

// void Fibonacci(int num)
// {
//     int[] array = new int[num];
//     array[0] = 0;
//     array[1] = 1;
//     Console.Write("0 1 ");
//     for (int i = 2; i < num; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//         Console.Write(array[i] + " ");
//     }
// }

// Console.WriteLine("Enter the number: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// Fibonacci(numN);

// Задача 4
// Напишите программу, которая будет создавать копию заданного двумерного массива 
// с помощью поэлементного копирования.

// int[,] init_array = new int[3, 4];
// for (int i = 0; i < init_array.GetLength(0); i++)
// {
//     for (int j = 0; j < init_array.GetLength(1); j++)
//     {
//         init_array[i, j] = new Random().Next(0, 10);
//         Console.Write(init_array[i, j] + " ");
//     }
//     Console.WriteLine(" ");
// }

// Console.WriteLine("----------------------------------");

// int[,] array_copy = new int[init_array.GetLength(0), init_array.GetLength(1)];
// for (int i = 0; i < array_copy.GetLength(0); i++)
// {
//     for (int j = 0; j < array_copy.GetLength(1); j++)
//     {
//         array_copy[i, j] = init_array[i, j];
//         Console.Write(array_copy[i, j] + " ");
//     }
//     Console.WriteLine(" ");
// }