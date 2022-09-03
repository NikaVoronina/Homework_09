Console.Clear();

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void PrintSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма натуральных элементов = {sum}");
        return;
    }
    PrintSum(m, n - 1, sum);

}
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}
PrintSum(m, n, temp = 0);