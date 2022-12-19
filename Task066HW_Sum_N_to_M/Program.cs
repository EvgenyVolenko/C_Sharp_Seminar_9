// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите натуральное число M: ");
int m = EnterDigit();

Console.Write("Введите натуральное число N: ");
int n = EnterDigit();

Console.WriteLine(SumNatural(n, m));

int SumNatural(int digitN, int digitM)
{
    int sum = 0;
    if (digitM <= digitN)
    {
        sum = digitM + SumNatural(digitN, digitM + 1);
        return sum;
    }
    return 0;
}

int EnterDigit()
{
    int digit;
    while (true)
    {
        int.TryParse(Console.ReadLine(), out digit);
        if (digit > 0) break;
        else Console.Write("Ну просил же натуральное ЧИСЛО: ");
    }
    return digit;
}