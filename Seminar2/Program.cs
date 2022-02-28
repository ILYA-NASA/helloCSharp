/*
//Задача 1
int FindMaxNum(int num)
{
    int n1 = num % 10;
    int n2 = num / 10;

    if (n1 > n2)
    {
        return n1;
    }
    else
    {
        return n2;
    }
}

int number = new Random().Next(10, 99);
Console.WriteLine("Current number is " + number + "max part is " + FindMaxNum(number));
*/

/*
//Задача 2. 
//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int number = new Random().Next(100, 999);
int Num(int num)
{
    int n1 = num % 10;
    int n2 = num / 100;
    return n2 * 10 + n1 * 1;
}

Console.WriteLine("Current number is " + number + "Num" + Num(number));

*/

/*
//Задача 3.
//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деление.
void Chastnoe(int num1, int num2)
    {
        if(num1 % num2 == 0)
        {
            Console.WriteLine("Yes!");
        }
        else
        {
            Console.WriteLine(num1 % num2);
        }
    }
*/

//Задача 4.
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.Write("Введите целое число для проверки кратности: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое целое число, на которое проверяем: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число, на которое проверяем: ");
int num3 = Convert.ToInt32(Console.ReadLine());


    if(num1 % num2 == 0 && num1 % num3 == 0)
    {
        Console.Write("Да, кратно");
    }
    else 
    {
        Console.WriteLine("Нет, не кратно");
    }
