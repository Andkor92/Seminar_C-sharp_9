// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermanFunction(m - 1, 1);
    return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

Console.WriteLine("Введите неотрицательное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ответ: ");
if (M < 0 || N < 0) { Console.WriteLine("Введите неотрицательные числа!"); }
else { Console.WriteLine($"A({M},{N}) = {AckermanFunction(M, N)}"); }
