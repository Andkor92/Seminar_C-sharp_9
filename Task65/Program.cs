// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void PrintNumbersToN(int m, int n)
{
    if (n < m) return;
    PrintNumbersToN(m, n - 1);
    Console.Write(n + " ");
}

Console.WriteLine("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

PrintNumbersToN(M, N);
