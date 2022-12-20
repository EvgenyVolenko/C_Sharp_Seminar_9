// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();

Console.Write("Введите натуральное число M: ");
int m = EnterDigit();

Console.Write("Введите натуральное число N: ");
int n = EnterDigit();

int res = AkkermanFunction(m, n);
if (res == -1) Console.WriteLine("Функция не может быть рассчитана. Заданы недопустимые параметры.");
else Console.WriteLine($"Результат вычисления Функции Аккермана  = {res}");

int AkkermanFunction(int digitM, int digitN)
{
    if (digitM == 0) return digitN + 1;
    else if (digitM > 0 && digitN == 0)
    {
        return AkkermanFunction(digitM - 1, 1);
    }
    else if (digitM > 0 && digitN > 0)
    {
        return AkkermanFunction(digitM - 1, AkkermanFunction(digitM, digitN - 1));
    }
    else 
    {
        return -1;
    }
}

int EnterDigit()
{
    int digit;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out digit)) break;
        else Console.Write("Ну просил же натуральное ЧИСЛО: ");
    }
    return digit;
}