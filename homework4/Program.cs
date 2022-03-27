// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// void degree(int A, int B)
// {
//     // int count = 0;
//     int result = A;
//     for (int count = 1; count < Math.Abs(B); count++)
//     {
//         result = result * A;
//     }
//     Console.WriteLine($"Если {A} возведем в степень {B}, то получим {result}");
// }

// Console.WriteLine("Введите целое число (кроме 0): ");
// int numA = Convert.ToInt32(Console.ReadLine());
// if (numA == 0) Console.WriteLine("ЗДЕСЬ НЕ НУЖНО ВВОДИТЬ 0! Попробуйте еще раз, когда захотите следовать инструкциям.");
// else
// {
//     Console.WriteLine("Введите второе целое число (кроме 0): ");
//     int numВ = Convert.ToInt32(Console.ReadLine());
//     if (numВ == 0) Console.WriteLine("ЗДЕСЬ НЕ НУЖНО ВВОДИТЬ 0! Попробуйте еще раз, когда захотите следовать инструкциям.");
//     else degree(numA, numВ);
// }

// Задача 2: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// void SumDigit(int n) // пока не разобрался как применить while true и break
// {
//     if (Math.Abs(n / 10) != 0)
//     {
//         while (true)
//         {
//             while (Math.Abs(n / 10) != 0)
//             {
//                 int i = n % 10;
//                 n = (n - i) / 10;
//                 i = i + n % 10;
//                 Console.WriteLine(i);
//             }
//             break;
//         }
//     }
//     else Console.WriteLine("Сумму чисел посчитать невозможно.");
// }

// Console.WriteLine("Введите число: ");
// int Num = Convert.ToInt32(Console.ReadLine());
// SumDigit(Num);

// Задача 3: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] newArray)
{
    Console.Write("Массив: ");
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(1, 19);
        Console.Write($"{newArray[i]}, ");
    }
}

int[] array = new int[8];
FillArray(array);