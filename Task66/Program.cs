// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputData(string text)
{
    System.Console.WriteLine(text);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int OutData(int m, int n)
{
    if (m == n+1) return 0;
    return m + OutData(m+1, n);
}

int m = InputData("Введите число m: ");
int n = InputData("Введите число n: ");
Console.WriteLine(OutData(m, n));
