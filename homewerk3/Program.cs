//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

void Palindrom(int Number1)
{
    int a1 = Number1 % 10;
    int a2 = Number1 / 10 % 10;
    int a3 = Number1 / 100 % 10;
    int a4 = Number1 / 1000 % 10;
    int a5 = Number1 / 10000;
    int Number2 = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5; 
    if (Number1 == Number2)Console.WriteLine("Число является палиндромом.");
    else Console.WriteLine("Число не является палиндромом.");
}

int FiveDNumber;
Console.WriteLine("Введите пятизначное число: "); //14212, 12821, 23432
FiveDNumber = Convert.ToInt32(Console.ReadLine());
Palindrom(FiveDNumber);