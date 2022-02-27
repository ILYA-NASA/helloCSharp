/*
//Задача №1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите первое целое число: ");
int value_a = Convert.ToInt32(Console.ReadLine());//5, 2, -9
Console.WriteLine("Введите второе целое число: ");
int value_b = Convert.ToInt32(Console.ReadLine());//7,10, -3

if (value_a > value_b)
{
    Console.Write("max = ");
    Console.WriteLine(value_a);
    Console.Write("min = ");
    Console.Write(value_b);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(value_b);
    Console.Write("min = ");
    Console.Write(value_a);
}
*/

//Задача 2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое целое число: ");
int value_a = Convert.ToInt32(Console.ReadLine());//2, 44, 22
Console.WriteLine("Введите второе целое число: ");
int value_b = Convert.ToInt32(Console.ReadLine());//3, 5, 3
Console.WriteLine("Введите третье целое число: ");
int value_c = Convert.ToInt32(Console.ReadLine());//7, 78, 9

int max = value_a;

if (value_a > max) max = value_a;
if (value_b > max) max = value_b;
if (value_c > max) max = value_c;

Console.Write("max = ");
Console.WriteLine(max);