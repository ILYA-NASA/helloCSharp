// 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

// void FillArray(int[] newArray)
// {
//     Console.Write("Массив: ");
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = new Random().Next(-9, 10);
//         Console.Write($"{newArray[i]} ");
//     }    
//     Console.WriteLine();
//     int sumPos = 0;
//     int sumNeg = 0;
//     for (int a = 0; a < newArray.Length; a++)
//     {
//         if(newArray[a] >= 0) sumPos += newArray[a]; 
//         else sumNeg += newArray[a];
//         //   sumNeg =  sumNeg + newArray[i];
//     }
//     Console.WriteLine($"Сумма отрицательных числ в массиве равна {sumNeg}. Сумма положительных чисел равна {sumPos}");
// }

// int[] array = new int[12];
// FillArray(array);


// 2. Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

// void FillArray(int[] newArray)
// {
//     Console.Write("Массив: ");
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = new Random().Next(-99, 100);
//         Console.Write($"{newArray[i]} ");
//     }
//     Console.WriteLine();

//     Console.Write("Новый массив: ");
//     for (int a = 0; a < newArray.Length; a++)
//     {
//         // newArray[a] = newArray[a] * -1;
//         newArray[a] *= -1;
//         Console.Write($"{newArray[a]} ");
//     }
// }

// int[] array = new int[12];
// FillArray(array);

// 3. Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// void FillArray(int[] newArray)
// {
//     Console.Write("Массив: ");
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = new Random().Next(-99, 100);
//         Console.Write($"{newArray[i]} ");
//     }
//     Console.WriteLine();

//     Console.Write("Введите число ");
//     int numUser = Convert.ToInt32(Console.ReadLine());
//     int count = 0;
//     for (int a = 0; a < newArray.Length; a++)
//     {
//         if (newArray[a] == numUser) count++;
//     }
//     if (count > 0) Console.WriteLine("Введенное Вами число является элементом массива ");
//     else Console.WriteLine("Введенное Вами число не является элементов массива "); 
// }

// int[] array = new int[12];
// FillArray(array);

// 4. Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// void FillArray(int[] newArray)
// {
//     Console.Write("Массив: ");
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = new Random().Next(-99, 100);
//         Console.Write($"{newArray[i]} ");
//     }
//     Console.WriteLine();

//     int count = 0;
//     for (int a = 0; a < newArray.Length; a++)
//     {
//         if (newArray[a] > 9 && newArray[a] < 100) count++;
//     }
//     Console.WriteLine($"В диапозоне от 10 до 99 в заданном массиве найдено {count} элементов. ");
// }

// int[] array = new int[123];
// FillArray(array);

// 5. Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

void FillArray(int[] newArray)
{
    Console.Write("Массив: ");
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(1, 10);
        Console.Write($"{newArray[i]} ");
    }
    Console.WriteLine();

    int[] nextArray = new int[6]; 
    int z = 0;
    for (int a = 0; a < nextArray.Length; a++)
    {
        nextArray[a] = newArray[z] * 10 + newArray[^z];
        z++; 
        Console.Write($"{nextArray[a]} ");
    } 
}

int[] array = new int[12];
FillArray(array);
