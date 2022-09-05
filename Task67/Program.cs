// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDigitsOfValue(int value) { if (value <= 0) return 0; return SumDigitsOfValue(value / 10) + value % 10; }

Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

int result = SumDigitsOfValue(value);
Console.WriteLine(result);
