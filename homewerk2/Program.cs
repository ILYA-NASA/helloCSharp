/*Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.*/

Console.WriteLine("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());//456, 782, 918 

int SecNum(int num)
{
    int n1 = num % 10;
    int n2 = num / 100 * 100;
    return (num - n2 - n1) / 10;
}

Console.WriteLine("Current number is " + number + ", Second Number is " + SecNum(number));
