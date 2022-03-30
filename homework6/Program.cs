// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// void MoreZero(int number)
// {
//     int count = 0;
//     for (int i = 1; i <= number; i++)
//     {
//         Console.Write($"Введите {i} число: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         if (num > 0) count++;
//     }
//     Console.WriteLine($"Число введенных Вами натуральных чисел: {count}.");
// }

// Console.Write("Укажите сколько чисел Вы хотите ввести: ");
// int volume = Convert.ToInt32(Console.ReadLine());
// MoreZero(volume);

// Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. 
// Вывести массив в виде матрицы, создав "рамку" из единиц, 
// а внутреннюю зону матрицы заполнить нулями.
// 3, 4 ->
// 1 1 1 1
// 1 0 0 1
// 1 1 1 1

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0 || i == array.GetLength(0) - 1 || j == 0 || j == array.GetLength(1) - 1) array[i, j] = 1;
            else array[i, j] = 0;
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Укажите количество строк таблицы: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов таблицы: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] userArray = new int[lines, columns];
PrintArray(userArray);