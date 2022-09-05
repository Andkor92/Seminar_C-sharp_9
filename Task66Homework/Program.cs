// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumValuesFromMToN(int m, int n)
{
    if (n == m) return n;
    return SumValuesFromMToN(m, n - 1) + n;
}

Console.WriteLine("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ответ: ");
int sumFromMToN = SumValuesFromMToN(M, N);
Console.WriteLine(sumFromMToN);
