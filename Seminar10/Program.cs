// Задача 1.
// Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих.

// int Fibonacci(int n1, int n2, int N)
// {
//     if (N == 1) return n1;
//     if (N == 2) return n2;
//     else return Fibonacci(n1, n2, N - 1) + Fibonacci(n1, n2, N - 2);
// }

// Console.WriteLine("Введите количество чисел для проверки: ");
// int size = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= size; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(0, 1, i)}");
// }

// Задача 2.
// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из N букв, которые можно построить из букв этого алфавита.

void PrintWords(string alf, int lengthWord, string currentWord)
{
    if (lengthWord == 0) Console.WriteLine(currentWord);
    else
    {
        for (int i = 0; i < alf.Length; i++)
        {
            PrintWords(alf, lengthWord - 1, currentWord + alf[i]);
        }
    }
}

// PrintWords("helo", 3, String.Empty);

// Задача 3.
// Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). 
// В массиве data хранится информация о количестве бит, которые занимают числа из массива info. 
// Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

// Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7); 
// третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)

// Пример:
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }
// выходные данные:
// 1, 7, 0, 1

int[] BinaryTransformArray(int[] dateArray, int[] infoArray)
{
    int[] resultArray = new int[infoArray.Length];
    int binPos = 0;
    for (int pos = 0; pos < infoArray.Length; pos++)
    {
        int num = 0,
            pow = 0;
        for (int i = infoArray[pos] - 1; i >= 0; i--)
        {
            num += dateArray[binPos + i] * (int)Math.Pow(2, pow);
            pow++;
        }
        binPos += infoArray[pos];
        resultArray[pos] = num;
    }
    return resultArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 },
        info = { 2, 3, 3, 1 };
PrintArray(BinaryTransformArray(data, info));