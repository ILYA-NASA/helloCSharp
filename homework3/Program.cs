/*
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

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;
    double zDistance = z2 - z1;

    return Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2) + Math.Pow(zDistance, 2));
}

double xA, yA, zA, xB, yB, zB;
double distance;

Console.Write("input X of point A: "); //3,7
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("input Y of point A: "); //6,-5
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("input Z of point A: "); //8,0
zA = Convert.ToDouble(Console.ReadLine());

Console.Write("input X of point B: "); //2,1
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("input Y of point B: "); //1,-1
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("input Z of point B: "); //-7,9
zB = Convert.ToDouble(Console.ReadLine());

distance = GetDistance(xA, yA, zA, xB, yB, zB);
Console.WriteLine(distance);
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

void TableCubes(int num)
{    
    for (int i = 1; i <= num; i++)
    {
       Console.WriteLine(i * i * i); 
    }
}

Console.Write("Enter an integer: "); //3,5
int number = Convert.ToInt32(Console.ReadLine());
TableCubes(number);