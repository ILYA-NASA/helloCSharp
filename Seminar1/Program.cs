/*
//2 задача

Console.WriteLine("Введите первое целое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int value2 = Convert.ToInt32(Console.ReadLine());

int kvadrat_value2 = value2 * value2;

if(kvadrat_value2 == value1)
{
    Console.WriteLine("Квадрат второго числа сооветствует первому");
}
else
{
    Console.WriteLine("Искомых соответствийне не выявлено");
}
*/

/*
// 3 задача

Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number <= 7 && number >= 1)
{
    if(number == 1)
    {
        Console.WriteLine("Понедельник");
    }
        if(number == 2)
    {
        Console.WriteLine("Вторник");
    }

}
else
{
    Console.WriteLine("Такого дня недели не существует");
}
*/

//4 задача

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int neg_n = n*(-1);

while(neg_n <= n)
{
    Console.WriteLine(neg_n);
    neg_n++;
}
