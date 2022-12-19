// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();

Console.Write("Введите натуральное число A: ");
int a = EnterDigit();

Console.Write("Введите натуральное число B: ");
int b = EnterDigit();

Console.WriteLine(VozvedStep(a, b));

int VozvedStep(int digitA, int digitB)
{
    if (digitB == 0)
    {
        return 1;
    }
    digitB--;
    digitA *= VozvedStep(digitA, digitB);
    return digitA;
}

int EnterDigit()
{
    int digit;
    while (true)
    {
        int.TryParse(Console.ReadLine(), out digit);
        if (digit >= 0) break;
        else Console.Write("Ну просил же натуральное ЧИСЛО: ");
    }
    return digit;
}