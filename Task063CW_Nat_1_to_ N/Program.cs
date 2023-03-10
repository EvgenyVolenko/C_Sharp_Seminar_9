// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();

Console.Write("Введите натуральное число N: ");
int n = EnterDigit();

PrintNatural(n);

void PrintNatural(int digit)
{
    if (digit == 0)
    {
        return;
    }
    PrintNatural(digit - 1);
    Console.Write(digit + " ");
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