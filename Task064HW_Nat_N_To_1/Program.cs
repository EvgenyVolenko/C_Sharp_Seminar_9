// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.Write("Введите натуральное число N: ");
int n = EnterDigit();

PrintNatural(n);

void PrintNatural(int digit)
{
    if (digit > 0)
    {
        Console.Write(digit + " ");
        PrintNatural(digit - 1);
    }
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