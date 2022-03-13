//Задача 1
//Пользователь вводит целые числа до тех пор, пока не введёт ноль. 
//Вывести на экран первые два максимальных и первые два минимальных числа из ряда введенных чисел. 

void toZero(int max1, int max2, int min1, int min2)
{
    Console.WriteLine("Введите еще одно любое целое число (теперь можете ввести 0 для завершения ввода): ");
    int NextNumber = Convert.ToInt32(Console.ReadLine());
    if (NextNumber == 0)
    {
        Console.WriteLine("Первое максимальное число: " + max1 + " Второе максимальное число: " + max2);
        Console.WriteLine("Первое минимальное число: " + min1 + " Второе минимальное число: " + min2);
    }
    else
    {
        if (NextNumber > max1)
        {
            if (max2 > max1)
            {
                max1 = max2;
                max2 = NextNumber;
            }
            else
            {
                max2 = NextNumber;
            }
        }
        if (NextNumber > max2)
        {
            max2 = NextNumber;
        }
        if (NextNumber < min1)
        {
            if (min2 < min1)
            {
                min1 = min2;
                min2 = NextNumber;
            }
            else
            {
                min2 = NextNumber;
            }
        }
        if (NextNumber < min2)
        {
            min2 = NextNumber;
        }
        toZero(max1, max2, min1, min2);
    }
}

Console.WriteLine("Введите любое целое число КРОМЕ 0: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number == 0) Console.WriteLine("ЗДЕСЬ НЕ НУЖНО ВВОДИТЬ 0! Попробуйте еще раз, когда захотите следовать инструкциям.");
else
{
    Console.WriteLine("Введите еще одно любое целое число КРОМЕ 0: ");
    int NewNumber = Convert.ToInt32(Console.ReadLine());
    if (NewNumber == 0) Console.WriteLine("ЗДЕСЬ НЕ НУЖНО ВВОДИТЬ 0! Попробуйте еще раз, когда захотите следовать инструкциям.");
    else
    {
        int MAX1 = Number;
        int MAX2 = NewNumber;
        int MIN1 = Number;
        int MIN2 = NewNumber;
        toZero(MAX1, MAX2, MIN1, MIN2);
    }
}