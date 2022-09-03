﻿Console.Clear();

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29


int Akkerman(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  else if (n == 0 && m > 0)
  {
    return Akkerman(m - 1, 1);
  }
  else
  {
    return Akkerman(m - 1, Akkerman(m, n - 1));
  }
}

int m = InputNumber("Ввод m: ");
int n = InputNumber("Ввод n: ");
int akkermanFunction = Akkerman(m, n);
Console.Write($"m = {m}, n = {n} - > A(m,n) = {akkermanFunction} ");
