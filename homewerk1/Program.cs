//Задача №1
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