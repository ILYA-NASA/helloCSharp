// Задача 1
// Напишите программу, которая принимает на вход число (А) и выдаёт 
// сумму чисел от 1 до А.

int ArythmSum(int A)
{
    int result = 0;
    int i = 1;
    while (i <= A)
    {
        result = result + i;
        i++;
    }
    return result;
}

Console.WriteLine("Введите ваше целое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA < 1) Console.WriteLine("Вы ввели ненатуральное число");
else Console.WriteLine($"Cумма чисел от 1 до {numA} равна {ArythmSum(numA)}");

// Задача 2
// Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.

void Dlinna(int N)
{
    int l = 1;
    while (Math.Abs(N / 10) > 1)
    {
        N = N / 10;
        l++;
    }
    Console.WriteLine("Количество цифр в веденном числе " + l);
}

Dlinna(numA);

// Задача 3
// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.

int Factorial(int N)
{
    int result = 1;
    for (int i = 1; i <= N; i++) result = result * i;
    return result;
}

if (numA < 1) Console.WriteLine("Вы ввели ненатуральное число");
else Console.WriteLine($"Произведение чисел от 1 до {numA} равно {Factorial(numA)}");

// Задача 4
// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

void bitArray()
{
    int[] a = new int[8];

    for (int i = 0; i < 8; i++)
    {
        a[i] = new Random().Next(0, 2);
        Console.Write(a[i] + " ");
    }
}

bitArray();