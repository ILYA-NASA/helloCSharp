// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// void FillArray(int[] newArray)
// {
//     Console.Write("Массив: ");
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = new Random().Next(100, 1000);
//         Console.Write($"{newArray[i]} ");
//     }
//     Console.WriteLine();

//     int count = 0;
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         if (newArray[i] % 2 == 0) count++;
//     }
//     if (count > 0) Console.WriteLine($"Количество чётных чисел в массиве: {count}");
//     else Console.WriteLine("В массиве нет четных чисел"); 
// }

// int[] array = new int[5];
// FillArray(array);

// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void FillArray(int[] newArray)
// {
//     Console.Write("Массив: ");
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = new Random().Next(-99, 100);
//         Console.Write($"{newArray[i]} ");
//     }
//     Console.WriteLine();

//     int sum = newArray[1];
//     for (int i = 3; i < newArray.Length; i = i + 2)
//     {
//         sum = sum + newArray[i];
//     }
//     Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях массива равна {sum}");
// }

// int[] array = new int[10];
// FillArray(array);

// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива. НЕ РЕШИЛ ПОКА
// [3 7 22 2 78] -> 76

void FillArray(double[] newArray)
{
    Console.Write("Массив: ");
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(-99, 100);
        Console.Write($"{newArray[i]} ");
    }
    Console.WriteLine();

    double max = newArray[0];
    double min = newArray[0];
    for (int i = 0; i < newArray.Length; i++)
    {
        if(newArray[i] > max) max = newArray[i];
        if(newArray[i] < min) min = newArray[i];
    }
    Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементами массива равна {max - min}");
}

double[] array = new double[10];
FillArray(array);