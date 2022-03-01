/*
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());//456, 782, 918 

int SecNum(int num)
{
    int n1 = num % 10;
    int n2 = num / 100 * 100;
    return (num - n2 - n1) / 10;
}

Console.WriteLine("Current number is " + number + ", Second Number is " + SecNum(number));
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите целое число: "); //645, 78, 32679
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 99 && number >= -99)
{
    Console.WriteLine("Tретьей цифры нет");
}
else
{
    if (number <= 999 && number >= -999)
    {
        int ThirdNum = number % 10;
        Console.WriteLine("Current number is " + number + ", Third Number is " + ThirdNum);
    }
    if (number <= 9999 && number >= -9999)
    {
        int ThirdNum1 = number / 10;
        int ThirdNum2 = ThirdNum1 % 10;
        Console.WriteLine("Current number is " + number + ", Third Number is " + ThirdNum2);
    }
    if (number <= 99999 && number >= -99999)
    {
        int ThirdNum1 = number / 100;
        int ThirdNum2 = ThirdNum1 % 10;
        Console.WriteLine("Current number is " + number + ", Third Number is " + ThirdNum2);
    }
}



