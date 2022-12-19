// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();

Console.Write("Введите натуральное число N: ");
int n = EnterDigit();
int start = 1;

PrintNatural(n, start);

void PrintNatural(int digit, int start)
{
    if (start <= digit)
    {
        Console.WriteLine(start);
        PrintNatural(digit, start + 1);
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