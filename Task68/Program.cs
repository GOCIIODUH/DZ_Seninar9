// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputData(string text)
{
    System.Console.WriteLine(text);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int AckermanFunctions(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermanFunctions(m - 1, 1);
    else if (m > 0 && n > 0) return AckermanFunctions(m - 1, AckermanFunctions(m, n - 1));
    else return 0;
}

int m = InputData("Введите число m: ");
int n = InputData("Введите число n: ");

if (m >= 0 && n >= 0)
    Console.WriteLine(AckermanFunctions(m, n));
else System.Console.WriteLine("Ошибка: Введите не отрицательные целые числа");