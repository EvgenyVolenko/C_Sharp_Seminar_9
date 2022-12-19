// Задача 67: Напишите программу, которая будет 
// принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();

Console.Write("Введите натуральное число N: ");
int n = EnterDigit();

Console.WriteLine(SumOfDigits(n));

int SumOfDigits(int digit)
{
    int sum = 0;
    if (digit == 0)
    {
        return 0;
    }
    sum = SumOfDigits(digit / 10) + digit % 10;
    return sum;
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