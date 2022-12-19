// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Clear();

Console.Write("Введите натуральное число M: ");
int m = EnterDigit();

Console.Write("Введите натуральное число N: ");
int n = EnterDigit();

PrintNatural(n, m);

void PrintNatural(int digitN, int digitM)
{
    if (digitM <= digitN)
    {
        Console.WriteLine(digitM);
        PrintNatural(digitN, digitM + 1);
    }
}

int EnterDigit()
{
    int digit;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out digit)) ;
        if (digit > 0) break;
        else Console.Write("Ну просил же натуральное ЧИСЛО: ");
    }
    return digit;
}