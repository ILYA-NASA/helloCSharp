//задача 1
//Пользователь вводит целые числа до тех пор, пока не введёт ноль. 
//Вывести на экран первые два максимальных и первые два минимальных числа из ряда введенных чисел. 
//Cоздавать массивы в процессе решения запрещено

void lostNumber(int integer)
{
    Console.WriteLine("Введите еще одно любое целое число (теперь можете ввести 0 для завершения ввода): ");
    int NextNumber = Convert.ToInt32(Console.ReadLine());
    if (NextNumber < 0 || NextNumber > 0)
    {
        while (NextNumber < 0 || NextNumber > 0)
        {
            lostNumber(NextNumber);
            /*Console.WriteLine("Введите еще одно любое целое число (теперь можете ввести 0 для завершения ввода): ");
            int NewNextNumber = Convert.ToInt32(Console.ReadLine());


            int MAX1 = NextNumber;
            int MAX2 = NewNumber;
            if(NewNextNumber > MAX1) MAX1 = NewNextNumber;
            if(NewNextNumber > MAX2) MAX2 = NewNextNumber;
            Console.WriteLine("Первое максимальное число: " + MAX1 + " Второе максимальное число: " + MAX2);
            Console.WriteLine("Первое минимальное число: " + MAX2 + " Второе минимальное число: " + MAX1);
            break;
            */
        }
    }
    else
    {
        Console.WriteLine("Первое максимальное: " + NextNumber + " Второе максимальное: " + integer);
        Console.WriteLine("Первое минимальное: " + integer + " Второе минимальное: " + NextNumber);
    }
}

void toZero(int NewNumber)
{
    Console.WriteLine("Введите еще одно любое целое число кроме 0: ");
    NewNumber = Convert.ToInt32(Console.ReadLine());
    if (NewNumber < 0 || NewNumber > 0)
    {
        lostNumber(NewNumber);
    }
    else
    {
        Console.WriteLine("ЗДЕСЬ НЕ НУЖНО ВВОДИТЬ 0! Попробуйте еще раз, когда захотите следовать инструкциям.");
    }
}


int Number;
Console.WriteLine("Введите любое целое число кроме 0: ");
Number = Convert.ToInt32(Console.ReadLine());
if (Number == 0)
{
    int Number2;
    Console.WriteLine("Все таки введите любое целое число КРОМЕ 0: ");
    Number2 = Convert.ToInt32(Console.ReadLine());
    if (Number2 == 0)
    {
        int Number3;
        Console.WriteLine("Перестаньте вводить 0, введите любое другое целое число: ");
        Number3 = Convert.ToInt32(Console.ReadLine());
        if (Number3 == 0)
        {
            Console.WriteLine("Так не пойдет! Возвращайтесь, когда будете настроены серьезно. До встречи!");
        }
        else toZero(Number3);
    }
    else toZero(Number2);
}
else toZero(Number);