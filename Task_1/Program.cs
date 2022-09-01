Console.Clear();

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);
if (M > N)
{
    for (int i = N; i <= M; i++)
    {
        Console.Write($" {i}");
    }
}
else
{
    for (int i = M; i <= N; i++)
    {
        Console.Write($" {i}");
    }
}