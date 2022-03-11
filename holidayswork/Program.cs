//задача 1
//Пользователь вводит целые числа до тех пор, пока не введёт ноль. 
//Вывести на экран первые два максимальных и первые два минимальных числа из ряда введенных чисел. 
//Cоздавать массивы в процессе решения запрещено

void toZero(int integer)
{
   Console.WriteLine("Введите еще одно целое число (введите 0 для завершения ввода): ");
    int NewNumber = Convert.ToInt32(Console.ReadLine());
    if (NewNumber < 0 || NewNumber > 0)
    {
        while (NewNumber < 0 || NewNumber > 0)
        {
            int MAX1 = integer;
            int MAX2 = NewNumber;
            Console.WriteLine("Первое максимальное: " + MAX1 + " Второе максимальное: " + MAX2);
            Console.WriteLine("Первое минимальное: " + MAX2 + " Второе минимальное: " + MAX1);
            break;
        }
    }
    else
    {
        Console.WriteLine("Первое максимальное: " + integer + " Второе максимальное: " + NewNumber);
        Console.WriteLine("Первое минимальное: " + NewNumber + " Второе минимальное: " + integer);
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