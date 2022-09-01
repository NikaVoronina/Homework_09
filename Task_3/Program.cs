Console.Clear();

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите значение m: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение n: ");
int N = int.Parse(Console.ReadLine()!);

int functionAkkerman = A(M, N);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int A(int M, int N)
{
  if (M == 0) 
  {
    return N + 1;
  }
  else if (N == 0) 
  {
    return A(M - 1, 1);
  }
  else 
  {
    return A(M - 1, A(M, N - 1));
  }
}
